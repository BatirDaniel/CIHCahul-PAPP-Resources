const orase =[
    {oras : 'Bucuresti'},
    {oras: 'Constanta'},
    {oras: 'Maramures'},
    {oras : 'Cluj'},
    {oras: 'Alba-Iulia'}
]
localStorage.clear()
localStorage.setItem('orase',JSON.stringify(orase))
const oraseSalvate = localStorage.getItem('orase')
const oraseSalvateObj = JSON.parse(oraseSalvate)

oraseSalvateObj.forEach(oras => {
    document.getElementById('orase').innerHTML +=`
    <li>${oras.oras}</li>`
});