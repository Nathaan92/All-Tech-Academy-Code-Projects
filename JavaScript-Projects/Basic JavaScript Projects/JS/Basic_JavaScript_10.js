function Call_Loop() {
    var digit = "";
    var x = 1;
    while (x < 11) {
        digit += "<br>" + x;
        x++;
    }
    document.getElementById("Loop").innerHTML = digit;
}

function string_Length() {
    var str = "Hello, How are you today? I am doing well thank you!";
    var how = str.length;
    document.getElementById("length").innerHTML = how;
}
var Instruments = ["Guitar", "Drums", "Piano", "Bass", "Violin", "Trumpet", "Flute"];
var Content = "";
var Y;
function for_Loop() {
    for (Y = 0; Y < Instruments.length; Y++) {
        Content += Instruments[Y] + "<br>";
    }
    document.getElementById("List_of_Instruments").innerHTML = Content;
}

function array_Function() {
    var pos = [];
    pos[0] = "sleeping";
    pos[1] = "playing";
    pos[2] = "eating";
    pos[3] = "purring";
    document.getElementById("Array").innerHTML = "Look! The Cat is " + pos[1] + ".";
}

function constant_Function() {
    const Car = {manu:"GMC", model:"Sierra", year:"2010", color:"blue", size:"four door", engine:"5.3 liter V-8"};
    Car.color = "red";
    Car.price = "$20,000";
    document.getElementById("Constant").innerHTML = "Would you like to buy a " + Car.year + " " + Car.manu + " " + Car.model + " for " + Car.price + "?";
}

function let_Function() {
    var X = 454
    document.getElementById("Let0").innerHTML = (X);
    {
        let X = 545
        document.getElementById("Let1").innerHTML = (X);
    }
    document.getElementById("Let2").innerHTML = (X);
}

let car = {
    make: "GMC ",
    model: "Sierra ",
    year: "2010 ",
    color: "red ",
    description : function() {
    return "The car is a " + this.year + this.color + this.make + this.model; 
        }
};
document.getElementById("Car_Object").innerHTML = car.description();

var text1 = "";
var j;
for (j = 0; j < 10; j++) {
    if (j === 3) { break; }
    text1 += "The number is " + j + "<br>";
}
document.getElementById("Break").innerHTML = text1;

var text2 = "";
var i;
for (i = 0; i < 10; i++) {
    if (i === 3) { continue; }
    text2 += "The number is " + i + "<br>";
}
document.getElementById("Continue").innerHTML = text2;