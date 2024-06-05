"use strict";

let btnCadastrar = document.getElementById("btnCadastrar");
let btnRemover = document.getElementById("btnRemover");
let btnEditar = document.getElementById("btnEditar");

let btnCadastrarUser =  document.getElementById("btnCadastrarUser");

const user = document.getElementById("user");
const senha = document.getElementById("senha");

let nome = document.querySelectorAll('#registro input')[0];
let quantidade = document.querySelectorAll('#registro input')[1];
let preco = document.querySelectorAll('#registro input')[2];

let tabela = document.querySelector('#estoque table');
let BD = [];

function cadastrarProduto(){
    if(nome.value=="" || quantidade.value=="" || preco.value==""){
        saida.textContent="Preencha todos os campos...";
    }else{
        let produto = new Object();
        produto.nome = nome.value;
        produto.quantidade = quantidade.value;
        produto.preco = preco.value;
        produto.id = BD.length;
        BD.push(produto);
        tabela.innerHTML += `<tr><td><input type="checkbox" id="${produto.id}" onchange="verificar(this.id)"></td><td>${produto.nome}</td><td>${produto.quantidade}</td><td>${preco.value}</td></tr>`;
        nome.value="";
        quantidade.value="";
        preco.value="";
        saida.textContent="";
    }
}

function removerProduto(){
    for (let i = 0; i < BD.length; i++){
        let elemento = document.querySelectorAll('#estoque table tr td input')[i];
        if (elemento.checked){
            BD.splice(elemento.id, 1);
            tabela.innerHTML = `<tr><td></td><td>Nome</td><td>Quant.</td><td>Preço</td></tr>`;
            montarTabela();
            nome.value="";
            quantidade.value="";
            preco.value="";
            saida.value="";
        }
    }
}

function montarTabela(){
    for (let i = 0; i < BD.length; i++){
        tabela.innerHTML += `<tr><td><input type="checkbox" id="${i}" onchange="verificar()"></td><td>${BD[i].nome}</td><td>${BD[i].quantidade}</td><td>${BD[i].preco}</td></tr>`;
    }
}

function editarProduto(){
    for (let i = 0; i < BD.length; i++){
        let elemento = document.querySelectorAll('#estoque table tr td input')[i];
        if (elemento.checked){
            BD[i].nome = nome.value;
            BD[i].quantidade = quantidade.value;
            BD[i].preco = preco.value;

            tabela.innerHTML = `<tr><td></td><td>Nome</td><td>Quant.</td><td>Preço</td></tr>`;
            montarTabela();
            nome.value="";
            quantidade.value="";
            preco.value="";
        }
    }   
}

function verificar(id){
    let cont = 0;
    for (let i = 0; i < BD.length; i++){
        let elemento = document.querySelectorAll('#estoque table tr td input')[i];
        if (elemento.checked){
            nome.value = BD[i].nome;
            quantidade.value = BD[i].quantidade;
            preco.value = BD[i].preco;

            cont++;
            if (cont > 1){
                saida.textContent="Não é possivel selecionar dois Produtos";
                elemento.checked = false;
                break;
            }
        }
    }
}

function sair(){
    location.href="indexCinzaMateriais.html";
}

function cadastrarUser(){
    location.href="CadastroCinzaMateriais.html";
}

btnCadastrar.addEventListener("click", cadastrarProduto);
btnRemover.addEventListener("click",removerProduto);
btnEditar.addEventListener("click", editarProduto);

btnSair.addEventListener("click", sair);
btnCadastrarUser.addEventListener("click", cadastrarUser);