const btn1 = document.getElementById('btn-1')
const btn2 = document.getElementById('btn-2')
const btn3 = document.getElementById('btn-3')
const btn4 = document.getElementById('btn-4')
const btn5 = document.getElementById('btn-5')
const btn6 = document.getElementById('btn-6')
const btn7 = document.getElementById('btn-7')
const btn8 = document.getElementById('btn-8')
const allBtn = document.querySelectorAll('button')
const display = document.querySelector('.display')

allBtn.forEach(btn =>{
    btn.addEventListener('click',(e)=>{
        allBtn.forEach(bt => bt.classList.remove('back'))
        e.target.classList.add('back')
    })
})
btn1.addEventListener('click',()=>{
    display.innerText =`1`
})
btn2.addEventListener('click',()=>{
    display.innerText =`2`
})
btn3.addEventListener('click',()=>{
    display.innerText =`3`
})
btn4.addEventListener('click',()=>{
    display.innerText =`4`
})
btn5.addEventListener('click',()=>{
    display.innerText =`5`
})
btn6.addEventListener('click',()=>{
    display.innerText =`6`
})
btn7.addEventListener('click',()=>{
    display.innerText =`7`
})
btn8.addEventListener('click',()=>{
    display.innerText =`8`
})