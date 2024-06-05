"use strict";

const newUser = document.getElementById("newUser");
const newSenha = document.getElementById("newSenha");
const newSenhaC = document.getElementById("newSenhaC");
const btnConfirmaCadastro = document.getElementById("btnConfirmaCadastro");
const saida =  document.getElementById("saida");

const BDcadastro = [];

function validarCadastro(){
    if(newUser.value=="" || newSenha.value=="" || newSenhaC.value==""){
        saida.textContent="Preencha todos os campos";
        if(newUser.value==""){
            newUser.focus();
        }else{
            if(newSenha.value==""){
                newSenha.focus();
            }else{
                newSenhaC.focus();
            }
        }
    }else{
        if(newSenha.value==newSenhaC.value){
            const cadastro = new Object();
            cadastro.user = newUser.value;
            cadastro.senha = newSenha.value;
            cadastro.id = BDcadastro.length;
            BDcadastro.push(cadastro);
            location.href="EstoqueCinzaMateriais.html";
        }else{
            saida.textContent="Senhas diferentes";
            newSenha.value="";
            newSenhaC.value="";
            newSenha.focus();
        }
    }
}

btnConfirmaCadastro.addEventListener("click", validarCadastro);