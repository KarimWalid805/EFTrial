using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEF;

    public class SqlServerOperations
    {
        public static string DefaultCatalog = "NorthWind2020";
        public static string DatabaseServer = ".\\SQLEXPRESS";
    private SqlConnection cn;
    public static List<Product> ProductsByCategoryIdentifier(int pCategoryIdentifier)
        {
            List<Product> productList = new List<Product>();
  
    var selectStatement =
                @"SELECT 
                    ProductID, 
                    Name, 
                    CategoryId
                FROM dbo.Products 
                WHERE CategoryID = @Identifier";

            using (var cn = new SqlConnection { ConnectionString = $"Server=(localdb)\\MSSQLLocalDB;Database=OnlineDeliveryDB;Integrated Security=True" })
            {
                using (var cmd = new SqlCommand { Connection = cn, CommandText = selectStatement })
                {

                    cmd.Parameters.AddWithValue("@Identifier", pCategoryIdentifier);

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        productList.Add(new Product()
                        {
                            
                            Name = reader.GetString(1)
                        });
                    }
                }

            }

            return productList;
        }
    }
