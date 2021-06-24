function ClearAll() {
    document.getElementById("target").innerHTML = "";
}
function datapoint(chartcollection) {
    alert("line");
    //document.body.style.backgroundColor = hh;
    const {
        lightningChart
    } = lcjs  //Note: arction/lcjs is not needed here, when using IIFE assembly

    // Create a XY Chart.
    const chart = lightningChart().ChartXY({
        // Set the chart into a div with id, 'target'.
        // Chart's size will automatically adjust to div's size.
        container: 'target'
    })
        .setTitle('My first chart') // Set chart title
    const data = [];
    // iterate over array and check array values.
    for (i = 0; i < chartcollection.length; i++) {

        x_point = chartcollection[i].X;
        y_point = chartcollection[i].Y;
        data.push({
            "x": Number(x_point),
            "y": Number(y_point),
        });
    }

    // Add a line series.
    const lineSeries = chart.addLineSeries()
        .setName('My data')
        .add(data);
}

function show3Dchart(pointsCollection) {

    alert("line");
}
function getRandomColor() {
    var r = Math.floor(Math.random() * 255) + 1;
    var g = Math.floor(Math.random() * 255) + 1;
    var b = Math.floor(Math.random() * 255) + 1;
    return [Number(r), Number(g), Number(b)];
}