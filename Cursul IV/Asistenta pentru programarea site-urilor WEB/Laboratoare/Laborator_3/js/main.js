const n = Number(prompt('Dati numarul de elemente : '))
const numere  = []
for(let i =0;i<n;i++){
    numere.push(Math.floor(Math.random() * 100 + 1))
}
//Exercitiul 1
const numarulPatratPerfect = () =>{
    let contor = 0
    for(let i = 1;i <=100;i++){
        if (Math.sqrt(1) % 1 == 0) contor++
    }
    return contor
}


//Exercitiul 2
const numarulElementeDivizibile = (arr,numar) => {
    const rez = []
    arr.forEach(element => {
       if(element % numar == 0) rez.push(element)
    });
    return rez;
}

console.log(numere)
console.log(numarulPatratPerfect())
console.log(numarulElementeDivizibile(numere,6))