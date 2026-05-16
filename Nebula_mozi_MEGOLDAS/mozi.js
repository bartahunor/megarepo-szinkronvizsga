// 11. Feladat
var feliratkozas = function () {
    var xmlhttp = new XMLHttpRequest();
    var emailInput = document.getElementById("email");
    var adatkezelesiInput = document.getElementById("adatkezelesiInput");

    if (emailInput.value === "") {
        alert("Kérlek, add meg az email címed!");
        return;
    }

    if (adatkezelesiInput.checked === false) {
        alert("Kérlek, fogadd el az adatvédelmi szabályzatot!");
        return;
    }

    xmlhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            emailInput.value = "";
            alert("Köszönjük, hogy feliratkoztál!");
        }
    };
    xmlhttp.open('POST', '/api/hirlevel');
    xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xmlhttp.send(JSON.stringify({
        email: emailInput.value,
    }));
};

// 12. Feladat
mybutton = document.getElementById("back-to-top");

window.onscroll = function() {scrollFunction()};

function scrollFunction() {
    if ( document.documentElement.scrollTop >= 100) {
        mybutton.style.display = "block";
    } else {
        mybutton.style.display = "none";
    }
}
