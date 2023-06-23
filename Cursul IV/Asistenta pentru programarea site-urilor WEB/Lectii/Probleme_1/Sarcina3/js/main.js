const formular = document.getElementById('formular')

formular.addEventListener('submit',(e)=>{
    e.preventDefault()

    const numar = Number(document.getElementById('number').value)
    const result = document.getElementById('result')
    let date = new Date();
    console.log(date.getDate())
    if (numar % date.getDate() === 0) {
        result.innerText = 'Numarul este norocos !'
    }else{
        result.innerText = 'Numarul nu este norocos !'
    }
})