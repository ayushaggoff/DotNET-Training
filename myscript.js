//Jquery Implementation
$(document).ready(function(){$("#name").keyup(function(){
	var name=$("#name").val();
	if(name.length==0)
	{
		$("#nvname").show();
		$("#nvname").text("Please Provide the input");
		$("#nvname").css("color","red");
	}
	 else if(name.length>100)
	{
		$("#nvname").show();
		$("#nvname").text("Please Provide the input");
		$("#nvname").css("color","red");
	}
	else
	{
		$("#nvname").hide();
	}
	}),
	$("#dob").keyup(function(){
	var date = $("#dob").val();
	if(date=="")
	{
		$("#nvdob").show();
		$("#nvdob").text("Please Provide the input");
		$("#nvdob").css("color","red");
	}
	else
	{
		$("#nvdob").hide();
	}
	}),
	$("#phone").keyup(function(){
		var telephone=$("#phone").val();
	if(telephone.length==0)
	{
		$("#nvphone").show();
		$("#nvphone").text("Please Provide the input");
		$("#nvphone").style.color="Red";
	}
	else if(isNaN(telephone))
	{
		$("#nvphone").show();
		$("#nvphone").text("Please Provide the numberic input");
		$("#nvphone").css("color","red");
	}
	else if(telephone.length!=10)
	{
		$("#nvphone").show();
		$("#nvphone").text("Phone number should be of size 10");
		$("#nvphone").css("color","red");
	}
	else
	{
		$("#nvphone").hide();
	}
	}),
	$("#email").keyup(function(){
	var email=$("#email").val();
	 var regex = /^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
	if(email.length==0)
	{
		$("#nvemail").show();
		$("#nvemail").text("Please Provide the input");
		$("#nvemail").css("color","red");	
	}
	else if(!regex.test(email))
	{
		$("#nvemail").show();
		$("#nvemail").text("Email must contain '@' and '.com'");
	}
	else
	{
		$("#nvemail").hide();
	}
	}),
	$("#seldepartname").change(function(){
	var department_name=$("#seldepartname").val();
	if (department_name == "Select the department")
	{
		$("#nvdepartname").show();
		$("#nvdepartname").txt("Please Select the department");
		$("#nvdepartname").css("color","red");
	}
	else
	{
		$("#nvdepartname").hide();
	}
	}),
	$("#address").keyup(function(){
	var address=$("#address").val();
	if(address.length==0)
	{
		$("#nvadress").show();
		$("#nvaddress").text("Please Provide the input");
		$("#nvaddress").css("color","red");
	}
	else
	{
		$("#nvadress").hide();
	}
	}),
	$("#selstate").change(function(){
	var state_var=$("#selstate").val();
	if (state_var == "Select the state")
	{
		$("#nvdepartname").show();
		$("#nvdepartname").txt("Please Select the state");
		$("#nvdepartname").css("color","red");
	}
	else
	{
		$("#nvdepartname").hide();
	}
	}),
	$("#zip").keyup(function(){
	var address=$("#address").val();
	if(address.length==0)
	{
		$("#nvphone").text("Please Provide the input");
		$("#nvphone").style.color="Red";
	}
	else
	{
		$("#nvphone").hide();
	}
	}),
	$("#zip").keyup(function(){
		var zip=$("#zip").val();
	if(zip.length==0)
	{
		$("#nvzip").show();
		$("#nvzip").text("Please Provide the input");
		$("#nvzip").style.color="Red";
	}
	else if(isNaN(zip))
	{
		$("#nvzip").show();
		$("#nvzip").text("Please Provide the numberic input");
		$("#nvzip").css("color","red");
	}
	else if(zip.length!=6)
	{
		$("#nvzip").show();
		$("#nvzip").text("zip should be of size 6");
		$("#nvzip").css("color","red");
	}
	else
	{
		$("#nvzip").hide();
	}
	});
});

//select State
var citiesByState = {
Odisha: ["Bhubaneswar","Puri","Cuttack"],
Maharashtra: ["Mumbai","Pune","Nagpur"],
Kerala: ["kochi","Kanpur"]
}
function makeSubmenu(value) 
{
	if(value.length==0) 
	{	
		document.getElementById("selcity").innerHTML = "<option></option>";
	}
	else 
	{
		var citiesOptions = "";
		for(cityId in citiesByState[value]) 
		{
			citiesOptions+="<option>"+citiesByState[value][cityId]+"</option>";
		}
		document.getElementById("selcity").innerHTML = citiesOptions;
	}
}

