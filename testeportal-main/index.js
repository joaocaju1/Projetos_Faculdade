const express = require('express');
const app = express();
const port = 3000; // Escolha a porta desejada
const mysql = require('mysql');
const bodyParser = require('body-parser');
const nodemailer = require('nodemailer'); // Importe o Nodemailer
const session = require('express-session');
const path = require('path');


app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'ejs'); // Configurar o mecanismo de template EJS
app.use(express.static(__dirname)); // Adicione esta linha para servir arquivos estáticos

app.get('/', (req, res) => {
  res.render('index', { notas }); // Substitua "notas" com os dados que você deseja passar para a página
});

app.use(session({
  secret: 'suaChaveSecreta', // Substitua por uma chave secreta segura
  resave: false,
  saveUninitialized: true,
}));


const transporter = nodemailer.createTransport({
  service: 'Gmail', // Exemplo: 'Gmail'
  auth: {
      user: 'jgpretti2002@gmail.com',
      pass: 'azlr oqqn sypb yfnt'
  }
});

app.use(bodyParser.urlencoded({ extended: true }));

const db = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: 'root',
    database: 'bancoportaldasa'
});

db.connect(err => {
    if (err) {
        console.error('Erro de conexão com o banco de dados:', err);
        return;
    }
    console.log('Conexão com o banco de dados estabelecida.');
});

app.get('/register', (req, res) => {
  app.use(express.static(__dirname));
    res.sendFile(__dirname + '/register.html');
});

app.post('/register', (req, res) => {
  app.use(express.static(__dirname));
  const { email, nome, login, senha, telefone } = req.body;
  const token = require('crypto').randomBytes(32).toString('hex'); // Gere uma string aleatória de 64 caracteres em hexadecimal
  const validationURL = `http://localhost:3000/validate?email=${email}&token=${token}`; // Defina a variável validationURL dentro deste escopo

  const query = "INSERT INTO usuarios (email, nome, login, senha, telefone, autenticacao, token) VALUES (?, ?, ?, ?, ?, 0, ?)";
  db.query(query, [email, nome, login, senha, telefone, token], (err, result) => {
      if (err) {
          console.error('Erro no registro:', err);
          res.redirect('/erro.html');
      } else {
          console.log('Registro bem-sucedido.');

          // Agora, você pode usar validationURL dentro deste escopo
          const mailOptions = {
              from: 'jgpretti2002@gmail.com',
              to: email,
              subject: 'Email de validação',
              text: `Clique no link a seguir para validar sua conta: ${validationURL}`
          };

          // Envie o email
          transporter.sendMail(mailOptions, (err, info) => {
              if (err) {
                  console.error('Erro ao enviar o email de validação:', err);
                  res.redirect('/erro.html');
              } else {
                  console.log('Email de validação enviado.');
                  res.redirect('/login.html'); // Redirecionar para uma página de sucesso
              }
          });
      }
  });
});

// Rota para a página de logout
app.get('/logout', (req, res) => {
  // Encerrar a sessão
  req.session.destroy((err) => {
      if (err) {
          console.error('Erro ao encerrar a sessão:', err);
          res.status(500).send('Erro ao encerrar a sessão');
      } else {
          res.sendFile(__dirname + '/logout.html');
      }
  });
});

app.get('/validate', (req, res) => {
  const email = req.query.email; // Recupere o e-mail da URL
  const token = req.query.token; // Recupere o token da URL

  // Consulte o banco de dados para encontrar o usuário com o e-mail e o token correspondentes
  const query = "SELECT * FROM usuarios WHERE autenticacao = 0 AND email = ? AND token = ?";

  db.query(query, [email, token], (err, results) => {
      if (err) {
          console.error('Erro ao consultar o banco de dados:', err);
          res.redirect('/erro.html'); // Redirecionar para uma página de erro em caso de erro no banco de dados
      } else if (results.length === 1) {
          // Encontrou um registro com o e-mail e token correspondentes
          // Atualize o campo "autenticacao" para 1
          const updateQuery = "UPDATE usuarios SET autenticacao = 1 WHERE email = ? AND token = ?";
          db.query(updateQuery, [email, token], (err) => {
              if (err) {
                  console.error('Erro ao atualizar o campo "autenticacao":', err);
                  res.redirect('/erro.html'); // Redirecionar para uma página de erro em caso de erro na atualização
              } else {
                  // Redirecionar o usuário para uma página de sucesso
                  res.redirect('/sucesso.html');
              }
          });
      } else {
          // Nenhum registro encontrado com o e-mail e token correspondentes
          res.redirect('/erro.html'); // Redirecionar para uma página de erro
      }
  });
});

app.get('/portalprivado', (req, res) => {
  const nomeDoUsuario = req.session.nomeDoUsuario;

  if (!nomeDoUsuario) {
    res.redirect('/login');
    return;
  }

  // Agora, passe o nomeDoUsuario para a renderização do EJS
  res.render('portalprivado', { nomeDoUsuario });
});



app.get('/login', (req, res) => {
  res.sendFile(__dirname + '/login.html');
});

