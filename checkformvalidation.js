function ValidateForm()
{
	var flag=0;
	//for name
var name=document.getElementById('txtname').value;
if(name=="")
{
	document.getElementById('nvName').innerHTML="! Please Provide the Input";
	flag=1;
}
else if(name.length>100)
{
	document.getElementById('nvName').innerHTML="! Number of characters allowed is 100";
	flag=1;
}

	//for dob
	var date=document.getElementById('txtdob').value;
	var day = date.slice(0,2);

if(date=="")
{
	document.getElementById('nvDob').innerHTML="! Please Provide the Input";
	flag=1;
}else if(parseInt(day)<1||parseInt(day)>31|| parseInt(date.slice(3,5))<1||parseInt(date.slice(3,5))>12||parseInt(date.slice(6,10))>2020||data.length>10)
	{
	document.getElementById('nvDob').innerHTML="! Date should be in the format [DD/MM/YYYY]";
	flag=1;
	}else if(date.slice(2,3)!="/"||date.slice(5,6)!="/")
	{
			document.getElementById('nvDob').innerHTML="! Date should be in the format [DD/MM/YYYY]";
			flag=1;
	}
	
	//telephone
	var telephone=document.getElementById('txttelphone').value;
	if(telephone=="")
	{
		document.getElementById('nvtelephone').innerHTML="! Please Provide the Input";
		flag=1;
		
	}else if(isNaN(telephone))
	{
		document.getElementById('nvtelephone').innerHTML="! Please Provide the numberic input";
		flag=1;
	}else if(telephone.length!=10)
	{
		document.getElementById('nvtelephone').innerHTML="! Phone number should be of size 10";
	}

	//email
	var email=document.getElementById('txtemail').value;
	var pos = email.search("@");
	if(email=="")
	{
		document.getElementById('nvemail').innerHTML="! Please Provide the Input";
		flag=1;
		
	}else if(pos==-1||email.slice(parseInt(email.Length-3),parseInt(email.Length+1))!=".com")
	{
		document.getElementById('nvemail').innerHTML="! Email must contain '@' and '.com'";
		flag=1;
	}
	
	//address
	var address=document.getElementById('txtaaddress').value;
	if(address=="")
	{
		document.getElementById('nvaddress').innerHTML="! Please Provide the Input";
		flag=1;
	}
	
	//zip
	var zip=document.getElementById('txtzip').value;
	if(telephone=="")
	{
		document.getElementById('nvzip').innerHTML="! Please Provide the Input";
		flag=1;
		
	}else if(isNaN(zip))
	{
		document.getElementById('nvzip').innerHTML="! Please Provide the numberic input";
		flag=1;
	}else if(zip.length!=6)
	{
		document.getElementById('nvtelephone').innerHTML="! Phone zip should be of size 6";
		flag=1;
	}
	
	

// date of joining
var date1=document.getElementById('txtdateofjoin').value;
	var day1 = date1.slice(0,2);

if(parseInt(day1)<1||parseInt(day1)>31|| parseInt(date1.slice(3,5))<1||parseInt(date1.slice(3,5))>12||parseInt(date1.slice(6,10))>2020)
	{
	document.getElementById('nvdateofjoin').innerHTML="! Date should be in the format [DD/MM/YYYY]";
	flag=1;
	}else if(date1.slice(2,3)!="/"||date1.slice(5,6)!="/")
	{
			document.getElementById('nvdateofjoin').innerHTML="! Date should be in the format [DD/MM/YYYY]";
			flag=1;
	}




	
if(flag==0)
return true;
else
return false;
}

//select State
var citiesByState = {
Odisha: ["Bhubaneswar","Puri","Cuttack"],
Maharashtra: ["Mumbai","Pune","Nagpur"],
Kerala: ["kochi","Kanpur"]
}
function makeSubmenu(value) {
if(value.length==0) document.getElementById("citySelect").innerHTML = "<option></option>";
else {
var citiesOptions = "";
for(cityId in citiesByState[value]) {
citiesOptions+="<option>"+citiesByState[value][cityId]+"</option>";
}
document.getElementById("citySelect").innerHTML = citiesOptions;
}
}
function displaySelected() { var country = document.getElementById("countrySelect").value;
var city = document.getElementById("citySelect").value;
alert(country+"\n"+city);
}
function resetSelection() {
document.getElementById("countrySelect").selectedIndex = 0;
document.getElementById("citySelect").selectedIndex = 0;
}