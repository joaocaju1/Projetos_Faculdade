"use strict";

const emailRec = document.getElementById("emailRec");
const saida =  document.getElementById("saida");
const btnConfirmaEmail = document.getElementById("btnConfirmaEmail");

function enviaEmail(){
    if(emailRec.value==""){
        saida.textContent="Insira o email da conta";
        emailRec.focus();
        emailRec.value="";
    }else{
        saida.textContent="Enviamos um email de recuperação de senha para o seu Email";
        emailRec.value="";
    }
}

btnConfirmaEmail.addEventListener("click", enviaEmail);