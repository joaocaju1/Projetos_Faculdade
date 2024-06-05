document.addEventListener('DOMContentLoaded', function () {
    
    const form = document.getElementById('meuformulario');
    const nomeInput = document.getElementById('nome');
    const sobrenomeInput = document.getElementById('sobrenome')
    const emailInput = document.getElementById('email');
    const senhaInput = document.getElementById('senha');
    const confirmasenhaInput = document.getElementById('confirmasenha');

    function hideError(inputElement, errorElement) {
        if(inputElement !== '') {
            errorElement.textContent = '';
        }
    }

    nomeInput.addEventListener('input', function ()  {
        hideError(nomeInput, document.getElementById('nomeError'));
    });

    sobrenomeInput.addEventListener('input', function ()  {
        hideError(sobrenomeInput, document.getElementById('sobrenomeError'));
    });

    emailInput.addEventListener('input', function ()  {
        hideError(emailInput, document.getElementById('emailError'));
    });

    senhaInput.addEventListener('input', function ()  {
        hideError(senhaInput, document.getElementById('senhaError'));
    });

    confirmasenhaInput.addEventListener('input', function ()  {
        hideError(confirmasenhaInput, document.getElementById('confirmasenhaError'));
    });



    form.addEventListener('submit', function (event){
        let valid = true;

        if(nomeInput.value === ''){
            document.getElementById('nomeError').textContent = 'Por favor, preencha o nome.'
            valid = false;
        }

        if(sobrenomeInput.value === ''){
            document.getElementById('sobrenomeError').textContent = 'Por favor, preencha o sobrenome.'
            valid = false;
        }

        if(emailInput.value === ''){
            document.getElementById('emailError').textContent = 'Por favor, preencha o email.'
            valid = false;
        }

        if(senhaInput.value === ''){
            document.getElementById('senhaError').textContent = 'Por favor, preencha a senha.'
            valid = false;
        }

        if(confirmasenhaInput.value === ''){
            document.getElementById('confirmasenhaError').textContent = 'Por favor, preencha a confirmação de senha.'
            valid = false;
        }


        if (!valid){
            event.preventDefault();
        }
    });
});