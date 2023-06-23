const paragraf = document.querySelectorAll('p')

paragraf.forEach((e,i) =>{
    if((i) % 2 == 0) {
        e.style.fontWeight='bolder'
        e.style.color='white'
        e.style.backgroundColor='black'
    }
})

