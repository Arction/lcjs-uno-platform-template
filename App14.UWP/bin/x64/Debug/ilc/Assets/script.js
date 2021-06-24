function ClearAll() {
    document.getElementById("target").innerHTML = "";
}
function datapoint(chartcollection) {
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
        .add(data)
}

function show3Dchart(pointsCollection) {
    const {
        lightningChart,
        SolidFill,
        ColorRGBA,
        ColorHEX,
        UIElementBuilders,
        UILayoutBuilders,
        Themes
    } = lcjs
    // Extract required parts from xyData.
    const {
        createProgressiveRandomGenerator
    } = xydata

    // Initiate chart
    const chart3D = lightningChart().Chart3D({
        // theme: Themes.dark
        container: 'target'
    })
        .setTitle('3D Scatter Chart')
    // Create two new Point Series
    const blueSeries = chart3D.addPointSeries({ pointShape: 'sphere' })
        .setPointStyle((pointStyle) => pointStyle
            // Change the point fillStyle.
            // .setFillStyle(blue)
            // Change point size.
            .setSize(30))
    // Add layout UI Element for checkboxes.
    const layout = chart3D.addUIElement(UILayoutBuilders.Column)
        .setPosition({ x: 90, y: 90 })
        .setOrigin({ x: 1, y: 1 })
    // Flag for camera rotation
    let rotateCamera = false
    // Add button for toggling camera rotation into the layout UI Element
    const rotateCameraButton = layout.addElement(UIElementBuilders.CheckBox)
        .setText('Rotate camera')
    rotateCameraButton.onSwitch((_, state) => {
        rotateCamera = state
    })
    rotateCameraButton.setOn(rotateCamera)

    // Set Axis titles
    chart3D.getDefaultAxisX().setTitle('Axis X').setInterval(0, 100, false, false)
    chart3D.getDefaultAxisY().setTitle('Axis Y').setInterval(0, 100, false, false)
    chart3D.getDefaultAxisZ().setTitle('Axis Z').setInterval(0, 100, false, false)

    // Method to handle animating camera rotation.
    let cameraAngle = 0
    const dist = 1
    const animateCameraRotation = () => {
        if (rotateCamera) {
            chart3D.setCameraLocation(
                {
                    x: Math.cos(cameraAngle) * dist,
                    y: 0.50,
                    z: Math.sin(cameraAngle) * dist
                }
            )
            cameraAngle += 0.005
        }
        requestAnimationFrame(animateCameraRotation)
    }
    animateCameraRotation()
    for (i = 0; i < pointsCollection.length; i++) {
        // get rondom color and maping x,y z co-ordinates to each series in int format 
        // and paasing as json object
        // Define colors
        var colordata = getRandomColor();
        var scolor = new SolidFill({ color: ColorRGBA(colordata[0], colordata[1], colordata[2]) });
        chart3D.addPointSeries({ pointShape: 'sphere' })
            .setPointStyle((pointStyle) => pointStyle
                .setFillStyle(scolor)
                .setSize(30))
            .add(pointsCollection[i].map((element) =>
                (
                    {
                        x: Number(element.X),
                        y: Number(element.Y),
                        z: Number(element.Z)
                    }
                )))
    }
    return;
}
function getRandomColor() {
    var r = Math.floor(Math.random() * 255) + 1;
    var g = Math.floor(Math.random() * 255) + 1;
    var b = Math.floor(Math.random() * 255) + 1;
    return [Number(r), Number(g), Number(b)];
}


