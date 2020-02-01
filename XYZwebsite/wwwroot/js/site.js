// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



// LOGIN:  CHECKS IF LOGIN email AND password are correct (user@gmail.com, pass) and opens a new page. If not, alerts.
function check(form) {
    if (form.email.value == "user@gmail.com" && form.pswrd.value == "pass") {
        window.open("./work.html")
    }
    else {
        alert("The username and password you entered don't match.")
    }
}
