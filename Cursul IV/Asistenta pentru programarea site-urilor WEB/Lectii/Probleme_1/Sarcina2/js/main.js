const formular = document.getElementById('formular')

formular.addEventListener('keyup',(e)=>{
    e.preventDefault()
    const result = document.getElementById('result')
     
    let a = Number(document.getElementById('a').value)
    let b = Number(document.getElementById('b').value)
    let c = Number(document.getElementById('c').value)

    let delta = Math.sqrt(b) - (4*a*c)

    if (delta < 0) {
        result.innerText = "Ecuatia "+a+"x^2 + "+b+"x + "+c+"=0 nu are rădăcini reale x1,2 ∉R"
    }
    else{
        if (delta === 0) {
            let x = -b/(2*a)
            result.innerText = "Ecuatia "+a+"x^2 + "+b+"x + "+c+"=0 are 2 solutii egale \nx="+x.toFixed(2)
        }
        else{
            let x1 = (-b+Math.sqrt(delta))/(2*a)
            let x2 = (-b-Math.sqrt(delta))/(2*a)

            result.innerText = "Ecuatia "+a+"x^2 + "+b+"x + "+c+"=0 are 2 solutii dinstincte "+
            "\nx1="+x1.toFixed(2)+"\nx2="+x2.toFixed(2)
        }
    }
})