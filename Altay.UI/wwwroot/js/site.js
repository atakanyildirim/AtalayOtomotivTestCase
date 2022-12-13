// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#PrimeNumberButton").click(function () {
        var numbers = $("#numbers").val();
        var numbersArray = numbers.split(',');
        numbersArray = numbersArray.map(Number);
        var data = JSON.stringify(numbersArray);

        $.ajax({
            type: 'POST',
            url: 'https://localhost:7252/GetClosestPrimeNumber',
            data: data,
            success: function (data) {
                $("#message").empty();
                $("#message").removeClass("d-none");
                $("#message").append("<b>En yakın asal sayı: </b>" + data.data);
            },
            contentType: "application/json",
            dataType: 'json'
        });
    })
});