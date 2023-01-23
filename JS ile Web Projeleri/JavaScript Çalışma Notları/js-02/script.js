var s1= Number(prompt("1. sayı giriniz : "));
var s2= Number(prompt("2. sayı giriniz : "));
var i= prompt("bir işlem giriniz : ");

if(i=="+"){
    alert(s1+s2);
}
else if(i=="-"){
    alert(s1-s2);
}
else if(i=="*"){
    alert(s1*s2);
}
else if(i=="/"){
    alert(s1/s2);
}
else{
    alert("bir işlem girmelisiniz");
}