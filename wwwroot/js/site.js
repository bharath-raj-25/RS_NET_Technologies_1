// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    let elements = document.querySelectorAll(".fade-in");
    elements.forEach(el => el.style.opacity = 1);
});
document.addEventListener("scroll", function () {
    let navbar = document.querySelector(".navbar");
    if (window.scrollY > 50) {
        navbar.style.background = "rgba(255, 255, 255, 0.5)";
        navbar.style.backdropFilter = "blur(15px)";
    } else {
        navbar.style.background = "rgba(255, 255, 255, 0.2)";
        navbar.style.backdropFilter = "blur(10px)";
    }
});
