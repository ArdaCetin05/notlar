function hesapla(){
    var s1 = Number(document.getElementById("s1").value);
    var s2 = Number(document.getElementById("s2").value);
    var snc = s1+s2
    document.getElementById("yazi").innerHTML = snc
    alert(snc)
}