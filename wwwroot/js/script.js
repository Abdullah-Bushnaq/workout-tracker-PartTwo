function validateSignUp() {
    var name = document.getElementById("fullname").value;
    var email = document.getElementById("email").value;
    var phone = document.getElementById("phone").value;
    var pass = document.getElementById("password").value;
    var confirm = document.getElementById("confirmPassword").value;

    if (name == "") {
        alert("Full name cannot be empty.");
        return false;
    }

    if (email == "") {
        alert("Email cannot be empty.");
        return false;
    }

    if (phone == "") {
        alert("Phone cannot be empty.");
        return false;
    }

    if (pass == "") {
        alert("Password cannot be empty.");
        return false;
    }

    if (confirm == "") {
        alert("Please confirm your password.");
        return false;
    }

    if (pass != confirm) {
        alert("Passwords do not match.");
        return false;
    }

    if (pass.length < 6) {
        alert("Password must be at least 6 characters.");
        return false;
    }

    alert("Signup successful!");
    return true;
}

function addExercise() {

    var name = document.getElementById("exName").value;
    var reps = document.getElementById("exReps").value;
    var rest = document.getElementById("exRest").value;

    if (name == "") {
        alert("Please enter an exercise name.");
        return false;
    }

    if (reps == "") {
        alert("Please enter the reps/sets.");
        return false;
    }

    if (rest == "") {
        alert("Please enter rest time.");
        return false;
    }

    var table = document.querySelector("#WorkoutT table");

    table.innerHTML +=
        "<tr>" +
        "<td>" + name + "</td>" +
        "<td>" + reps + "</td>" +
        "<td>" + rest + "</td>" +
        "</tr>";

    alert("Exercise added!");

    document.getElementById("exName").value = "";
    document.getElementById("exReps").value = "";
    document.getElementById("exRest").value = "";

    return false;
}

function clearTable() {
    var table = document.getElementById("workoutTable");

    table.innerHTML = "";

    table.innerHTML += 
        "<tr>" +
        "<th>"+ "Exercise" + "</th>" +
        "<th>"+ "Reps/Sets" + "</th>" +
        "<th>"+ "Rest Time" + "</th>" +
        "</tr>"
        "<tr>" +
        "<td>"+ "</td>" +
        "<td>"+ "</td>" +
        "<td>"+ "</td>" +
        "</tr>";
    alert("Table cleared!");

}

function checkSurvey() {
    alert("Please answer the questions before submitting.");
    return false;
}