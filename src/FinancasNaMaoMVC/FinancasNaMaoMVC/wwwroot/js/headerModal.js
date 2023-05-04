const openModalCadastroButton = document.querySelector(".open-modal-Cadastro");
const modalRegister = document.querySelector("#modalCadastro");
const fadeRegister = document.querySelector("#fadeCadastro");

const openModalLoginButton = document.querySelector(".open-modal-login");
const closeModalButton = document.querySelector("#close-modal");
const modalLogin = document.querySelector("#modalLogin");
const fadeLogin = document.querySelector("#fadeLogin");

const openModalPasswordButton = document.querySelector(".open-modal-password");
const modalPassword = document.querySelector("#modalPassword");
const fadePassword = document.querySelector("#fadePassword");

const backBtn = document.querySelector(".backBtn")
const registerModalBtn = document.querySelector(".registerModalBtn")

const toggleModalPassword = () => {
  modalPassword.classList.toggle("hide");
  fadePassword.classList.toggle("hide");
};

openModalPasswordButton.addEventListener("click", ()=>{
  toggleModalLogin()
  toggleModalPassword()
})

fadePassword.addEventListener("click", ()=>{
  toggleModalPassword()
})

backBtn.addEventListener("click", ()=>{
  toggleModalPassword()
  toggleModalLogin()

})

registerModalBtn.addEventListener("click", ()=>{
  toggleModalLogin()
  toggleModalRegister()
})



const toggleModalLogin = () => {
  modalLogin.classList.toggle("hide");
  fadeLogin.classList.toggle("hide");
};

[openModalLoginButton, fadeLogin].forEach((el) => {
  el.addEventListener("click", () => toggleModalLogin());
});

fadeLogin.addEventListener("click", ()=>{
  modalLogin.classList.add("hide");
  fadeLogin.classList.add("hide");
})



    const toggleModalRegister = () => {
      modalRegister.classList.toggle("hide");
      fadeRegister.classList.toggle("hide");
    };
    
    [openModalCadastroButton, fadeRegister].forEach((el) => {
      el.addEventListener("click", () => toggleModalRegister());
    });
    
