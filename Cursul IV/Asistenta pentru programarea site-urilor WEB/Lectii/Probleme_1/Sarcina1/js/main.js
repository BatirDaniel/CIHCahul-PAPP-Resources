const formular = document.getElementById('formular')
const rezultat = document.getElementById('rezultat')

formular.addEventListener('submit',(e) =>{
    e.preventDefault()

    const lungime = document.getElementById('lungime').value
    const latime = document.getElementById('latime').value

    const Aria = lungime*latime
    const Perimetru = 2*(lungime+latime)

    rezultat.innerText = 'Aria = ' + Aria+ '\nPerimetru = ' + Perimetru
})