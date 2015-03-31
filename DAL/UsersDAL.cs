using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entities;

namespace DAL
{
    public class UsersDAL
    {
        private String connectionString = "";
        MySqlConnection conn = null;

        public UsersDAL()
        {
            connectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "piataaz");
            conn = new MySqlConnection(connectionString);
        }


        public User getUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM employees WHERE username = '" + username + "' AND password = '" + password + "';";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    if (reader["admin"].Equals(true))
                    {
                        u = new Admin(reader["id"].ToString(), reader["first_name"].ToString(), reader["last_name"].ToString(), reader["salary"].ToString(), reader["phone_number"].ToString(), reader["email"].ToString(), reader["username"].ToString());
                    }
                    else
                    {
                        u = new Employee(reader["id"].ToString(), reader["first_name"].ToString(), reader["last_name"].ToString(), reader["salary"].ToString(), reader["phone_number"].ToString(), reader["email"].ToString(), reader["username"].ToString());
                    }
                }
                else
                {
                    u = null;
                }
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return u;
        }

        public void createUser(User user, String password)
        {
            String admin_status = user is Admin ? "1" : "0";
            String sql = "INSERT INTO `employees` (`first_name`, `last_name`, `salary`, `phone_number`, `email`, `username`, `admin`, `password`)" +
                "VALUES ('" + user.first_name + "','" + user.last_name + "','" + user.salary + "','" + user.phone_number + "','" +
                user.email + "','" + user.username + "','" + admin_status + "','" + password + "');";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
            }
        }

        public User readUser(String username)
        {
            User u = null;
            String sql = "SELECT * FROM employees WHERE username = '" + username + "';";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    if (reader["admin"].Equals(true))
                    {
                        u = new Admin(reader["id"].ToString(), reader["first_name"].ToString(), reader["last_name"].ToString(), reader["salary"].ToString(), reader["phone_number"].ToString(), reader["email"].ToString(), reader["username"].ToString());
                    }
                    else
                    {
                        u = new Employee(reader["id"].ToString(), reader["first_name"].ToString(), reader["last_name"].ToString(), reader["salary"].ToString(), reader["phone_number"].ToString(), reader["email"].ToString(), reader["username"].ToString());
                    }
                }
                else
                {
                    u = null;
                }
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return u;
        }

        public void updateUser(User user)
        {
            String admin_status = user is Admin ? "1" : "0";
            String sql = "UPDATE `employees` SET `first_name`='" + user.first_name + "',`last_name`='" + user.last_name + 
                "',`salary`='" + user.salary + "',`phone_number`='" + user.phone_number + "',`email`='" + user.email + 
                "',`username`='" + user.username + "',`admin`='" + admin_status + "' WHERE `id`='" + user.id + "';";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
            }
        }

        public void deleteUser(String username)
        {
            String sql = "DELETE FROM `employees` WHERE `username`='" + username + "';";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
            }
        }

        public void resetPassword(string username, string new_password)
        {
            String sql = "UPDATE employees SET password = '" + new_password + "' WHERE username='" + username + "';";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
            }
        }
    }
}
