function validateForm() {
    var x = document.forms["datafield"]["fname"].value;
    var y = document.forms["datafield"]["lname"].value;
    var z = document.forms["datafield"]["address"].value;
    var p = document.forms["datafield"]["email"].value;
    var d = document.forms["datafield"]["phone"].value;
    if (x == "" || y == "" || z == "" || p == "" || d == "")  {
      alert("All fields must be filled out");
      return false;
    }
  }