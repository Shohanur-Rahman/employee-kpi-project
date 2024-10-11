$(document).ready(function () {
    const body = document.querySelector("body");
    const HTML = document.querySelector("html");

    $(".loader-wrapper").fadeOut("slow");

    body.addEventListener("click", function (event) {
        const headerDropdownMenu = document.querySelectorAll(".custom-menu");
        const dropdownEl = event.target.closest(".custom-dropdown");
        const visible = dropdownEl
            ?.querySelector(".custom-menu")
            .classList.contains("show");
        const dropdownMenuElement = event.target.closest(".custom-menu");
        if (!dropdownMenuElement) {
            headerDropdownMenu.forEach((item) => {
                item.classList.remove("show");
            });
        }
        if (!dropdownEl) return;
        const dropdownMenu = dropdownEl.querySelector(".custom-menu");
        if (!visible) dropdownMenu.classList.add("show");
    });
})