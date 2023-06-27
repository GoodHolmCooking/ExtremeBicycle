// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/* When the user clicks on the button,
toggle between hiding and showing the dropdown content */


document.addEventListener('DOMContentLoaded', () => {
    //Dropdown menu css

    //let dropMenu = document.querySelectorAll(".dropdown-items");
    //let dropButton = document.querySelectorAll(".drop-button");
    let dropMenu = document.querySelector(".dropdown-items");
    let dropButton = document.querySelector(".drop-button");
    
    let contactdropMenu = document.querySelector(".contact-dropdown-items");
    let contactdropButton = document.querySelector(".contact-drop-button");

    let shippingdropMenu = document.querySelector(".shipping-dropdown-items");
    let shippingdropButton = document.querySelector(".shipping-drop-button"); 

    let deliverydropMenu = document.querySelector(".delivery-dropdown-items");
    let deliverydropButton = document.querySelector(".delivery-drop-button");

    let paymentdropMenu = document.querySelector(".payment-dropdown-items");
    let paymentdropButton = document.querySelector(".payment-drop-button");   

    function dropDown() {
        dropMenu.classList.toggle("show");
    }

    function contactdropDown() {
        contactdropMenu.classList.toggle("show");
    }

    function shippingdropDown() {
        shippingdropMenu.classList.toggle("show");
    }

    function deliverydropDown() {
        deliverydropMenu.classList.toggle("show");
    }

    function paymentdropDown() {
        paymentdropMenu.classList.toggle("show");
    }
    
    // Close the dropdown menu

    //dropButton.forEach(e => {
    //    e.addEventListener('click', () => {
    //        dropDown();
    //    })
    //})
    
    dropButton.addEventListener('click', () => {
        dropDown();
    });

    contactdropButton.addEventListener('click', () => {
        contactdropDown();
    });

    shippingdropButton.addEventListener('click', () => {
        shippingdropDown();
    });

    deliverydropButton.addEventListener('click', () => {
        deliverydropDown();
    });

    paymentdropButton.addEventListener('click', () => {
        paymentdropDown();
    });
});