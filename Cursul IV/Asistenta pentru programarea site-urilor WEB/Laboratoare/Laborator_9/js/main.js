const users = document.getElementById('users')

const fetchUsers = async (url) =>{
    return await fetch(url).then(res => res.json())
}

const usersJSON = fetchUsers('data/users.json')
usersJSON.then(data =>{
    const userJSONFinal = data
    userJSONFinal.forEach(user => displayUser(user))
})

const displayUser = (user)=>{
    users.innerHTML+=
            `<div class='user'>
                  <ul>
                        <li><b>Id:</b>${user.id}</li>
                        <li><b>First Name:</b>${user.firstName}</li>
                        <li><b>Last Name:</b>${user.lastName}</li>
                        <li><b>Email:</b>${user.email}</li>
                        <li><b>Age:</b>${user.age}</li>
                  </ul>
            </div>`
}