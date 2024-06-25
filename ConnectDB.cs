using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace dotnetProject
{
    internal class ConnectDB
    {
        
        public static void Connectdb()
            {
                string sql = "Server=tcp:dotnetdatabase.database.windows.net,1433;Initial Catalog=mydb;Persist Security Info=False;User ID=database;Password=Diemly@26;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                using (SqlConnection connection = new SqlConnection(sql))
                {
                    try
                    {
                        connection.Open();                   
                        SqlCommand query = new SqlCommand("SELECT * FROM dbo.Account WHERE id = ", connection);
                        SqlDataReader reader = query.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} - {reader[1]}");
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
        
    }
}
