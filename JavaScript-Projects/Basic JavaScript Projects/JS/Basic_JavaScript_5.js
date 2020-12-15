document.write(typeof"Hello")

function my_Function(){
    document.getElementById("NaN").innerHTML = 0/0;
}

function my_Function1(){
    document.getElementById("True").innerHTML = isNaN("Hello World!");
}

function my_Function2(){
    document.getElementById("False").innerHTML = isNaN("42");
}

function my_Function3(){
    document.getElementById("Infinity").innerHTML = (2E310);
}

function my_Function4(){
    document.getElementById("-Infinity").innerHTML = (-3E310);
}

function my_Function5(){
    document.getElementById("booTrue").innerHTML = (100 < 1000);
}

function my_Function6(){
    document.getElementById("booFalse").innerHTML = (1000 > 10000000);
}

function my_Function7(){
    document.getElementById("conLog").innerHTML = console.log (100 * 2)
}

function my_Function8(){
    document.getElementById("typeCoercion").innerHTML = ("3." + 14)
}

function my_Function9(){
    document.getElementById("Challenge").innerHTML = console.log (100 < 2);
}

function my_Function10(){
    document.getElementById("equalTrue").innerHTML = (11 == 11);
}

function my_Function11(){
    document.getElementById("equalFalse").innerHTML = (3 == 14);
}

function my_Function12(){
    var x = 4
    var y = 4
    document.getElementById("trueTrue").innerHTML = (x === y);
}

function my_Function13(){
    var x = 4
    var y = "six"
    document.getElementById("trueDoubleFalse").innerHTML = (x === y);
}

function my_Function14(){
    var x = 4
    var y = "four"
    document.getElementById("trueTypeFalse").innerHTML = (x === y);
}

function my_Function15(){
    var x = 4
    var y = "6"
    document.getElementById("trueValueFalse").innerHTML = (x === y);
}

function my_Function16(){
    var x = 4 > 2
    var y = 6 > 5
    document.getElementById("andTrue").innerHTML = (x && y);
}

function my_Function17(){
    var x = 4 > 2
    var y = 6 > 7
    document.getElementById("andFalse").innerHTML = (x && y);
}

function my_Function18(){
    var x = 4 > 2
    var y = 6 > 7
    document.getElementById("orTrue").innerHTML = (x || y);
}

function my_Function19(){
    var x = 4 > 5
    var y = 6 > 7
    document.getElementById("orFalse").innerHTML = (x || y);
}

function my_Function20(){
    document.getElementById("notTrue").innerHTML = !(100 > 1000000);
}

function my_Function21(){
   document.getElementById("notFalse").innerHTML = !(10 > 5);
}