using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt altta 10 tane yıldız oluşturma


            ////for (int i = 0; i<=10;i++)
            ////{
            ////    Console.WriteLine("*");
            //}
            #endregion

            #region yan yana yıldız oluşturma
            // for (int i = 0; i<=10;i++)
            //{
            //    Console.Write("*");
            // }



            #endregion


            #region aşt alta 10 yıldız oluşturma he rsatırda 10 tane yıldız oluşturma
            //for (int i = 0; i<=10;i++)
            //{
            // Console.WriteLine("************");
            //}

            #endregion


            #region Dik üçgen


            //for (int i = 1; i<=5;i++)
            //{
            //    for(int j = 1; j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();    
            //}

            #endregion


            #region ters dik üçgen
            //for (int i = 5; i>=1;i--)
            //{
            //   for(int j = 1; j<=i;j++)
            //   {
            //      Console.Write("*");
            //  }
            //   Console.WriteLine();    
            //}


            #endregion


            #region dik ve ters üçgen berraber

            //for (int i = 1;i<=5;i++)
            //{
            //    for (int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava dilimi


            //for(int i=1;i<=5;i++)
            //{
            //    for (int j = 4; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    { 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i=4;i>=1 ;i--)
            //{
            //    for (int j = 4; j >= 0; j--)
            //    { 
            //        Console.Write(" ");

            //    }
            //    for (int k =1;k<= 2 * i - 1;k++)
            //    {
            //    Console.Write("*");

            //    }
            //    Console.WriteLine();

            //}



            #endregion

            #region piramit

            //int n = 5;
            //for(int i=1; i<=n;i++)
            //{
            //    for(int j=n-i;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    { 
            //    Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region ters piramit


            //int n = 5;
            //for(int i=n; i>=1;i--)
            //{
            //   for(int j=n-i;j>0;j--)
            //  {
            //      Console.Write(" ");
            // }
            // for (int k = 1; k <= 2 * i - 1; k++)
            //  { 
            //  Console.Write("*");

            //  }
            //  Console.WriteLine();
            //}



            #endregion

            Console.Read();
        }
    }
}
