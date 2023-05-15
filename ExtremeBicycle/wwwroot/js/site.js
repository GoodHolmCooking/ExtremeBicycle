// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/* When the user clicks on the button,
toggle between hiding and showing the dropdown content */

document.addEventListener('DOMContentLoaded', () => {
    let dropMenu = document.querySelector(".dropdown-items");
    let dropButton = document.querySelector(".drop-button");
    function dropDown() {
        dropMenu.classList.toggle("show");
    }


    // Close the dropdown menu if the user clicks outside of it

    dropButton.addEventListener('click', () => {
        dropDown();
    });
});