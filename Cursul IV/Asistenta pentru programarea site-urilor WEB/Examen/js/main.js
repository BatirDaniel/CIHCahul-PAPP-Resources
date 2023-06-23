const darkmode = document.getElementById('dark-mode')
const plus = document.getElementById('plus')
const minus = document.getElementById('minus')
const color = document.getElementById('color')
let container = document.querySelector('.container')
let fontSize = 14

darkmode.addEventListener('click',()=>{
    if(container.classList.contains('light')){
        container.classList.remove('light')
        container.classList.add('dark')
    }
    else{
        container.classList.remove('dark')
        container.classList.add('light')
    }
})

plus.addEventListener('click',()=>{
    document.body.style.fontSize = `${fontSize++}px`
})

minus.addEventListener('click',()=>{
    document.body.style.fontSize = `${fontSize--}px`
})

color.addEventListener('input',()=>{
    container.style.backgroundColor=color.value
})