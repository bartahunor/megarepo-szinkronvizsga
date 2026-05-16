var uzenetKuldes = function () {
    var xmlhttp = new XMLHttpRequest();
    var emailInput = document.getElementById("email");
    var nameInput = document.getElementById("name");
    var phoneInput = document.getElementById("phone");
    var messageInput = document.getElementById("message");

    if (emailInput.value === "" || nameInput.value === "" || phoneInput.value === "" || messageInput.value === "") {
        alert("Kérlek, add meg az összes mezőt!");
        return;
    }


    xmlhttp.onreadystatechange = function () {
        if (this.readyState === 4 && this.status === 200) {
            emailInput.value = "";
            nameInput.value = "";
            phoneInput.value = "";
            messageInput.value = "";
            alert("„Munkatársunk hamarosan keresni fogja Önt!");
        }
    };
    xmlhttp.open('POST', '/api/uzenet');
    xmlhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xmlhttp.send(JSON.stringify({
        name: nameInput.value,
        email: emailInput.value,
        phone: phoneInput.value,
        message: messageInput.value
    }));
};

var szerencseGeneralas = function () {
    var uzenetek = [
        "Hagyd, hogy a mosolyod megváltoztassa a világot, de ne hagyd, hogy a világ megváltoztassa a mosolyod. (Buddha)",
        "Mindennek megvan a maga ideje. Még a mosolygásnak is. (Salla Simukka)",
        "Mindig az az erősebb, aki nem tombol, hanem mosolyog. (japán közmondás)",
        "A mosoly, melyet küldesz, visszatér hozzád. (indiai mondás)",
        "A legtöbb mosolyt egy másik mosoly indította el. (Frank A. Clark)",
        "Minden könnyebben megy egy kis mosollyal. (Christina Dodd)",
        "Amikor a szeretet nem győz le mindent, akkor a sütik következnek. (ismeretlen)",
        "A nagy beszélgetésekhez elengedhetetlen a csokis keksz. (Tamara Ireland Stone)",
        "Egy igazán krémes csoki torta sokat ad sok embernek, nekem is! (Audrey Hepburn)",
        "Az élet bizonytalan. Kezdd a desszerttel! (Ernestine Ulmer)"
    ];

    var uzenet = document.getElementById("szerencseUzenet");
    var valasztott = uzenetek[Math.floor(Math.random() * uzenetek.length)];
    uzenet.innerText = valasztott;
}