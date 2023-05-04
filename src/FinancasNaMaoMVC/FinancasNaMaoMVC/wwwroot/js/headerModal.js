const openModalCadastroButton = document.querySelector(".open-modal-Cadastro");
const modalRegister = document.querySelector("#modalCadastro");
const fadeRegister = document.querySelector("#fadeCadastro");



    const toggleModalRegister = () => {
      modalRegister.classList.toggle("hide");
      fadeRegister.classList.toggle("hide");
    };
    
    [openModalCadastroButton, fadeRegister].forEach((el) => {
      el.addEventListener("click", () => toggleModalRegister());
    });
    
