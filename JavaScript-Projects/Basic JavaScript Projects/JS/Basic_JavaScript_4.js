function my_dictonary() {
    var Animal = {
        Species:"Cat",
        Color:"White, Tan, Black",
        Breed:"Taby",
        Age:5,
        Sound:"(annoyed) Meow!"
    };
    document.getElementById("Dictionary").innerHTML = Animal.Color;
   
}

function my_dictonary1() {
    var Animal = {
        Species:"Cat",
        Color:"White, Tan, Black",
        Breed:"Taby",
        Age:5,
        Sound:"(annoyed) Meow!"
    };
    delete Animal.Sound;
    document.getElementById("Dictionary1").innerHTML = Animal.Sound;
}
