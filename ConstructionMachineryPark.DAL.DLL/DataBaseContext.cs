using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

using ConstructionMachineryPark.BAL.DLL;

namespace ConstructionMachineryPark.DAL.DLL
{
    public class DataBaseContext<T> where T:class
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;

        //private static readonly string connStr =
        //    @"Server = HPPAVGAM17\SQLEXPRESS\SQLEXPRESS; " +
        //    "Database = MCS; " +
        //    "User Id = ova; " +
        //    "Password=123 222222222";

        private string GetTableName(T obj)
        {
            // название типа объекта совпадает с названием таблицы в БД
            string objTypeName = obj.GetType().ToString();
            return objTypeName.Substring(objTypeName.LastIndexOf('.') + 1);
        }

        public bool Create(T obj)
        {


            string sql = $"INSERT INTO {GetTableName(obj)}";
            try
            {

                using(IDbConnection db = new SqlConnection(connectionString))
                {
                    
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public List<T> GetAll(string tableName)
        {
            List<T> objects = new List<T>();

            string query = $"SELECT * FROM {tableName}";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                objects = db.Query<T>(query).ToList();
            }
            return objects;
        }

        public T GetOne(string tableName, string fieldName, string value)
        {
            T obj = null;
            string query = $"SELECT * FROM {tableName} WHERE {fieldName} = {value}";

            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    obj = db.Query<T>(query).FirstOrDefault();
                }
                
                return obj;
            }
            catch
            {
                return obj;
            }

        }

        public bool Update(T obj)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return true;
        }
    }

    //public class ConnDataBaseSQL
    //{
    //    public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
    //    // создаем строку с данными для подключения к БД SQL
    //    public ConnDataBaseSQL()
    //    {
    //        builder.DataSource = @"";
    //        builder.UserID = "ova";
    //        builder.Password = "123";
    //        builder.InitialCatalog = "master";
    //    }

    //    // Получаем данные из БД
    //    public List<string> ReadData()
    //    {
    //        string sqlQuery = "SELECT * FROM Equipment";

    //        //Console.WriteLine("-------------------------------------------------------------------");
    //        List<string> rowsStr = new List<string>();
    //        try
    //        {
    //            //Console.Write("Connecting to SQL Server ... \n");
    //            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
    //            {
    //                connection.Open();
    //                Console.WriteLine("Done.");
    //                Console.WriteLine("ServerVersion: {0}", connection.ServerVersion);
    //                Console.WriteLine("State: {0}", connection.State);

    //                // READ table
    //                //Console.WriteLine("Reading data from table... \n\n");

    //                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
    //                {
    //                    using (SqlDataReader reader = command.ExecuteReader())
    //                    {
    //                        //Console.WriteLine();

    //                        //считываем строки таблицы
    //                        while (reader.Read())
    //                        {
    //                            // создаем переменную для записи одной строки.
    //                            // обнуляем эту строку на каждой итерации цикла
    //                            string oneRowStr = null;
    //                            // считываем все имеющиеся поля каждой строки таблицы
    //                            for (int i = 0; i != reader.FieldCount; i++)
    //                            {
    //                                // считали строку таблицы - записали в строку
    //                                oneRowStr += reader.GetValue(i) + "; ";
    //                            }
    //                            rowsStr.Add(oneRowStr);
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.ToString());
    //            Console.WriteLine("\n-------------------------------------------------------------------\n\n");
    //        }
    //        return rowsStr;
    //    }
    //}
}
