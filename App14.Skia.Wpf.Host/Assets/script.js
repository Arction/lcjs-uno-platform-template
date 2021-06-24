gaga("red");
function gaga(hh) {
    document.body.style.backgroundColor = hh;
  
    var {
        lightningChart
    } = lcjs //Note: @arction/lcjs is not needed here, when using IIFE assembly



    // Create a XY Chart.
    var chart = lightningChart().ChartXY({
        // Set the chart into a div with id, 'target'.
        // Chart's size will automatically adjust to div's size.
        container: 'target'
    })
        .setTitle('My first chart') // Set chart title



    const data = [
        { x: 0, y: 1.52 },
        { x: 1, y: 1.56 },
        { x: 2, y: 1.42 },
        { x: 3, y: 1.85 },
        { x: 4, y: 1.62 }
    ]



    // Add a line series.
    const lineSeries = chart.addLineSeries()
        .setName('My data')
        .add(data)
    document.body.style.backgroundColor = 'green';

}