using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int [] number = { 226, 33,454,5,55,46,464,326 };
            // foreach (int city in number)
            // {
            //    Console.WriteLine(city);
            // }


            //int [] numbers = { 1,2,3,4,5,6,7,8,9 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int [] numbers = { 123,2,3,4,85,646,7,8,49 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //   total += i; 
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()//listeler oluşturuyor

            //{
            //    1,2,3,4,5,8 //bu şekilde direk eleman tanımalam yapılabilir.

            //};
            //Console.WriteLine(numbers);

            //foreach (int number in numbers) { 
            //Console.WriteLine(number);//liste elemanlarını yazdırız


            //}

            //string word = "merhaba";
            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}





            #endregion

            #region Sınav sistemi uygulamsı

            //Console.WriteLine("****C# Egitim Kampı Sınav Uygulamsı*****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("sınıfınızda kaç ögrenci var:");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            //string[] studentNames=new string[studentCount];
            //double[] studentExamAvg=new double[studentCount];   
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.ögrencinin ismini giriniz:");
            //    studentNames[i] = Console.ReadLine();
            //    double totalExamResult = 0;

            //    for(int j=0;j<3;j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı ögrencinin {j+1}.sınav notunu giriniz:");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value;//notları topluyoruz
            //        Console.WriteLine();
            //    }
            //    studentExamAvg[i]= totalExamResult/3;
            //}

            //for(int i=0;i<studentCount; i++)
            //{
            //    Console.WriteLine("----------------------------------------") ;
            //    Console.WriteLine($"{studentNames[i]} adlı ögrencinin ortalması:{studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50)
            //    {

            //        Console.WriteLine($"{studentNames[i]} adlı ögrenci dersi geçti") ;
                
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı ögrenci derten kaldı");
            //    }

            //    Console.WriteLine("-----------------------------------------------");

            //}








            #endregion


            Console.Read();
        }
    }
}
