const addNewUser = document.getElementById('add-new-user')
const users = []
const tabel = document.getElementById("users")
//Informatii despre utilizator
const userInfo = () => {
    const userName = prompt('Indicati numele utilizatorului', "John Doe")
    const age = Number(prompt('Indicati varsta utilizatorului', 20))
    const country = prompt('Indicati tara utilizatorului', "RM")
    const tf = prompt('Indicati numarul de telefon')

    const user = {
        name: userName,
        age: age,
        country: country,
        tf: tf
    }
    users.push(user)
}
const addTbodyToTable = () => {
    const tbody = document.createElement('tbody')
    users.forEach(element => {
        tbody.innerHTML += `<tr>
        <td>${element.name}</td>
        <td>${element.age}</td>
        <td>${element.country}</td>
        <td>${element.tf}</td>
    </tr>`
    })
    tabel.appendChild(tbody)
}
const addTheadToTable = () =>{
    const thead = document.createElement('thead')
    thead.innerHTML = `<thead>
    <tr>
        <th>User Name</th>
        <th>User Country</th>
        <th>User Age</th>
        <th>User Tf</th>
    </tr>
</thead>`
tabel.appendChild(thead)
}

addNewUser.addEventListener('click', () => {
    userInfo()
    tabel.innerHTML =""
    addTheadToTable()
    addTbodyToTable()
})
