using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methots
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();

            //void sum()
            //{
            //    int x = 1; int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region Geriye deger döndürmeyen string parametreli metotlar


            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri:"+name+" "+surname);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye deger döndürmeyen int parametreli metotlar


            //void Sum(int number1,int number2,int number3) 
            //{
            //int result=number1 + number2+number3;
            //    Console.WriteLine(result);

            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye deger döndürüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //        string StudentCard()
            //        {
            //            string name = "Ali";
            //            string surname = "Kaya";
            //            return name+" "+surname;
            //        }

            //        Console.WriteLine(StudentCard());
            #endregion



            #region Geriye Deger String Döndüren Parametreli Metotlar

            //string Country (string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke:" + countryName + "- Başkent:" + capital + " -Bayrak rengi:" + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("ülke adını giriniz:");
            //x= Console.ReadLine();

            //Console.Write("Başkent adını giriniz:");
            //y= Console.ReadLine();

            //Console.Write("Bayrak rengi giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(Country(x,y,z));

            #endregion

            #region Geriye Deger Dödüren Int Parametreli Mettotlar

            int Sum (int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            Console.WriteLine(Sum(45, 98));
            Console.WriteLine(Sum(36, 98));
            Console.WriteLine(Sum(44, 36));
            Console.WriteLine(Sum(14, 20));


            #endregion


            #region örnek uygulama
            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >=50)
                {
                    return "ögrenci sınavı geçti";
                }
                    else
                    {
                    return "ögrenci başarısız oldu";
                }
                    
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));


            #endregion



            Console.ReadLine();
       }
    }
}
