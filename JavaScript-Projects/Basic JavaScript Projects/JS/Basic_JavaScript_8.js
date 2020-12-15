var part_1 = "Today I learned how to "
var part_2 = "concatenate "
var part_3 = "various strings toghether!"
var whole_Sentance = part_1.concat(part_2, part_3)

function full_Sentence() {
        document.getElementById("concatenate").innerHTML = whole_Sentance;
}

function slice_Sentence() {
        var section = whole_Sentance.slice(0, 15); //specific lenght of string identified by postion
        document.getElementById("Slice").innerHTML = section;
}

function search_Word() {
    var str = "Hello! How are you today? By clicking 'Click Here!' You will enable a search for the postion of the word 'clicking'.";
    var searchResults = str.search("clicking"); //postion of word
    document.getElementById("results").innerHTML = "Postion " + searchResults;
}

function upper_Case() {
    var res = part_1.toUpperCase(); //change all string to uppercase
    document.getElementById("upper").innerHTML = res;
}

function to_String() {
    var number = 12432; //convert number to string
    document.getElementById("string").innerHTML = number.toString();
}

function precision_Method() {
    var num = 3184.654615478; //number to a percise place
    document.getElementById("precise").innerHTML = num.toPrecision (15);
}

function fixed_Method() {
    var num = 3184.654615478;
    var res = num.toFixed(6); //number to a fixed and rounded decimal point
    document.getElementById("fixed").innerHTML = res;
}

function value_Method() {
    var str = "Hello! This result is the vaue of the string!";
    var res = str.valueOf();
    document.getElementById("value").innerHTML = res;
}