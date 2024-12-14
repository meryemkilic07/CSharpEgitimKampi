using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud----> create-read-update-delete
            Console.WriteLine("*****Menü Sipariş İşlem Paneli*****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            #region Kategori ekleme işlemi
            //Console.WriteLine("Eklemek istediginiz kategori adı:");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection=new SqlConnection("Data Source=LAPTOP-QIDCB50J\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);

            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarılı bir şekilde eklendi.");
            #endregion


            #region ürün ekleme işlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;


            //Console.Write("ürün adı giriniz:");
            //productName =Console.ReadLine();
            //Console.Write("ürün fiyatı giriniz:");
            //productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection=new SqlConnection("Data Source=LAPTOP-QIDCB50J\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,productStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("ürün eklemesi başarılı");
            #endregion


            #region Ürünlisteleme

            //SqlConnection connection=new SqlConnection("Data Source=LAPTOP-QIDCB50J\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command=new SqlCommand("Select* From TblProduct",connection);
            //SqlDataAdapter adapter=new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());

            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region ürün silme


            //Console.Write("silinecek ürün İd giriniz:");

            //int productId=int.Parse(Console.ReadLine());


            //SqlConnection connection=new SqlConnection("Data Source=LAPTOP-QIDCB50J\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //Console.WriteLine("silme işlemi yapıldı.");
            //connection.Close();




            #endregion


            #region ürün günceleme


            //Console.Write("güncellencek ürün Id:");
            //int productId =int.Parse(Console.ReadLine());
            //Console.Write("güncelenecek ürün adı:");
            //string productName=Console.ReadLine();
            //Console.Write("güncellencek ürün fiyatı:");
            //decimal productPrice=decimal.Parse(Console.ReadLine()); 



            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-QIDCB50J\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productprice where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("güncelleme başarılı.");
            #endregion





            Console.Read();
                
                
        }
    }
}
