using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entities;
using System.Drawing;
using System.IO;

namespace DAL
{
    public class AddsDAL
    {
        private String connectionString = "";
        MySqlConnection conn = null;

        public AddsDAL()
        {
            connectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "piataaz");
            conn = new MySqlConnection(connectionString);
        }

        public void createAdd(Add add)
        {
            byte[] image = new byte[add.photo.Size.Height * add.photo.Size.Width];
            try
            {
                MemoryStream ms = new MemoryStream();
                add.photo.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                image = ms.ToArray();
            }
            catch
            {
                image = null;
            }
            String sql = "INSERT INTO `adds` (`title`, `description`, `photo`, `employee_username`) " + 
                "VALUES ('" + add.title + "','" + add.description + "','" + image + "','" + add.username + "');";
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

        public Add readAdd(String id)
        {
            String sql = "SELECT * FROM `adds` WHERE id = '" + id + "';";
            Add add;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Image image;
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        byte[] byteArray = (byte[]) reader["photo"];
                        ms.Write(byteArray, 0, byteArray.Length);
                        image = Image.FromStream(ms);
                    }
                    catch
                    {
                        image = null;
                    }
                    add = new Add(reader["id"].ToString(), reader["title"].ToString(), reader["description"].ToString(), image, reader["employee_username"].ToString());
                }
                else
                {
                    add = null;
                }
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return null;
            }
            return add;
        }

        public void updateAdd(Add add)
        {
            String sql = "UPDATE `adds` SET `title`='" + add.title + "',`description`='" + add.description +
                "',`photo`=" + add.photo + ",`employee_username`='" + add.username + "' WHERE `id`='" + add.id + "';";
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

        public void deleteAdd(String id)
        {
            String sql = "DELETE FROM `adds` WHERE `id`='" + id + "';";
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

        public int getNrOfAddsForUser(String username)
        {
            String sql = "SELECT COUNT(*) FROM `adds` WHERE `employee_username` = '" + username + "';";
            int nr = 0;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                nr = int.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return 0;
            }
            return nr;
        }
    }
}
