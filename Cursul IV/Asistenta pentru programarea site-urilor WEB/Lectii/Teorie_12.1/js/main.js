const myCanvas = document.getElementById('myCanvas')

window.addEventListener('load', ()=>{
    const chart = new CanvasJS.Chart('myCanvas',{
        animationEnabled: true,
        title: {
            text:"Lista cu cele mai populate orase"
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
                type: "pie",  
                showInLegend: true, 
                legendText: "{label}",
                dataPoints: [
                    { label: "Tokyo, Japonia",  y: 38140000 },
                    { label: "Delhi, India", y: 26454000 },
                    { label: "Shanghai, China", y: 24484000 },
                    { label: "Mumbai, India",  y: 21357000 },
                    { label: "Sao Paulo, Brazilia",  y: 21297000 },
                    { label: "Beijing, China",  y: 21240000  },
                    { label: "Mexico City, Mexic",  y: 21157000 },
                    { label: "Osaka, Japonia",  y: 20337000 },
                    { label: "Cairo, Egipt",  y: 19128000 },
                    { label: "New York, Statele Unite",  y: 18604000 }
                ]
            }
        ]
    })
    chart.render()
})