app.post('/login', (req, res) => {
  const { login, senha } = req.body;

  // Verifique as credenciais no banco de dados
  const query = "SELECT email, nome FROM usuarios WHERE login = ? AND senha = ? AND autenticacao = 1";

  db.query(query, [login, senha], (err, results) => {
    if (err) {
      console.error('Erro ao consultar o banco de dados:', err);
      res.redirect('/erro.html');
    } else if (results.length === 1) {
      const { email, nome } = results[0]; // Obtenha o email e o nome do usuário

      // Armazene o email do usuário na sessão
      req.session.email = email;
      req.session.nomeDoUsuario = nome; // Também armazene o nome do usuário, se necessário

      // Redirecione o usuário para o portal privado
      res.redirect('/portalprivado');
    } else {
      res.redirect('/erro.html');
    }
  });
});

// Rota para a página vagas.html
app.get('/vagas', (req, res) => {
  res.sendFile(path.join(__dirname, 'public', 'vagas.html'));
});

// Rota para conteudos.html
app.get('/conteudos', (req, res) => {
  res.sendFile(path.join(__dirname, 'public', 'conteudos.html'));
});

// Rota para conteudos.html
app.get('/noticias', (req, res) => {
  res.sendFile(path.join(__dirname, 'public', 'noticias.html'));
});

app.get('/portalprivado', (req, res) => {
  
  const nomeDoUsuario = req.session.nomeDoUsuario;

  // Verifique se o usuário está autenticado antes de mostrar o portal privado
  if (!nomeDoUsuario) {
    res.redirect('/login');
    return;
  }

  res.render('portalprivado', { nome: nomeDoUsuario });
});

app.get('/debug', (req, res) => {
  if (req.session.nomeDoUsuario) {
    res.send(`Usuário logado: ${req.session.nomeDoUsuario}`);
  } else {
    res.send('Nenhum usuário logado.');
  }
});

app.get('/portalDASA', (req, res) => {
  res.sendFile(__dirname + '/portal');
});



app.get('/logout', (req, res) => {
  // Destrua a sessão do usuário
  req.session.destroy((err) => {
    if (err) {
      console.error('Erro ao encerrar a sessão:', err);
    }
    // Redirecione o usuário de volta para a página de login
    res.redirect('/login');
  });
});

app.post('/adicionar-nota', (req, res) => {
  const { titulo, nota } = req.body;

  if (!titulo || !nota) {
    res.status(400).send('Título e nota não podem ser vazios.');
    return;
  }

  if (!req.session.email) {
    res.redirect('/login');
    return;
  }

  const email = req.session.email;

  const query = "INSERT INTO notas (email, titulo, nota) VALUES (?, ?, ?)";
  db.query(query, [email, titulo, nota], (err, result) => {
    if (err) {
      console.error('Erro ao inserir a nota no banco de dados:', err);
      res.status(500).send('Erro ao adicionar a nota.');
    } else {
      console.log('Nota adicionada com sucesso.');
      res.redirect('/notas');
    }
  });
});


app.get('/notas', (req, res) => {
  if (!req.session.email) {
    res.redirect('/login');
    return;
  }

  const email = req.session.email;

  const query = "SELECT * FROM notas WHERE email = ?";
  db.query(query, [email], (err, results) => {
    if (err) {
      console.error('Erro ao consultar o banco de dados:', err);
      res.status(500).send('Erro ao obter notas.');
    } else {
      res.render('notas', { notas: results });
    }
  });
});

app.get('/atualizar-nota/:id', (req, res) => {
  // Lógica para carregar a nota com o ID especificado e renderizar a página de atualização
});

app.get('/excluir-nota/:id', (req, res) => {
  // Lógica para carregar a nota com o ID especificado e renderizar a página de exclusão
});

// As rotas para adicionar, atualizar e excluir notas também precisam ser atualizadas.



app.use(express.json());

app.post('/atualizar-nota/:id', (req, res) => {
  const nota_id = req.params.id; // Obtenha o ID da nota a partir da URL
  const novoTexto = req.body.novoTexto; // Obtenha o novo texto da nota do corpo da solicitação

  if (!nota_id) {
    res.status(400).send('ID da nota não fornecido.');
    return;
  }

  if (!req.session.email) {
    res.redirect('/login');
    return;
  }

  const email = req.session.email;

  // Use a sua consulta SQL para atualizar a nota no banco de dados
  const updateQuery = "UPDATE notas SET nota = ? WHERE id = ? AND email = ?";
  db.query(updateQuery, [novoTexto, nota_id, email], (err, result) => {
    if (err) {
      console.error('Erro ao atualizar a nota no banco de dados:', err);
      res.status(500).send('Erro ao atualizar a nota.');
    } else {
      if (result.affectedRows === 0) {
        res.status(404).send('Nota não encontrada ou não autorizada para edição.');
      } else {
        res.json({ success: true });
      }
    }
  });
});




app.post('/excluir-nota/:id', (req, res) => {
  const nota_id = req.params.id; 
  if (!nota_id) {
    res.status(400).send('ID da nota não fornecido.');
    return;
  }

  if (!req.session.email) {
    res.redirect('/login');
    return;
  }

  const email = req.session.email;

  const deleteQuery = "DELETE FROM notas WHERE id = ? AND email = ?";
  db.query(deleteQuery, [nota_id, email], (err, result) => {
    if (err) {
      console.error('Erro ao excluir a nota no banco de dados:', err);
      res.status(500).send('Erro ao excluir a nota.');
    } else {
      console.log('Nota excluída com sucesso.');
      res.redirect('/notas');
    }
  });
});

app.listen(port, () => {
    console.log(`App rodando na porta ${port}`);
});
