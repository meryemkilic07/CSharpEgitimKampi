using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBase_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            string TableNumber;




            Console.WriteLine("*****C# Veri Tabanlı Ürün Ktegori Bilgi Sistemi*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("lütfen getirmek istediginiz tablo numarasını giriniz:");
            Console.WriteLine();
            TableNumber = Console.ReadLine();
            SqlConnection connection=new SqlConnection(" Data Source=LAPTOP-QIDCB50J\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);//sql ile c# arasında bir köprü oluşturuyor
            DataTable dataTable = new DataTable();//verileri ram ealmayı saglar
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
               foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
               Console.WriteLine();
            }

            Console.Read();
        }
    }
}
