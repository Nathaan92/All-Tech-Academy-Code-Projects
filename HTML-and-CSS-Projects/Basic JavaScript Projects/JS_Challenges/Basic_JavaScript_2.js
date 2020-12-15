function My_First_Function() {
    var str = "Its Monday!";
    var result = str.fontcolor("purple");
    document.getElementById("purple_text").innerHTML = result;
}

function My_Second_Function() {
    var sentance="Its gonna be";
    sentance +=" a long day!";
    document.getElementById("concatenate").innerHTML = sentance;
}