function resetSelection() {
document.getElementById("selstate").selectedIndex = 0;
document.getElementById("selcity").selectedIndex = 0;
}



//JavaScript implementation

/*function ValidateForm()
{
	var flag=0;
	//for name
	var name=document.getElementById('name').value;
	 if(name.length==0)
	 {
		document.getElementById('nvname').innerHTML="Please Provide the input";
		document.getElementById('nvname').style.color="Red";
		 flag=1;
	 }
	 else if(name.length>100)
	{
		document.getElementById('nvname').innerHTML="Number of characters allowed is 100";
		document.getElementById('nvname').style.color="Red";
		flag=1;
	}

	//for dob
	var date=document.getElementById('dob').value;
	if(date=="")
	 {
		document.getElementById('nvdob').innerHTML="Please Provide the input";
		document.getElementById('nvdob').style.color="Red";
		 flag=1;
	 }
	/*var day = date.slice(0,2);
	 if(parseInt(day)<1||parseInt(day)>31|| parseInt(date.slice(3,5))<1||parseInt(date.slice(3,5))>12||parseInt(date.slice(6,10))>2020)
	{
	document.getElementById('nvDob').innerHTML="Date should be in the format [DD/MM/YYYY]";
	flag=1;
	}
	else if(date.slice(2,3)!="/"||date.slice(5,6)!="/")
	{
			document.getElementById('nvDob').innerHTML="Date should be in the format [DD/MM/YYYY]";
			flag=1;
	}
	*/
	/*
	//telephone
	var telephone=document.getElementById('phone').value;
	if(telephone.length==0)
	{
		document.getElementById('nvphone').innerHTML="Please Provide the input";
		document.getElementById('nvphone').style.color="Red";
		flag=1;
	}
	else if(isNaN(telephone))
	{
		document.getElementById('nvphone').innerHTML="Please Provide the numberic input";
		document.getElementById('nvphone').style.color="Red";
		flag=1;
	}
	else if(telephone.length!=10)
	{
		document.getElementById('nvphone').innerHTML="Phone number should be of size 10";
		document.getElementById('nvphone').style.color="Red";
		flag=1;
	}

	//email
	var email=document.getElementById('email').value;
	var pos = email.search("@");
	
		var pos = email.search("@");
		var lenghtSlice=email.length-4;
		var temp = email.slice(lenghtSlice);

		
	if(email.length==0)
	{
		document.getElementById('nvemail').innerHTML="Please Provide the Input";
		document.getElementById('nvemail').style.color="Red";
		flag=1;
		
	}
	else if(pos==-1||temp!=".com")
		{
			document.getElementById('nvemail').innerHTML="Email must contain '@' and '.com'";
			document.getElementById('nvemail').style.color="Red";
			flag=1;
		}
	
	//address
	var address=document.getElementById('address').value;
	if(address.length==0)
	{
		document.getElementById('nvaddress').innerHTML="Please Provide the Input";
		document.getElementById('nvaddress').style.color="Red";
		flag=1;
	}
	
	//zip
	var zip=document.getElementById('zip').value;
	if(zip.length==0)
	{
		document.getElementById('nvzip').innerHTML="Please Provide the Input";
		document.getElementById('nvzip').style.color="Red";
		flag=1;
	}
	else if(isNaN(zip))
	{
		document.getElementById('nvzip').innerHTML="Please Provide the numberic input";
		document.getElementById('nvzip').style.color="Red";
		flag=1;
	}
	else if(zip.length!=6)
	{
		document.getElementById('nvzip').innerHTML="Phone zip should be of size 6";
		document.getElementById('nvzip').style.color="Red";
		flag=1;
	}
	*/
	/*
	// date of joining
	var date1=document.getElementById('txtdateofjoin').value;
	var day1 = date1.slice(0,2);

	if(parseInt(day1)<1||parseInt(day1)>31|| parseInt(date1.slice(3,5))<1||parseInt(date1.slice(3,5))>12||parseInt(date1.slice(6,10))>2020&&date1!="")
	{
		document.getElementById('nvdateofjoin').innerHTML="Date should be in the format [DD/MM/YYYY]";
		flag=1;
	}
	else if(date1.slice(2,3)!="/"||date1.slice(5,6)!="/")
	{
		document.getElementById('nvdateofjoin').innerHTML="Date should be in the format [DD/MM/YYYY]";
		flag=1;
	}
	*/
	/*
	//department name
	if(seldepartname.value=="none")
	{
		document.getElementById('nvdepartname').innerHTML="Please Provide the Input";
		document.getElementById('nvdepartname').style.color="Red";
		flag=1;
	}
	
	//state
	if(selstate.value=="none")
	{
		document.getElementById('nvstate').innerHTML="Please Provide the Input";
		document.getElementById('nvstate').style.color="Red";
		flag=1;
	}
	if(flag==0)
	{
		return true;
	}
	else
	{
		return false;
	}
}

//select State
var citiesByState = {
Odisha: ["Bhubaneswar","Puri","Cuttack"],
Maharashtra: ["Mumbai","Pune","Nagpur"],
Kerala: ["kochi","Kanpur"]
}
function makeSubmenu(value) 
{
	if(value.length==0) 
	{	
		document.getElementById("selcity").innerHTML = "<option></option>";
	}
	else 
	{
		var citiesOptions = "";
		for(cityId in citiesByState[value]) 
		{
			citiesOptions+="<option>"+citiesByState[value][cityId]+"</option>";
		}
		document.getElementById("selcity").innerHTML = citiesOptions;
	}
}
*/
/*
function resetSelection() {
document.getElementById("selstate").selectedIndex = 0;
document.getElementById("selcity").selectedIndex = 0;
}

function ValidateForm1(id)
{
	var userInput=document.getElementById(id).value;
		var errorLabel="nv"+id;
		var flag=0;
	if(userInput.length==0)
	{
		document.getElementById(errorLabel).innerHTML="Please Provide the Input";
		document.getElementById(errorLabel).style.color="Red";
	}else 
	{
		document.getElementById(errorLabel).innerHTML="";
		document.getElementById(errorLabel).style.color="Red";
		flag=1;
	}
	
	//name
	if(id=="name"&&flag==1)
	{
		if(userInput.length>100)
		{
			document.getElementById(errorLabel).innerHTML="Number of characters allowed is 100";
			document.getElementById(errorLabel).style.color="Red";

		}	
	}
	
	//telephone
	if(id=="phone"&&flag==1)
	{
		
		if(isNaN(userInput))
		{
			document.getElementById(errorLabel).innerHTML="Please Provide the numberic input";
			document.getElementById(errorLabel).style.color="Red";

		}
		else if(userInput.length!=10)
		{
			document.getElementById(errorLabel).innerHTML="Phone number should be of size 10";
			document.getElementById(errorLabel).style.color="Red";

		}
	}
	
	//email
	if(id=="email"&&flag==1)
	{
		var pos = userInput.search("@");
		var lenghtSlice=userInput.length-4;
		var temp = userInput.slice(lenghtSlice);

		if(pos==-1||temp!=".com")
		{
			document.getElementById(errorLabel).innerHTML="Email must contain '@' and '.com'";
			document.getElementById(errorLabel).style.color="Red";

		}
		else
		{
			document.getElementById(errorLabel).innerHTML="";
			document.getElementById(errorLabel).style.color="Red";

		}
	}
	
	//zip
	if(id=="zip"&&flag==1)
	{
		if(isNaN(userInput))
		{
			document.getElementById(errorLabel).innerHTML="Please Provide the numberic input";
			document.getElementById(errorLabel).style.color="Red";

		}
		else if(userInput.length!=6)
		{
			document.getElementById(errorLabel).innerHTML="Phone zip should be of size 6";
			document.getElementById(errorLabel).style.color="Red";

		}
	}
	
	//dob
	if(id=="dob")
	{
		if(userInput=="")
	 {
		document.getElementById(errorLabel).innerHTML="Please Provide the input";
		document.getElementById(errorLabel).style.color="Red";
		
	 }
	}

}
	//department name
function OnSelectDepartmentValidation()
{
		if(seldepartname.selectedIndex!=0)
	
	{
		document.getElementById('nvdepartname').innerHTML=" ";
	}
}
//department name
function OnSelectStateValidation()
{
		if(seldepartname.selectedIndex!=0)
	{
		document.getElementById('nvstate').innerHTML=" ";
	}
}
*/