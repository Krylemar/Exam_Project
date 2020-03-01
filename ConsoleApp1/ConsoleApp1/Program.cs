using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dan";
            int num = 1;
            MySqlConnection usercon = new MySqlConnection(
                "Server=localhost;" +
                "Database=usersdb;" +
                "User ID=root;" +
                "Password=Tangra;" +
                "Integrated Security=false;");
            usercon.Open();
            using (usercon)
            {
                MySqlCommand Add = new MySqlCommand("INSERT INTO profiles (username) " +
                    "VALUES ('" + name + "')", usercon);
                MySqlCommand Delete = new MySqlCommand("DELETE FROM profiles WHERE (id = '" + num + "')", usercon);
                MySqlCommand Update_lessons = new MySqlCommand("UPDATE profiles SET lessons = lessons + 1 WHERE id = '" + num + "' ", usercon);
                MySqlCommand Get_lessons = new MySqlCommand("SELECT lessons FRom profiles p WHERE p.id ='" + num + "'", usercon);
                Update_lessons.ExecuteNonQuery();
                usercon.Close();

            }
        }
    }
}
