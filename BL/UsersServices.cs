using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using System.Security.Cryptography;
using System.IO;

namespace BL
{
    public class UsersServices
    {
        UsersDAL usersDAL = new UsersDAL();

        private string getMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public User login(string username, string pass)
        {
            string password = getMd5Hash(pass);
            User user = usersDAL.getUser(username, password);
            return user;
        }

        public String ChangePassword(string user)
        {
            string new_password = generateRandomPassword();
            usersDAL.resetPassword(user, getMd5Hash(new_password));
            return new_password;
        }

        private string generateRandomPassword()
        {
            String str = Path.GetRandomFileName();
            String new_pass = str.Replace(".","").Substring(0,4);
            return new_pass;
        }

        public void createUser(User new_user)
        {
            String password = generateRandomPassword();
            usersDAL.createUser(new_user, password);
        }

        public User readUser(String username)
        {
            return usersDAL.readUser(username);
        }

        public void updateUser(User user)
        {
            usersDAL.updateUser(user);
        }

        public void deleteUser(String username)
        {
            usersDAL.deleteUser(username);
        }
    }
}
