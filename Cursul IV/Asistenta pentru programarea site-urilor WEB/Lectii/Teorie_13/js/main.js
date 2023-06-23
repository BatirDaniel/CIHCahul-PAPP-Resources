const svg = document.getElementById('svg')
const circle = document.getElementById('circle')
let direction = 0
const changeDirection = () => {
    direction = Math.floor(Math.random() * 4) + 1
}
changeDirection()
// Functii
const moveToUp      = () =>  {
    circle.cy.baseVal.value -= circle.cy.baseVal.value-25? 25 : 0
    return circle.cy.baseVal.value-25
}
const moveToDown    = () =>  {
    if(circle.cy.baseVal.value<=550){
        circle.cy.baseVal.value += circle.cy.baseVal.value<=550? 25 : 0
        return circle.cy.baseVal.value
    }
    return 0
}
const moveToRight   = () =>  {
    if(circle.cx.baseVal.value<=550){
        circle.cx.baseVal.value += circle.cx.baseVal.value<=550? 25 : 0
        return circle.cx.baseVal.value
    }
    return 0
}
const moveToLeft    = () =>  {
    circle.cx.baseVal.value -= circle.cx.baseVal.value-25? 25 : 0
    return circle.cx.baseVal.value-25
}

setInterval(()=>{
    switch (direction) {
        case 1:
            moveToUp()?moveToUp():changeDirection()
            break;
        case 2:
            moveToDown()?moveToDown():changeDirection()
            break;
        case 3:
            moveToRight()?moveToRight():changeDirection()
            break;
        case 4:
            moveToLeft()?moveToLeft():changeDirection()
            break;
        default:
            break;
    }
}, 1000)