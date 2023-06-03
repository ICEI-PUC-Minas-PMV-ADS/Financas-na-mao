const loginErrors = document.querySelector(".loginErrors")
const loginEmail = document.querySelector("#emailLogin")
const loginPassword = document.querySelector("#passwordLogin")
const loginSubmit = document.querySelector("#submitLogin")

loginSubmit.addEventListener("click", ()=>{
    if(loginEmail.value == "" || loginPassword.value == ""){
        loginErrors.innerText = "Preencha todos os campos"
        loginErrors.style.display = "flex"
    }
})