"use strict"; // es5 standartında eklenen yeni yapı etkinleştirildi kodu daha katı hale getirir

var isim = "arda";
let soyisim = "çetin";
const dogum_tarih = 2005;

// js de değişken tanımlamak için 3 yol vardır bunlar var,let,const
// var ile tanımlanan değişkenler her yerden erişilebilirdir ve esnektirler
// let ile tanımlanan değişkenler bir scopun içinde tanımlandıklarında o scope dışına çıkamazlar
// const ile tanımlanan değişkenler let gibi davranır ama let'in aksine yeniden tanımlanamazlar

console.log(isim,soyisim,dogum_tarih);

{
    let i = 10 // görüldüğü gibi i değşkeni bir scopun içerisinde tanımlandığı için dışında çağırılamaz
    console.log(i)
}
console.log(i) // hata

//  ancak var için bu böyle değildir

{
    var j = 15;
}
console.log(j); // let ile hata verirken var ile hata vermedi

const s = 5;
console.log(s); // burada ise const ile tanımlanan değişken yeniden tanımlanmaya çalışılıyor
// ve hata veriyor
s = 8;
console.log(s);