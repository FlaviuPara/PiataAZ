using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BL;

namespace WindowsFormsApplication1
{
    public partial class AdminForm : Form
    {
        AddsServices addsServices = new AddsServices();
        UsersServices usersServices = new UsersServices();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            User user;
            String usename = username_textbox.Text;
            String first_name = firstname_textbox.Text;
            String last_name = lastname_textbox.Text;
            String salary = salary_textbox.Text;
            String phone = phone_textbox.Text;
            String email = email_textbox.Text;
            if (admin_textbox.Text.Equals("yes"))
            {
                user = new Admin(null,first_name,last_name,salary,phone,email,usename);
            }
            else
                if (admin_textbox.Text.Equals("no"))
                {
                    user = new Employee(null, first_name, last_name, salary, phone, email, usename);
                }
                else
                {
                    MessageBox.Show("Admin field must be 'yes'/'no'");
                    return;
                }
            usersServices.createUser(user);
            MessageBox.Show("Create succesfull");
        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = usersServices.readUser(username_textbox.Text);
                firstname_textbox.Text = user.first_name;
                lastname_textbox.Text = user.last_name;
                salary_textbox.Text = user.salary;
                phone_textbox.Text = user.phone_number;
                email_textbox.Text = user.email;
                String admin_status = user is Admin ? "yes" : "no";
                admin_textbox.Text = admin_status;
            }
            catch
            {
                MessageBox.Show("Failed to read add. Username may not be valid");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            User user = usersServices.readUser(username_textbox.Text);
            try
            {
                if (!firstname_textbox.Text.Equals(""))
                {
                    user.first_name = firstname_textbox.Text;
                }
                if (!lastname_textbox.Text.Equals(""))
                {
                    user.last_name = lastname_textbox.Text;
                }
                if (!salary_textbox.Text.Equals(""))
                {
                    user.salary = salary_textbox.Text;
                }
                if (!phone_textbox.Text.Equals(""))
                {
                    user.phone_number = phone_textbox.Text;
                }
                if (!email_textbox.Text.Equals(""))
                {
                    user.email = email_textbox.Text;
                }
                usersServices.updateUser(user);
            }
            catch
            {
                MessageBox.Show("Update failed. Username may not be valid");
            }
            MessageBox.Show("Update succesfull");
        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            if (usersServices.readUser(username_textbox.Text) == null)
            {
                MessageBox.Show("Nothing to delete");
            }
            else
            {
                usersServices.deleteUser(username_textbox.Text);
                MessageBox.Show("Delete succesfull");
            }
        }

        private void count_btn_Click(object sender, EventArgs e)
        {
            String username = username_textbox.Text;
            int nr = addsServices.getNrOfAddsForUser(username);
            MessageBox.Show(username + " has loaded " + nr.ToString() + " adds");
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
