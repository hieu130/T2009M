using MySql.Data.MySqlClient;
using System;

namespace DatabaseHander
{
    class Program
    {
        private static string DatabaseServer = "localhost";
        private static string DatabaseName = "t2009m_student_manager";
        private static string DatabaseUsername = "root";
        private static string DatabasePassword = "";
        private static string ConnectionString = $"Server={DatabaseServer};Database={DatabaseName};" + $"Uid={DatabaseUsername}; Pwd={DatabasePassword}";
        private static string InsertCommand = 
            "insert into students" +
            "(roll_number , full_name , email , birthday , phone , address ,gender , created_at , updated_at , status)" +
            " values " +
            "(@rollNumber , @fullName , @email , @birthday , @phone , @address , @gender , @createAt , @updateAt , @status)";
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //tạo kết nối đến datebase
            using (var connection = 
               new MySqlConnection(ConnectionString)){
                //tạo câu lệnh
                connection.Open();
                var mysqlCommand = new MySqlCommand(InsertCommand, connection);
                mysqlCommand.Parameters.AddWithValue("@rollNumber", "A006");
                mysqlCommand.Parameters.AddWithValue("@fullName", "phanhieu");
                mysqlCommand.Parameters.AddWithValue("@email", "hieuphan1@gmail.com");
                mysqlCommand.Parameters.AddWithValue("@birthday", "2002-03-13");
                mysqlCommand.Parameters.AddWithValue("@phone", "0987654312");
                mysqlCommand.Parameters.AddWithValue("@address", "hanam");
                mysqlCommand.Parameters.AddWithValue("@gender", "1");
                mysqlCommand.Parameters.AddWithValue("@createAt", "2021-10-20");
                mysqlCommand.Parameters.AddWithValue("@updateAt", "2021-10-21");
                mysqlCommand.Parameters.AddWithValue("@status", "1");
                //thực thi
                mysqlCommand.ExecuteNonQuery();
                //try with resoure | using
                Console.WriteLine("Kết Nối Thành Công");
            }
            Console.WriteLine("Auto close connection"); 
        }
    }
}
