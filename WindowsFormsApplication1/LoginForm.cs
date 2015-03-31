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
    public partial class LoginForm : Form
    {
        UsersServices service = new UsersServices();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = user_textbox.Text;
            string password = pass_textbox.Text;
            User user = service.login(username, password);
            if (user == null)
            {
                reset_pass_button.Visible = true;
                MessageBox.Show("Incorrect user or password");
            }
            else
            {

                if (user is Admin)
                {
                    AdminForm form = new AdminForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    UserForm form = new UserForm(user);
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void reset_pass_button_Click(object sender, EventArgs e)
        {
            String new_password = service.ChangePassword(user_textbox.Text);
            MessageBox.Show("New password is: " + new_password);
        }
    }
}
