//Objetos
//Musica musica1 = new Musica();
//musica1.Nome = "Redhot";
//musica1.Artista = "Nao sei";
//musica1.Duracao = 273;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.DescricaoResumida);

//Musica musica2 = new Musica();
//musica2.Nome = "redhot";
//musica2.Artista = "nao sei2";
//musica2.Duracao = 300;
//musica2.Disponivel = false;
//Console.WriteLine(musica2.DescricaoResumida);


//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();

//Banda Queen = new Banda("Queen");

//Album albumDoQueen = new Album("bluepen");

//Musica musica1 = new Musica(Queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};


//Musica musica2 = new Musica(Queen, "Love of my life")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);

//albumDoQueen.ExibirMusicas();

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();

//Queen.AdicionarAlbum(albumDoQueen);
//Queen.ExibirDiscografia();

episodio ep1 = new(1, "Tecnicas de falicitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");


episodio ep2 = new(2, "Tecnicas de aprendizado", 77);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Bia");

Podcast podcast = new("Podcast Especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

