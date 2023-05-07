const form = document.getElementById('cadastroform');
const nome = document.getElementById('nomeCadastro');
const email = document.getElementById('emailCadastro');
const contato = document.getElementById('contatoCadastro');
const senha = document.getElementById('senhaCadastro');
const senhaConfirmar = document.getElementById('senhaConfirmarCadastro');
const cadastrar = document.getElementById('cadastrar');
const msgError = document.querySelector('.msgError');
const emailRegex = /^\w+([.-]?\w+)@\w+([.-]?\w+)(.\w{2,3})+$/;
const passwordRegex = /^(?=.*[A-Z])/;
const letterSpaceRegex = /^[a-zA-Z\s]+$/;

cadastrar.addEventListener("click", (e)=>{
  e.preventDefault()
  console.log("oi")

  if(email.value==""||nome.value==""||contato.value==""|| senha.value==""||senhaConfirmar.value==""){
    msgError.innerText="Preencha todos os campos"
    msgError.style.display="flex"
  }

  else if(senha.value!=senhaConfirmar.value){
    msgError.innerText="Senha não coincidem"
    msgError.style.display="flex"
  }
 
  else if(senha.value.length<8){
    msgError.innerText="Senha requer no minimo 8 caracteres"
    msgError.style.display="flex"
  }

  else if(contato.value.length<11){
    msgError.innerText="Contato requer no minimo 11 caracteres"
    msgError.style.display="flex"
  }

  else if(!emailRegex.test(email.value)){
    msgError.innerText="Email inválido."
    msgError.style.display="flex"
  }

    else if(!passwordRegex.test(senha.value)){
    msgError.innerText="Senha requer no mínimo 1 letra maiuscula"
    msgError.style.display="flex"
  }

    else if(nome.value.length<11){
    msgError.innerText="Nome requer no mínimo 11 caracteres"
    msgError.style.display="flex"
  }

  else if(!letterSpaceRegex.test(nome.value)){
    msgError.innerText="Nome requer somente letras"
    msgError.style.display="flex"
  }
  
  else{ 
    const usuario={
      "nome":nome.value,
      "email":email.value,
      "contato":contato.value,
      "senha":senha.value
    }

    // teste redirecionar pagina
    // fetch('https://pokeapi.co/api/v2/pokemon/pikachu', {
    //   method: 'POST', 
    //   body: usuario
      
    // })
    // .then(response => response.json())
    // .then(data =>
    // console.log(data)
    // )

    alert(`Sua conta com o email: ${usuario.email} foi criada!`)
    console.log(usuario)
  }
})
