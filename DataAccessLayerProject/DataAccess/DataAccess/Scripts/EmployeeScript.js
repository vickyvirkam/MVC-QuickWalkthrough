
function ValidateFirstName() {
    if (document.getElementById('fname').value == '') {
        return "FirstName should not be empty";
    }
    else
        return "";
}

//function InvalidFirstName() {

//    if (document.getElementById('fname').value.contains('@'))
//    {
//        return "FirstName should not conatin @";
//    }
//    else
//        return "";
//}

function ValidateLastName() {

    if (document.getElementById('lname').value.length >= 5) {
        return "LastName shouldnot be more than 5 characters";
    }
    else
        return "";
}

function ValidateSalary() {
    if (document.getElementById('sal').value == "")
        return "salary cannot be empty";
    else
        return "";
}

function InvalidSalary() {
    if (isNaN(document.getElementById('sal').value) == 1)
        return "salary should be numeric";
    else return "";

}


function IsValid() {
    debugger;
    var FirstName = ValidateFirstName();
    var LastName = ValidateLastName();
    var Salary = ValidateSalary();
    var insal = InvalidSalary();

    var ErrorMsg = "";
    ErrorMsg += "\n"+FirstName;
    ErrorMsg += "\n" + LastName;
    ErrorMsg += "\n" + Salary;
    ErrorMsg += "\n" + insal;

    if (ErrorMsg.length > 4)
        {
        alert(ErrorMsg);
        return false;
    }
else
    return true;


}