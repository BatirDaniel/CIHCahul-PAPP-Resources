const users = [
    {
        'fname' : "Ezra",
        'lname' : "Hudson",
        'email' : "Savannah.Mertz@gmail.com",
        'data'  : "Thu Feb 17 2022 04:29:33 GMT+0200 (Eastern European Standard Time)"
    },
    {
        'fname' : "Ted",
        'lname' : "Welch",
        'email' : "Jade_OConnell33@hotmail.com",
        'data'  : "Tue Sep 28 2021 05:16:49 GMT+0300 (Eastern European Summer Time)"
    },
    {
        'fname' : "Layla",
        'lname' : "Smith",
        'email' : "Kamron.Prosacco31@gmail.com",
        'data'  : "Thu Sep 01 2022 08:42:42 GMT+0300 (Eastern European Summer Time)"
    },
    {
        'fname' : "Emerald",
        'lname' : "Wilkinso",
        'email' : "Susanna.Stokes@gmail.com",
        'data'  : "Sat Jan 15 2022 18:03:30 GMT+0200 (Eastern European Standard Time)"
    },
    {
        'fname' : "Camryn",
        'lname' : "Cole",
        'email' : "Lucinda.Bode@gmail.com",
        'data'  : "Thu Nov 11 2021 14:02:06 GMT+0200 (Eastern European Standard Time)"
    },
    {
        'fname' : "Stephan",
        'lname' : "Wisozk",
        'email' : "Stephany.Dickens71@gmail.com",
        'data'  : "Sun May 22 2022 14:51:47 GMT+0300 (Eastern European Summer Time)"
    }
]
users.forEach(user => {
    console.log(user.fname +" " + user.lname)
})
const ol = document.getElementById('users')

users.forEach(user =>{
    ol.innerHTML +=`<li>${user.fname} ${user.fname}<li>`
})