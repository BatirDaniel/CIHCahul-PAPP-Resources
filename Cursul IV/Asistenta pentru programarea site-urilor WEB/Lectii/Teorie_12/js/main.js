const myCanvas = document.getElementById('myCanvas')

window.addEventListener('load', ()=>{
    const chart = new CanvasJS.Chart('myCanvas',{
        animationEnabled: true,
        title: {
            text:"Orarul grupei PAPP1941"
        },
        axisY: {
            title: "Axa Y"
        },
        axisX: {
            title: "Axa X"
        },
        legend: {
            verticalAlign: "bottom",
            horizontalAlign: "center"
        },
        data:[
            {
                type: "column",  
                showInLegend: true, 
                legendText: 'Textul legendei',
                dataPoints: [
                    { label: "Luni",  y: 4  },
                    { label: "Marti", y: 3  },
                    { label: "Miercuri", y: 3  },
                    { label: "Joi",  y: 5  },
                    { label: "Vineri",  y: 2  }
                ]
            }
        ]
    })
    chart.render()
})