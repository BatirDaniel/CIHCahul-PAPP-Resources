const display = document.getElementById('display-data')

const fetchData = async (url) =>{
    return await fetch(url).then(res => res.json())
}
const dataJSON = fetchData(`data/data.json`)
dataJSON.then(data =>{
    const dataJSONFinal = data
    dataJSONFinal.forEach(element => displayData(element))
})

const displayData = async (data)=>{
    console.log(data)
    display.innerHTML +=`
    <div class='data'>
        <div style='font-weight:bold'>${data.firstName} ${data.lastName}</div>
        <div>${data.age}</div>
        <div>${data.gender}</div>
        <div>${data.email}</div>
        <div>${data.phone}</div>
    </div>
    `
};