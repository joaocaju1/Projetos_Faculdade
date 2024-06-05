"use strict";

const user = document.getElementById("user");
const senha = document.getElementById("senha");
const btnEntrar = document.getElementById("btnEntrar");
const saida = document.getElementById("saida");


function validarLogin(){
    // Verifica qual Usuarios cadastro
    if(user.value=="adm@adm.com" && senha.value=="123"){
        saida.textContent="Entrando...";
        location.href="EstoqueCinzaMateriais.html";
    }else{
        if(user.value=="" || senha.value==""){
            saida.textContent="Preencha os campos";
            if(user.value==""){
                user.focus();
            }else{
                senha.focus();
            }
        }
        else{
            saida.textContent="Usuario não cadastrado";
            user.value="";
            senha.value="";
            user.focus();
        }
    }
    
}

btnEntrar.addEventListener("click", validarLogin);
