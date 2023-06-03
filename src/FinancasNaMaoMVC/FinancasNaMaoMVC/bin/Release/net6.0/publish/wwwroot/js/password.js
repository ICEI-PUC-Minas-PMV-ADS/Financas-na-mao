const passwordErrors = document.querySelector(".passwordErrors")
const emailInput = document.querySelector(".emailPassword")
const passwordSubmit = document.querySelector(".passwordSubmit")

passwordSubmit.addEventListener("click", (e)=>{
    e.preventDefault()
    if(emailInput.value == ""){
        passwordErrors.innerText = "Preencha o campo de email"
        passwordErrors.style.display = "flex"
    }
})