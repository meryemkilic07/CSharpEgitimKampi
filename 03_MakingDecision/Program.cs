using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre dogru");
            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış");
            //}

            //string capital,country;
            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler dogrulandı.");

            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}


            //int number;
            //Console.Write("Sayiyi giriniz:");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("sayi dogru");
            //}
            // //else
            // //{
            // //    Console.WriteLine("sayi hatali");
            // //}
            // int exam1, exam2, exam3,average;
            // string result="Hata!";
            // Console.Write("sınav1:");
            // exam1=int.Parse(Console.ReadLine());
            // Console.Write("sınav2:");
            // exam2 = int.Parse(Console.ReadLine());
            // Console.Write("sınav3:");
            // exam3 = int.Parse(Console.ReadLine());

            // average=(exam1+exam2+exam3)/3;
            // Console.WriteLine("Sınavların ortalamsi:"+average);

            // if (average > 0 & average <= 50)
            // {
            //     result = "sonuç vasat";
            // }
            // if(average>50 & average <= 70)
            // {
            //     result = "sonuç orta";
            // }
            //if(average>70 & average <= 84)
            // {
            //     result = "sonuç çok iyi";
            // }
            // if (average > 84)
            // {
            //     result = "sonuç çok iyi";
            // }
            // Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir giriniz:");
            //city = Console.ReadLine();


            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mecvut degil");
            //}

            //Console.Write("lütfen kullanıcı adı giriniz:");

            //string username=Console.ReadLine();

            //if(username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("hoş geldiniz");
            //}

            #endregion


            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Write("lütfen 1. sayiyi giriniz:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("lütfen 2. sayiyi giriniz:");
            //int number2 = int.Parse(Console.ReadLine()); Console.WriteLine("lütfen 1. sayiyi giriniz:");

            ////int result=number1%number2;
            ////Console.Write("birici sayının ikinci sayının bölümünden kalan deger:"+result);

            //Console.WriteLine("lütfen sayiyi giriniz:");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayi çiftiir.");
            //}
            //else
            //{
            //    Console.WriteLine("sayi tektir.");
            //}

            #endregion


            #region Char ile Karar Yapıları
            //   char team;
            //   Console.Write("lütfen takım sembolü giriniz:");
            //   team=char.Parse(Console.ReadLine());
            //if(team =='g' | team =='G')
            //   {
            //       Console.Write("Galatasaray");
            //   }

            //if (team=='f' | team=='F')
            //   {
            //       Console.Write("Fenerbakçe");
            //   }
            //   if (team == 'b' | team == 'B')
            //   {
            //       Console.Write("Beşiktaş");
            //   //}



            #endregion


            #region Örnek proje Uygulaması

            //Console.WriteLine("***C # Egitim Kampi Restoran***");
            //Console.WriteLine();
            //Console.WriteLine("------------------");

            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------");

            //string menuItem;

            //Console.Write("Detayını görmek istediginiz menü seçimi:");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //    {
            //    Console.WriteLine();
            //    Console.WriteLine("------Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlican musaka");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-mercimek çorba");
            //    Console.WriteLine("2-ezogelin çorba");
               
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz pizza");
            //    Console.WriteLine("2-Margerit pizza");
            //    Console.WriteLine("3-tavuklu pizza");
                
     
            //}



            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kola");
            //    Console.WriteLine("2-ayran ");
            //    Console.WriteLine("3-su");


            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");


            //}









            #endregion


            #region Switch Case


            //Console.Write("lütfen ay girişi yapınız:");
            //int monthNumber=int.Parse(Console.ReadLine())
            //    switch(monthNumber)
            //{
            //    case 1:Console.Write("Ocak");break;
            //    case 2:Console.Write("şubat");break;
            //    case 3:Console.Write("mart");break;
            //    case 4:Console.Write("nisan");break;
            //    case 5:Console.Write("mayıs");break;
            //    case 6:Console.Write("haziran");break;
            //    case 7:Console.Write("temmuz");break;
            //    case 8:Console.Write("ağustos");break;
            //    case 9:Console.Write("eylül");break;
            //    case 10:Console.Write("ekim");break;
            //    case 11: Console.Write("kasım");break;
            //    case 12:Console.Write("aralık");break;
            //    default: Console.Write("hatalı giriş");break;



            //}
            #endregion

            #region Switch Case hesap makinesi

            //int number1, number2,result;
            //char symbol;
            //Console.Write("1.sayiyi giriniz:");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayiyi giriniz:");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("yapmak istediginiz işlemi gitriniz:");
            //symbol=char.Parse(Console.ReadLine());


            //switch (symbol)
            // {
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam:" +result); 
                        
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark:" + result);

            //        break;


            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım:"  + result);

            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);

            //        break;


            //}




            #endregion




            Console.Read();
        }
    }
}
