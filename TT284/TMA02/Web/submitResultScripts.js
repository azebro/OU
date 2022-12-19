
function validateRunnerId() {
    var runnerId = document.getElementById("runnerId").value;
    var pattern = RegExp("^[0-9]+$");
    return validateNumberPattern(pattern, runnerId, "Runner Id");

}


function validateEventId() {
    var eventId = document.getElementById("eventId").value;
    var pattern = RegExp("^[0-9]+$");
    return validateNumberPattern(pattern, eventId, "Event Id");
}

function validateDate() {
    var date = document.getElementById("date").value;
    var pattern = RegExp("([0-9]{4}[-](0[1-9]|1[0-2])[-]([0-2]{1}[0-9]{1}|3[0-1]{1}))"); 
    return validateDateTime(pattern, date, "Date");

}

function validateTime() {
    var finishTime = document.getElementById("finishTime").value;
    var pattern = RegExp("(([0-1][0-9])|(2[0-3])):[0-5][0-9]:[0-5][0-9]");
    return validateDateTime(pattern, finishTime, "Finish Time");
}

function validateNonMandatoryFields() {
    var intPattern = RegExp("^[0-9]*$");
    var boolPattern = RegExp("^[0-1]*$");
    var position = document.getElementById("position");
    if (position.value.length === 0 || !intPattern.test(position.value)){
        position.value = -1;
    }
    var categoryId = document.getElementById("categoryId");
    if (categoryId.value.length === 0 || !intPattern.test(categoryId.value)) {
        categoryId.value = -1;
    }
    var ageGrade = document.getElementById("ageGrade");
    if (ageGrade.value.length === 0 || !intPattern.test(ageGrade.value)) {
        ageGrade.value = -1;
    }
    var personalBest = document.getElementById("personalBest");
    if (personalBest.value.length === 0 || !boolPattern.test(personalBest.value)) {
        personalBest.value = 0;
    }
    
}


function validateNumberPattern(pattern, string, name) {
    
    var test = pattern.test(string);
    if (test) {
        return "";
    } else {
        return name + " must me non empty number. \n";
    }

}

function validateDateTime(pattern, string, name) {
    var test = pattern.test(string);
    if (test) {
        return "";
    } else {
        return name + " is either empty or not in the correct format. \n";
    }
}




function validate() {
    var result = validateRunnerId() + validateEventId() +validateDate() + validateTime();
       // should be nothing if fields validate
    if (result === "") {
        validateNonMandatoryFields();
        return true;
    }
    else {
        alert("Errors: \n" + result);
        return false;
    }

}