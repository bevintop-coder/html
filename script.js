document.addEventListener("DOMContentLoaded", function () {

    const button = document.querySelector(".cta");

    button.addEventListener("click", function () {
        alert("Welcome to Career Accelerator! Start your skill journey today.");
    });

    const features = document.querySelectorAll(".feature-box");

    features.forEach(feature => {
        feature.addEventListener("mouseover", () => {
            feature.style.transform = "scale(1.05)";
            feature.style.transition = "0.3s";
        });

        feature.addEventListener("mouseout", () => {
            feature.style.transform = "scale(1)";
        });
    });

});