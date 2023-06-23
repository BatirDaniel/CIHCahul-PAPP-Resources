const display = document.getElementById('display')

const par = (n)=>{
    let val = n%2 === 0?true:false
    return val
}

const impar = (n)=>{
    let val = n%2 !== 0?true:false
    return val
}

const prim = (n) =>{
    let isPrime = true
    if(n === 0) return false
    if (n === 1){
        return false
    }
    else if (n > 1) {
        for (let i = 2; i < n; i++) {
            if (n % i === 0) {
                isPrime = false
                break;
            }
        }
    }
    return isPrime
}

const afisareDate = ()=>{
    for (let i = 0; i <= 101; i++) {

        if (prim(i)) {
            display.innerHTML += `<div class='value prim'>${i}</div>`
        }
        else if (par(i)) {
            display.innerHTML += `<div class='value par'>${i}</div>`
        }
        else if(impar(i)){
            display.innerHTML += `<div class='value impar'>${i}</div>`
        }
    }
}
afisareDate()