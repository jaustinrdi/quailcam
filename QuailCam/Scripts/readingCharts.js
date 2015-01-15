$(document).ready(function () {
    $("#lightChart").highcharts({
        chart: {
            zoomType: 'x',
            height: 150
        },
        title: "",
        xAxis: {
            type: 'datetime',
            minRange: 24 * 3600 * 1000
        },
        yAxis: {
            title: {
                text: 'Brightness (lux)'
            }
        },
        tooltip: {
            enabled: false,
            valueSuffix: ' lx'
        },
        legend: {
            enabled: false
//            layout: 'vertical',
//            align: 'right',
//            floating: true,
//            verticalAlign: 'top',
//            borderWidth: 0
        },
        series: lightChartData

    });
});