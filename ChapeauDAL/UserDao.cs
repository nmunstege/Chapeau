using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
  public  class UserDao:BaseDao
    {
        public User UserLogin(string FirstName, int Passcode)
        {
            SqlCommand cmd = new SqlCommand("select User_ID, FirstName, LastName, Email, Passcode, Type from Users WHERE [Passcode] = @pass and [FirstName] = @name ", conn);
            cmd.Parameters.AddWithValue("@pass", Passcode);
            cmd.Parameters.AddWithValue("@name", FirstName);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            User users = ReadUser(reader);
            conn.Close();
            reader.Close();
            if (users == null)
            {
                return null;
            }

            return users;
        }
        public User ReadUser(SqlDataReader reader)
        {
            User users = new User
            {
                User_ID = (int)reader["User_ID"],
                FirstName = (string)reader["FirstName"],
                Passcode = (int)reader["Passcode"],
                LastName = (string)reader["LastName"],
                Type = (string)reader["Type"],
                Email = (string)reader["Email"],

            };
            return users;
        }
    }
}

