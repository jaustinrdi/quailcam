$(document).ready(function () {
    var chartCanvas = $("#lightChart");
    var ctx = chartCanvas.get(0).getContext("2d");
    var chart = new Chart(ctx).Line(lightData);
    // TODO: add legend somewhere
});