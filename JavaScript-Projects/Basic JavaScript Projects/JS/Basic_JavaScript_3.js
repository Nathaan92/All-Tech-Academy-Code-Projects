window.alert(math.random());

function addition_Function() {
    var addition = 2 + 2;
    document.getElementById("Math1").innerHTML = "2 + 2 = " + addition;
}

function subtraction_Function() {
    var subraction = 2 - 2;
    document.getElementById("Math2").innerHTML = "2 - 2 = " + subraction;
}

function multiplication_Function() {
    var multiplication = 2 * 2;
    document.getElementById("Math3").innerHTML = "2 * 2 = " + multiplication;
}

function division_Function() {
    var division = 2 / 2;
    document.getElementById("Math4").innerHTML = "2 / 2 = " + division;
}   

function more_Math() {
    var simple_Math = (5 * 5) + 6 / 2;
    document.getElementById ("Math5").innerHTML = "five multipled by five, six divided by two and the sum added toghether = " + simple_Math;
}

function modulus_Operator() {
    var mod = 30 % 4;
    document.getElementById ("Math6").innerHTML = "30 divided by 4 you get a remainder of: " + mod;
}

function negation_Operator() {
    var x = 10;
    document.getElementById("Math7").innerHTML = -x;
}

function increment() {
    var y = 5;
    document.getElementById("Math8").innerHTML = ++y;
}

function decrement() {
    var z = 5;
    document.getElementById("Math9").innerHTML = --z;
}

function random() {
    var random = (Math.random() * 10);
    document.getElementById("Math10").innerHTML =  random;
}
function square_root() {
    var square = Math.sqrt(64);
    document.getElementById("Math11").innerHTML = square;
}