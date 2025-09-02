using EF_Core_4.Data;
using EF_Core_4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

            //int rowsAffected = context.Database.ExecuteSqlRaw(
            //                                             "UPDATE Products SET UnitPrice = UnitPrice * 1.1 WHERE CategoryID = {0}", 2);

            //Console.WriteLine($"{rowsAffected} rows were updated.");
            #endregion




            #region Inheritance Mapping 

            //1-- TPH [Table Per Hierarchy]
            //    Parent table stores all entities in the hierarchy and uses a discriminator column to differentiate between them.
            //2-- TPT [Table Per Type]
            //    Each entity in the hierarchy is mapped to its own table, with relationships established between them.
            //3-- TPC [Table Per Concrete Class]
            //    Each concrete class in the hierarchy is mapped to its own table, containing all properties of the class.


            #endregion
        }
    }
}
