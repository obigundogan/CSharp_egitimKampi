using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_MainSubjects
{
    class Program
    {
        static void Main(string[] args)
        {
            #region yazdirmaKomutlari
            //Console.WriteLine("Say Hello");
            //Console.Write("Hello World");

            //Console.WriteLine("************* Yemek Kategorisi *************");
            //Console.WriteLine();
            //Console.WriteLine("1-Salatalar");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Soguk baslangic");
            //Console.WriteLine("4-Ana Yemek");
            //Console.WriteLine("5-Icecekler");
            //Console.WriteLine("6-Tatlilar");

            #endregion

            #region stringDegiskenler
            //string name;
            //name = "ibrahim";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, customerDistrict, customerCity;

            //customerName = "irem";
            //customerSurname = "Gundogan";
            //customerPhone = "+90 123 123 12 12";
            //customerEmail = "deneme@gmail.com";
            //customerDistrict = "Serik";
            //customerCity = "Antalya";

            //Console.WriteLine("***** Rezervasyon Karti *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Iletisim: " + customerPhone);
            //Console.WriteLine("Mail: " + customerEmail);
            //Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("-------------------------------------------------");



            #endregion


            #region intDegiskenler
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 60;
            int pizzaPrice = 275;
            int lemonadePrice = 30;

            Console.WriteLine("***** Retoran Menu Fiyati *****");
            Console.WriteLine();

            Console.WriteLine("-----Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("-----Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("-----:Kizartma:" + friesPrice + "TL");
            Console.WriteLine("-----Cola:" + cokePrice + "TL");
            Console.WriteLine("-----Limonata:" + lemonadePrice + "TL");
            Console.WriteLine("-----Su:" + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***************************************************");
            Console.WriteLine();


            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWatePrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totallemonadePrice = 0;

            hamburgerCount =3;
             cokeCount=3;
             waterCount=3;
             friesCount=1;
             pizzaCount=0;
             lemonadeCount=0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWatePrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totallemonadePrice = lemonadePrice * lemonadeCount;

            int total = totalHamburgerPrice + totalCokePrice + totalWatePrice + totalFriesPrice + totalPizzaPrice + totallemonadePrice;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Toplam Hesap Tutari: " +total+ "TL");



            #endregion
            Console.Read();

        }
    }
}
