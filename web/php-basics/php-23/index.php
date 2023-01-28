<?php

// php de oop

class living{ // sınıf tanımlama
    private $chromosome;
    protected $is_alive = true;
    public function __construct($chromosome){
        $this->chromosome = $chromosome;
    }
}

final class human extends living{ // miras alma ayrıca final olarak tanımlanan sınıflar ve metotlar kalıtım yolu ile çoğaltılamaz ve override edilemez
    private $name, $age;
    public static $info = 'this creature is a "human <br>"'; // static değişkenler ve metotlar nesne çağrılmadan erişilebilirdirler ve daha performanslıdır
    public function __construct($name,$age){ // ilk çalışan metot
        $this->name = $name;
        $this->age = $age;
        echo "first working method <br>";
    }
    public function about_me():string{
        return "my name is $this->name and i'm $this->age old <br>";
    }
    public function __destruct(){ // son çalışan method
        echo "last working method <br>";
    }
}

$human1 = new human("arda",17);
echo $human1->about_me();
echo human::$info;
  
/*
   Abstract(Soyutlama) Kullanımı
Soyutlanmış sınıflar içerisinde soyut methodlar barındırır.
Soyutlanmış sınıftan türetilen sınıflar soyut sınıf içerisinde ki soyut methodları bulundurmak zorundadır.


Özellikleri

Soyut methodlar ve sabitler içerebilir.
Normal methodlar, özellikler ve sabitler içerebilir.
public, protected ve private olarak tanım yapılabilir.
Aynı sınıf sadece bir abstract sınıftan türetilebilir.
*/
abstract class Urun // abstract sınıfların içerisinde bulunan abstract metotlar miras alınan sınıfların içerisinde yeniden tanımlanmak zorundadır
{
    public $fiyat;
    public $vergi;
    public $urunAdi;

    abstract public function urunAdi($urunAdi);

    abstract public function urunVergi($vergi);

    abstract public function urunFiyat($fiyat);

    public function urunEkle()
    {
        echo $this->urunAdi . ' isimlü ürün KDV(' . $this->vergi . '%) dahil ' . ($this->fiyat + (($this->fiyat / 100) * $this->vergi)) . ' eklendi.';
    }

}

class Icecek extends Urun
{

    public function urunAdi($urunAdi)
    {
        $this->urunAdi = $urunAdi;
    }

    public function urunVergi($vergi)
    {
        $this->vergi = $vergi;
    }

    public function urunFiyat($fiyat)
    {
        $this->fiyat = $fiyat;
    }

}

$Icecek = new Icecek();
$Icecek->urunAdi('Kola');
$Icecek->urunVergi(18);
$Icecek->urunFiyat(10);
$Icecek->urunEkle();




?>