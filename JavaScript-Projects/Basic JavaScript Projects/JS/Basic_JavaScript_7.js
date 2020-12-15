var x = 100
var y ="And the answer is! "
function global_Variables() {
    document.getElementById("globalVariables").innerHTML = (y + 100 * x + "<br>");
}


function local_Variables() {
    var a = 100;
    var b ="And the answer is! ";
    document.getElementById("localVariables").innerHTML = (b + 100 * a);
}

// function broken_Function() {
//     var n = 100;
//     console.log (b + 100 * n);
// }

function get_Date() {
    if (new Date().getHours() < 20) {
        document.getElementById("Greeting").innerHTML = "How are you today!";
    }
}

function guess_What() {
    var x = document.getElementById("random").value;
    if (x == 5){
        document.getElementById("guesswhat").innerHTML = "You Got It!";
    }
    else if (x < 5) {
        document.getElementById("guesswhat").innerHTML = "Wrong! Try a little higher";
    }
    else {
        document.getElementById("guesswhat").innerHTML = "Wrong! Try a little lower";
    }
}
    