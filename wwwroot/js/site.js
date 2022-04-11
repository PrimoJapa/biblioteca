/* Função Validar */

var form = document.getElementById("Cadastro");
 
if (form.addEventListener) {                   
    form.addEventListener("submit", validaCadastro);
} else if (form.attachEvent) {                  
    form.attachEvent("onsubmit", validaCadastro);
}

function validaCadastro(evt){
    var whatsapp = document.getElementById("inputTel");
    var filtrooo = /[a-zA-ZáãâéêíîóôõúçÇ]+$/;
	var fil = /[0-9]{16}/;
    var contErro = 0;

    /* Validação do campo WhatsApp */
	caixa_whatsapp = document.querySelector('.msg-whatsapp');
    if(whatsapp.value == ""){
	caixa_whatsapp.innerHTML = "O campo deve ser preenchido!";
	caixa_whatsapp.style.display = 'block';
	evt.preventDefault();
	contErro += 1;

    }else if(fil.test(whatsapp.value)){
	caixa_whatsapp.innerHTML = "Telefone Invalido";
	caixa_whatsapp.style.display = 'block';
	evt.preventDefault();
	contErro += 1;

    }else if(filtrooo.test(whatsapp.value)){
	caixa_whatsapp.innerHTML = "Não deve conter letras!";
	caixa_whatsapp.style.display = 'block';
	evt.preventDefault();
	contErro += 1;

    }else if(whatsapp.value.length < 15 || whatsapp.value.length > 15){
		caixa_whatsapp.innerHTML = "Telefone Invalido";
		caixa_whatsapp.style.display = 'block';
		evt.preventDefault();
		contErro += 1;
    }else{
	     caixa_whatsapp.style.display = 'none';
    }
}

function mascaraFone(event) {
    var valor = document.getElementById("inputTel").attributes[0].ownerElement['value'];
    var retorno = valor.replace(/\D/g, "");
    retorno = retorno.replace(/^0/, "");
    if (retorno.length > 10) {
      retorno = retorno.replace(/^(\d\d)(\d{5})(\d{4}).*/, "($1) $2-$3");
    } else if (retorno.length > 5) {
      if (retorno.length == 6 && event.code == "Backspace") { 
        // necessário pois senão o "-" fica sempre voltando ao dar backspace
        return; 
      } 
      retorno = retorno.replace(/^(\d\d)(\d{4})(\d{0,4}).*/, "($1) $2-$3");
    } else if (retorno.length > 2) {
      retorno = retorno.replace(/^(\d\d)(\d{0,5})/, "($1) $2");
    } else {
      if (retorno.length != 0) {
        retorno = retorno.replace(/^(\d*)/, "($1");
      }
    }
    document.getElementById("inputTel").attributes[0].ownerElement['value'] = retorno;
  }