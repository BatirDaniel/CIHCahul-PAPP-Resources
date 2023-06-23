const form = document.getElementById('login-form')

form.addEventListener('submit',(e)=>{
    e.preventDefault()
    
    const username = document.getElementById('username')
    const password = document.getElementById('password')

    let patUsername = /^[A-Za-z]{8,20}$/
    let patPassword = /^[A-Za-z0-9]{12,20}$/
    
    const div1 = document.getElementById('error1')

    if (!patUsername.test(username.value)){
        div1.innerHTML='Username is incorrect !'
        username.after(div1)
    }else{
        div1.innerHTML=''
        username.after(div1)
    }

    const div2 = document.getElementById('error2')
    if (!patPassword.test(password.value)){
        div2.innerHTML='Password is incorrect !'
        password.after(div2)
    }else{
        div2.innerHTML=''
        password.after(div2)
    }
})