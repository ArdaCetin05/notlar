//java script seçiciler

document.getElementById("id-adi") // id adına göre nesneyi seçer
document.getElementsByClassName("class-adi") // class adina göre nesneleri seçer birden fazla ise bir dizi döndürür
// sadece bir elemana erişmek için document.getElementsByClassName("class-adi")[0] şeklinde kullanılabilir
document.getElementsByTagName("p") // etiketlere göre seçim yapar birden fazla ise bir dizi döndürür
// document.getElementsByTagName("*") html belgesindeki tüm etiketleri seçer
document.querySelector("div.kutu>p") // eşleşen tek bir elemanı seçer
// query selector css seçicileri gibi davranır
document.querySelectorAll(".paragraf") // eşleşen tüm elemanları seçer

function yaz(){
    document.querySelector("div.kutu>p").innerHTML = "arda";
}