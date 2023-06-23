const city_names = ["Aberdeen", "Abilene", "Akron", "Albany", 
                    "Albuquerque", "Alexandria", "Allentown",
                    "Amarillo", "Anaheim", "Anchorage", 
                    "Ann Arbor", "Antioch", "Apple Valley", 
                    "Appleton", "Arlington", "Arvada", "Asheville", 
                    "Athens", "Atlanta", "Atlantic City", "Augusta",
                    "Aurora", "Austin", "Bakersfield", "Baltimore", 
                    "Barnstable", "Baton Rouge", "Beaumont", "Bel Air", 
                    "Bellevue", "Berkeley", "Bethlehem", "Billings", 
                    "Birmingham", "Bloomington", "Boise", "Boise City"];

const resultCity=[]

const arrayseparation = () =>{
    city_names.forEach(c => {
        if (c.length <= 6){
            resultCity.push(c);
        }
    });
    return resultCity;
}
const sortCities = (city) =>{    
    //sortare buble
    let cond
    do {
        cond = false;
        for (let i = 0; i < city.length - 1; i++) {
            if (city[i].length < city[i + 1].length) {
                let temp = city[i];
                city[i] = city[i + 1];
                city[i + 1] = temp;
                cond = true;
            }
        }
    } while (cond);
    return city;
}
console.log(sortCities(arrayseparation()))