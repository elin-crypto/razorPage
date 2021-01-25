// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//open mobile menu
let open = document.getElementById("menuIcon");
let menu = document.getElementById("sidebar");
let close = document.getElementById("closeIcon");

function openNav() {
    if (open.style.display === "block") {
        open.style.display = "none";
        menu.style.display = "block";
        close.style.display = "block";

    } else {
        open.style.display = "block";
    }
}

function closeNav() {
    if (open.style.display === "none") {
        open.style.display = "block";
        menu.style.display = "none";
        close.style.display = "none";

    } else {
        open.style.display = "none";
    }
}
// make active navItem change color
// for some reason it changes back when page is loaded. I can add event.preventDefault() but the page isn't loaded at all.
$(".ulList").on("click", "li", function () {
    
    $(".ulList .active-nav").removeClass("active-nav");
    $(this).addClass("active-nav");
})