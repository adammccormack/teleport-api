// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

    $.ajax({
        type: "GET",
        url: "https://api.teleport.org/api/continents/",
        success: function (data) {
            console.log("success", data);
        }
    });
});
