$(".sned-code__btn").click(function () {
    let numval = $("#n0").val();
    if (numval.length > 0 && numval.length == 11) {
        localStorage.setItem("frm", "Log-in");
        this.href = "./index-verify.html";
    } else {
        alert("num!");
    }
});

$(".input-number").on("keypress", function (e) {
    var numpattern = /^\d*$/;
    var char = String.fromCharCode(e.which);

    if (!numpattern.test(char)) {
        e.preventDefault();
    }
});
