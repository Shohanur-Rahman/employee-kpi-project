$(function () {

    window.HideLoader = function (selector) {
        $(selector).fadeOut("slow");
    };

    window.OpenModal = function (selector) {
        $(selector).modal('show')
    };

    window.LoadDataTable = function (selector) {
        $(selector).DataTable();
    }

    window.HideModal = function (selector) {
        $(selector).modal('hide');
    }

    window.ShowSuccessToast = function (message) {
        Toastify({
            text: message,
            className: "success",
            style: {
                background: "linear-gradient(to right, #00b09b, #96c93d)",
            }
        }).showToast();
    }

    window.ShowErrorToast = function (message) {
        Toastify({
            text: message,
            className: "danger",
            style: {
                background: "linear-gradient(to right, #b00000, #c93d3d)",
            }
        }).showToast();
    }

    window.InitFormValidator = function (selector) {
        // Fetch all the forms we want to apply custom Bootstrap validation styles to
        const forms = document.querySelectorAll(selector);

        // Loop over them and prevent submission
        Array.from(forms).forEach((form) => {
            form.addEventListener(
                "submit",
                (event) => {
                    if (!form.checkValidity()) {
                        event.preventDefault();
                        event.stopPropagation();
                    }

                    form.classList.add("was-validated");
                },
                false
            );
        });
    }

    window.removeFileInputValue = (inputElement) => {
        inputElement.value = ''; 
    };
});

