using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region doubleDegiskeni

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("Elma Birim Fiyati: " + applePrice);
            //Console.WriteLine("Portakal Birim Fiyati: " + orangePrice);
            //Console.WriteLine("Cilek Birim Fiyati: " + strawberryPrice);
            //Console.WriteLine("Patates Birim Fiyati: " + potatoPrice);
            //Console.WriteLine("Domate Birim Fiyati: " + tomatoPrice);
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotal,orangeTotal,strawberryTotal,potatoTotal,tomatoTotal;
            //appleTotal = applePrice * appleGram;
            //orangeTotal = orangePrice * orangeGram;
            //strawberryTotal = strawberryPrice * strawberryGram;
            //potatoTotal = potatoPrice * potatoGram;
            //tomatoTotal = tomatoPrice * tomatoGram;

            //double total;
            //total = appleTotal + orangeTotal + strawberryTotal + potatoTotal + tomatoTotal;
            //Console.WriteLine("Odenecek tutar:" + total + "TL");


            #endregion

            #region charDegiskeni
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);




            #endregion

            #region klavyedenVeriGirisi_String
            //Console.WriteLine("**** Hava Yollari ****");
            //Console.WriteLine();


            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Tc No: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.Write("Yolcu Adi: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadi: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Ilce Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Sehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yas Bilgisi: ");
            //passengerAge = Console.ReadLine();



            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu Tc: "+passengerIdentityNumber+" "+"- Yolcu: " + passengerName + " " + passengerSurname+"/ "+passengerDistrict+" "+passengerCity+" "+passengerAge);


            #endregion

            #region klavyedenVeriGirisi_Int

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldiginiz Ayakkabi adetini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldiginiz Bilgisayar adetini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldiginiz Sandalye adetini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldiginiz Televizyon adetini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice;
            //totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Odemeniz Gereken Toplam Tutar: " + totalPrice);




            #endregion

            #region klavyedenGirisi_Double

            //double exam1, exam2, exam3, result;
            //Console.Write("Sinav-1 Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Sinav-2 Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Sinav-3 Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Not Ortalamaniz: "+result);
            //Console.WriteLine();



            #endregion


            #region klavyedenGirisi_Char
            char gender;
            Console.Write("Lütfen Cinsiyet Seciniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Sectiginiz Cinsiyet: " + gender);




            #endregion
            Console.Read();
        }
    }
}
