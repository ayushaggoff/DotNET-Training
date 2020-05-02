//Jquery Implementation
$(document).ready(function () {
    $("#name").keyup(function () {
        var name = $("#name").val();
        if (name.length == 0) {
            $("#nvname").show();
            $("#nvname").text("Please Provide the input");
            $("#nvname").css("color", "red");
        }
        else if (name.length > 100) {
            $("#nvname").show();
            $("#nvname").text("Please Provide the input");
            $("#nvname").css("color", "red");
        }
        else {
            $("#nvname").hide();
        }
    }),
        $("#dob").keyup(function () {
            var date = $("#dob").val();
            if (date == "") {
                $("#nvdob").show();
                $("#nvdob").text("Please Provide the input");
                $("#nvdob").css("color", "red");
            }
            else {
                $("#nvdob").hide();
            }
        }),
        $("#phone").keyup(function () {
            var telephone = $("#phone").val();
            if (telephone.length == 0) {
                $("#nvphone").show();
                $("#nvphone").text("Please Provide the input");
                $("#nvphone").style.color = "Red";
            }
            else if (isNaN(telephone)) {
                $("#nvphone").show();
                $("#nvphone").text("Please Provide the numberic input");
                $("#nvphone").css("color", "red");
            }
            else if (telephone.length != 10) {
                $("#nvphone").show();
                $("#nvphone").text("Phone number should be of size 10");
                $("#nvphone").css("color", "red");
            }
            else {
                $("#nvphone").hide();
            }
        }),
        $("#email").keyup(function () {
            var email = $("#email").val();
            var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
            if (email.length == 0) {
                $("#nvemail").show();
                $("#nvemail").text("Please Provide the input");
                $("#nvemail").css("color", "red");
            }
            else if (!regex.test(email)) {
                $("#nvemail").show();
                $("#nvemail").text("Email must contain '@' and '.com'");
            }
            else {
                $("#nvemail").hide();
            }
        }),
        $("#seldepartname").change(function () {
            var department_name = $("#seldepartname").val();
            if (department_name == "Select the department") {
                $("#nvdepartname").show();
                $("#nvdepartname").txt("Please Select the department");
                $("#nvdepartname").css("color", "red");
            }
            else {
                $("#nvdepartname").hide();
            }
        }),
        $("#address").keyup(function () {
            var address = $("#address").val();
            if (address.length == 0) {
                $("#nvadress").show();
                $("#nvaddress").text("Please Provide the input");
                $("#nvaddress").css("color", "red");
            }
            else {
                $("#nvadress").hide();
            }
        }),
        $("#selstate").change(function () {
            var state_var = $("#selstate").val();
            if (state_var == "Select the state") {
                $("#nvdepartname").show();
                $("#nvdepartname").txt("Please Select the state");
                $("#nvdepartname").css("color", "red");
            }
            else {
                $("#nvdepartname").hide();
            }
        }),
        $("#zip").keyup(function () {
            var address = $("#address").val();
            if (address.length == 0) {
                $("#nvphone").text("Please Provide the input");
                $("#nvphone").style.color = "Red";
            }
            else {
                $("#nvphone").hide();
            }
        }),
        $("#zip").keyup(function () {
            var zip = $("#zip").val();
            if (zip.length == 0) {
                $("#nvzip").show();
                $("#nvzip").text("Please Provide the input");
                $("#nvzip").style.color = "Red";
            }
            else if (isNaN(zip)) {
                $("#nvzip").show();
                $("#nvzip").text("Please Provide the numberic input");
                $("#nvzip").css("color", "red");
            }
            else if (zip.length != 6) {
                $("#nvzip").show();
                $("#nvzip").text("zip should be of size 6");
                $("#nvzip").css("color", "red");
            }
            else {
                $("#nvzip").hide();
            }
        }),
        $("#click").click(function () {
            $.ajax({
                type: "POST",
                url: "api/Employee/InsertRecord",
                contentType: "application/json;charset=utf-8",
                data: JSON.stringify({
                    Name: $("#name").val(),
                    Dob: $("#dob").val(),
                    Phone: $("#mob").val(),
                    Email: $("#email").val(),
                    Department: $("#seldepartname").val(),
                    Address: $("#address").val(),
                    State: $("#selstate").val(),
                    City: $("#selcity").val(),
                    Zip: $("#zip").val(),
                    JoiningDate: $("#dateofjoin").val()
                }),
                success: function () {
                
                   alert("Employee Data Inserted Successfully");
                }

            })
        });
});

//select State
var citiesByState = {
    Odisha: ["Bhubaneswar", "Puri", "Cuttack"],
    Maharashtra: ["Mumbai", "Pune", "Nagpur"],
    Kerala: ["kochi", "Kanpur"]
}
function makeSubmenu(value) {
    if (value.length == 0) {
        document.getElementById("selcity").innerHTML = "<option></option>";
    }
    else {
        var citiesOptions = "";
        for (cityId in citiesByState[value]) {
            citiesOptions += "<option>" + citiesByState[value][cityId] + "</option>";
        }
        document.getElementById("selcity").innerHTML = citiesOptions;
    }
}

function resetSelection() {
    document.getElementById("selstate").selectedIndex = 0;
    document.getElementById("selcity").selectedIndex = 0;
}