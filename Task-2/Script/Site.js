document.getElementById("print_text").addEventListener("click", function () {
    document.getElementById("text").innerHTML = "Hello World!";
    document.getElementById("alertText").innerHTML = "";
});

document.getElementById("bold").addEventListener("click", function () {
    document.getElementById("text").style.fontWeight = "bold";
});

document.getElementById("italic").addEventListener("click", function () {
    document.getElementById("text").style.fontStyle = "italic";
});

document.getElementById("underLine").addEventListener("click", function () {
    document.getElementById("text").style.textDecoration = "underline";
});

document.getElementById("reset").addEventListener("click", function () {
    document.getElementById("text").style = "none";
});