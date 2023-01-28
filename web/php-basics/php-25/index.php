<?php
/*
Interface Kullanımı
Arayüzler, soyut sınıflara benzer.

Arayüzler sadece sınıfta zorunlu olarak tanımlanması gereken metotları belirtmek için kullanılır.

Özellikleri

Soyut methodlar ve sabitler içerebilir.
Sadece public method tanımı yapılabilir.
Aynı sınıf sadece birden fazla interface kullanabilir.


*/




interface A{
    public function a(); // interface abstract class lar gibi bir şablon oluşturur bu şablonun içinde tanımlanan metotlar 
    // şablonu kullanan classlar tarafından kullanılmak zorundadır 
    public function b();
}

interface B extends A{
    public function c(); // ayrıca interface ler kendi aralarında kalıtım alabilir
    public function d();
}

class i implements A,B{ // interface bu şekilde bağlanır
    public function a(){}
    public function b(){}
    public function d(){}
    public function c(){}
}



?>