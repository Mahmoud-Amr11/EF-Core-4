using EF_Core_4.Data;
using EF_Core_4.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            //var products = context.AlphabeticalListOfProducts.ToList();

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductId} - {item.ProductName} - {item.CategoryName}");
            //}

            #region DQL [Data Query Language]
            //int categoryId = 2;
            //var product = context.Products
            //    .FromSqlInterpolated($"SELECT * FROM Products WHERE CategoryID = {categoryId}")
            //    .ToList();

            //foreach (var p in product)
            //{
            //    Console.WriteLine($"{p.ProductId} - {p.ProductName} - {p.CategoryId}");
            //}
            #endregion



            #region DML [Data Manipulation Language]

            int rowsAffected = context.Database.ExecuteSqlRaw(
                                                         "UPDATE Products SET UnitPrice = UnitPrice * 1.1 WHERE CategoryID = {0}", 2);

            Console.WriteLine($"{rowsAffected} rows were updated.");
            #endregion

        }
    }
}
