using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.ve 2.ders kodları

            #region YazdırmaKomutları
//Console.WriteLine ("Merhaba Dünya");
//Console.Write("Selam");
//Console.WriteLine("** Yemek Kategorileri **");
//Console.WriteLine();
//Console.WriteLine("1-Çorbalar");
//Console.WriteLine("2-Ana Yemekler");
//Console.WriteLine("3-Soğuk Başlangıçlar");
//Console.WriteLine("4-Salatalar");
//Console.WriteLine("5-Tatlilar");
//Console.WriteLine("6-Içecekler");
//Console.WriteLine();
//Console.WriteLine("** Yemek Kategorileri **");

            #endregion

            #region Değişkenler
//string
//Degisken_türü degisken_adı;
//string name;
//name = "Murat";
//Console.Write (name);
//string customerName;
//string customerSurname;
//string customerPhone;
//string customerEmail, district, city;
//customerName = "Ali";
//customerSurname = "Çınar";
//customerPhone = "+90 500 400 30 20";
//customerEmail = "deneme@gmail.com";
//district = "Kadıköy";
//city = "Istanbul";

//Console.WriteLine("** Rezervasyon Kartı **");
//Console.WriteLine();
//Console.WriteLine("-------------");
//Console.WriteLine("Müşteri: " + customerName + "" + customerSurname);
//Console.WriteLine("iletişim: " + customerPhone);
//Console.WriteLine("Email Adresi: " + customerEmail);
//Console.WriteLine("Adres: " + district + "/" + city);
//Console.WriteLine("-------------");

//customerName = "Aysegül";
//customerSurname = "Kaya";
//customerPhone = "+90 400 300 80 70";
//customerEmail = "test@gmail.com";
//district = "Sapanca";
//city = "Sakarya";

//Console.WriteLine("**Rezervasyon Karti**");
//Console.WriteLine();
//Console.WriteLine("-----------");
//Console.WriteLine("Müşteri: " + customerName + "" + customerSurname);
//Console.WriteLine("iletisim:" + customerPhone);
//Console.WriteLine("Email Adresi: " + customerEmail);
//Console.WriteLine("Adres: " + district + "/" + city);
//Console.WriteLine("-------------");
            #endregion

            #region Int Degiskenler
            //int
            //int number = 24;
            //Console.WriteLine (number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;
            
            //Console.WriteLine("** Restoran Menü Fiyati **");
            //Console.WriteLine();
            //Console.WriteLine("----- Hamburger: " + hamburgerPrice + " TL");
            //Console.WriteLine("----- Pizza: " + pizzaPrice + " TL");
            //Console.WriteLine("----- Kola: " + cokePrice);
            //Console.WriteLine("----- Limonata:" + lemonadePrice + " TL");
            //Console.WriteLine("----- Kizartma: " + friesPrice + " TL");
            //Console.WriteLine("----- Su:" +waterPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("** Restoran Menu Fiyati **");

            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount; 
            //int waterCount; 
            //int friesCount; 
            //int pizzaCount; 
            //int lemonadeCount;

            //int totalhamburgerPrice;
            //int totalcokePrice;
            //int totalwaterPrice;
            //int totalfriesPrice;
            //int totalpizzaPrice;
            //int totallemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalhamburgerPrice = hamburgerCount*hamburgerPrice;
            //totalcokePrice = cokeCount*cokePrice;
            //totalwaterPrice = waterCount*waterPrice;    
            //totalfriesPrice = friesCount*friesPrice;
            //totalpizzaPrice = pizzaCount*pizzaPrice;
            //totallemonadePrice = lemonadeCount*lemonadePrice;

            //Console.WriteLine("------------------ ");
            //Console.WriteLine("Hamburger Tutari:" + totalhamburgerPrice + " TL");
            //Console.WriteLine("Pizza Tutarı: " + totalpizzaPrice + " TL");
            //Console.WriteLine("Kazartma Tutarı: " + totalfriesPrice + " TL");
            //Console.WriteLine("Kola Tutarı: " + totalcokePrice + " TL");
            //Console.WriteLine("Limonata Tutarı: " + totallemonadePrice + " TL");
            //Console.WriteLine("Su Tutarı: " + totalwaterPrice + " TL");
            //Console.WriteLine();
            //int totalPrice = totalcokePrice + totalwaterPrice + totallemonadePrice + totalhamburgerPrice +totalpizzaPrice + totalfriesPrice;
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine("***Fiyat Listesi***");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---Elma Fiyati:" + applePrice + "TL");
            //Console.WriteLine("---Portakal Fiyati:" + orangePrice + "TL");
            //Console.WriteLine("---Çilek fiyat:"+strawberryPrice+ "TL");
            //Console.WriteLine("---Patates fiyati:"+potatoPrice+"TL");
            //Console.WriteLine("---Domates fiyati:" + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan ürün : Elma -" + "Birim Fiyat:" + applePrice + "-Gramaj:" + appleGram + "Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan ürün : Portakal -" + "Birim Fiyat:" + orangePrice + "-Gramaj:" + orangeGram + "Toplam Tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün : Çilek -" + "Birim Fiyat:" + strawberryPrice + "-Gramaj:" + strawberryGram + "Toplam Tutar:" + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün :Patates -" + "Birim Fiyat:" +potatoPrice+ "-Gramaj:" + potatoGram+ "Toplam Tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alınan ürün : Domates -" + "Birim Fiyat:" + tomatoPrice + "-Gramaj:" + tomatoGram+ "Toplam Tutar:" +tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş toplam tutar:" + shoppingTotalPrice + "TL");


            #endregion


            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("***Dilek Hava Yolları Yolcu Bilgisi***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdenityNumber;
            //Console.WriteLine("Yolcu adı:");
            //passengerName =Console.ReadLine();

            //Console.WriteLine("Yolcu soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("İlçe:");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("Şehir:");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu yaş:");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu TC Kimlik No:");
            //passengerIdenityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No"+passengerIdenityNumber+"Yolcu ad-soyad:"+ passengerName+""+passengerSurname+"ilçe şehir:"+passengerDistrict+"/"+passengerCity+"Yaş:"+passengerAge);

            #endregion


            #region Klavyeden Tam Sayi Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;   
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen Aldığınız Ayakkabı Sayısını Giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Bilgisayar Sayısını Giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız Sandalye Sayısını Giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Aldığınız TV Sayısını Giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrice+computerPrice*computerCount+chairPrice*chairCount+tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz:" + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayi İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1.sınavı giriniz:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sınavı giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3.sınavı giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:"+result);

            #endregion

            #region  Klavyeden Karakter Girişleri      

            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet Seçiniz:");
            //gender =char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion


            Console.Read();
        }
    }
}
