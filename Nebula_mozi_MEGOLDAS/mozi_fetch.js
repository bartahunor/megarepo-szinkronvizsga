// 11. Feladat (fetch verzió)
var feliratkozas = async function () {
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

    try {
        var response = await fetch("/api/hirlevel", {
            method: "POST",
            headers: {
                "Content-Type": "application/json;charset=UTF-8",
            },
            body: JSON.stringify({
                email: emailInput.value,
            }),
        });

        if (response.ok) {
            emailInput.value = "";
            alert("Köszönjük, hogy feliratkoztál!");
            return;
        }

        alert("Hiba történt a feliratkozás során! (HTTP " + response.status + ")");
    } catch (e) {
        alert("Hálózati hiba történt, nem sikerült elküldeni.");
    }
};

// 12. Feladat
mybutton = document.getElementById("back-to-top");

window.onscroll = function () { scrollFunction(); };

function scrollFunction() {
    if (document.documentElement.scrollTop >= 100) {
        mybutton.style.display = "block";
    } else {
        mybutton.style.display = "none";
    }
}
