using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            #region Departments
            //var departmentRepo = new DapperDepartmentRepository(conn);


            //var departments = departmentRepo.GetAllDepartments();

            //foreach (var department in departments)
            //{
            //    Console.WriteLine(department.DepartmentID);
            //    Console.WriteLine(department.Name);
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            //departmentRepo.InsertDepartment("Daniel's New Department");
            //var departmentRepo = new DapperDepartmentRepository(conn);
            //departmentRepo.DeleteDepartment("Daniel's New Department");
            #endregion

            var productRepo = new DapperProductRepository(conn);

            
            //productRepo.CreateProduct("Daniel's New Product", 500, 9, 1, 501);

            //var updateProduct = productRepo.GetProductById(1000);

            //updateProduct.Name = "Daniel's Old Product";
            //updateProduct.Price = 500;
            //updateProduct.CategoryID = 10;
            //updateProduct.OnSale = 0;
            //updateProduct.StockLevel = 600;


            //productRepo.UpdateProduct(updateProduct);

            productRepo.DeleteProduct(1002);

            var products = productRepo.GetAllProducts();

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductID);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.CategoryID);
                Console.WriteLine(product.OnSale);
                Console.WriteLine(product.StockLevel);
                Console.WriteLine();
                Console.WriteLine();

            }




        }
    }
}
