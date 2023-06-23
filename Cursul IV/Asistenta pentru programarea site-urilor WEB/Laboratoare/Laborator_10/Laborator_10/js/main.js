const imgs = document.getElementById('imgs')
const left = document.getElementById('left')
const right = document.getElementById('right')
const img = document.querySelectorAll('#imgs > img')
let id = 0

const interval = () => {
    clearInterval(inter)
    inter = setInterval(run, 2000)
}
const changeImage = () => {
    if( id >  img.length - 1){
        id = 0
    }else if( id < 0 ){
        id = img.length - 1
    }
    img.forEach(i=>{
        i.classList.remove('active')
    })
    img[id].classList.add('active')
}
const run = () =>{
    changeImage()
    id++    
}
let inter = setInterval(run, 2000)

left.addEventListener('click', ()=>{
    id--
    changeImage()
    interval()
})

right.addEventListener('click', ()=>{
    id++
    changeImage()
    interval()
})