// Pega o modal
var modal = document.getElementById("modalCategoria");

// Pega o botão que abre o modal
var btn = document.getElementById("btnCategoria");

// Pega o elemento <span> que fecha o modal
var span = document.getElementsByClassName("close")[0];

// Quando o usuário clicar no botão, abre o modal


btn.addEventListener("click",()=>{
    modal.style.display = "block";
    
})

// Quando o usuário clicar em <span> (x), fecha o modal
span.onclick = function() {
  modal.style.display = "none";
}

// Quando o usuário clicar em qualquer lugar fora do modal, feche-o
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}

// Quando o usuário clicar no botão salvar, registra o valor de entrada
var salvarBtn = document.getElementById("adicionar");
salvarBtn.onclick = function() {
  var categoriaInput = document.getElementById("categoria");
  console.log(categoriaInput.value);
}

// Quando o usuário clicar no botão salvar, registra o valor de entrada
var salvarBtn = document.getElementById("adicionar");

salvarBtn.addEventListener("click",()=>{
    console.log("clicou")
    var categoriaInput = document.getElementById("categoria");
  var select=document.getElementById("selectCategoria")
  var option=document.createElement("option");
  option.textContent=categoriaInput.value;
  option.value=categoriaInput.value;
  option.selected=true;
  select.appendChild(option);
  alert("Categoria adicionada com sucesso!");

})

function fecharModal() {
    var modal = document.getElementById("modalCategoria");
    modal.style.display = "none";
  }

  var salvarBtn = document.getElementById("adicionar");
salvarBtn.onclick = function() {
  var categoriaInput = document.getElementById("categoria");
  var categoriaSelecionada = document.getElementById("categoriaSelecionada");


  fecharModal();
}

