function Vote_Function() {
    var Age, Can_vote;
    Age = document.getElementById("Age").value;
    Can_vote = (Age < 18) ? "are not old enough to vote":"can vote!";
    document.getElementById("Vote").innerHTML = "You " + Can_vote;
}

function Dog(Breed, Size, Age, Color) {
    this.Dog_Breed= Breed;
    this.Dog_Size = Size;
    this.Dog_Age = Age;
    this.Dog_Color = Color;
}
var Koda = new Dog("mut", "medium", "1 year 5 months", "white, gray, and black");
var Earl = new Dog("lab", "medium - large", 12, "black");
var Chisum = new Dog("lab", "large", 6, "white and black");
function keywordFunction() {
    document.getElementById("New_and_This").innerHTML =
    "Koda is a " + Koda.Dog_Size + " sized " + Koda.Dog_Color + " dog who is a " + Koda.Dog_Breed +
    " that is " + Koda.Dog_Age + " old.";
}

// function reservedFunction(){
//    var true = the true true;
//     document.getElementById("reserved_Word").innerHTML = (true);
// }

function Person(first, last, age, eye) {
    this.firstName = first;
    this.lastName = last;
    this.gender = gender;
    this.eyeColor = eye;
    this.hairColor = hair;
    this.weight = pounds;
    this.height = height;
    this.birthday = b-date;
    this.ethnicity = ethnicity;
  }

  function count_Function() {
      document.getElementById("Nested_Functions").innerHTML = Count();
      function Count() {
          var Starting_point = 9;
          function Plus_one() {Starting_point += 1 ;}
          Plus_one();
          return Starting_point;
      }
  }