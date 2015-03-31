using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entities;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class UserForm : Form
    {
        AddsServices addsServices = new AddsServices();
        private User user;

        public UserForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void create_add_btn_Click(object sender, EventArgs e)
        {
            Add add = new Add(id_textbox.Text, title_textbox.Text, description_textbox.Text, picture_box.BackgroundImage, user.username);
            addsServices.createAdd(add);
            MessageBox.Show("Create succesfull");
        }

        private void read_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Add add = addsServices.readAdd(id_textbox.Text);
                title_textbox.Text = add.title;
                description_textbox.Text = add.description;
                picture_box.BackgroundImage = add.photo;
                MessageBox.Show("Read succesfull");
            }
            catch
            {
                MessageBox.Show("Failed to read add. ID may not be valid");
            }
        }

        private void update_add_btn_Click(object sender, EventArgs e)
        {
            Add add = addsServices.readAdd(id_textbox.Text);
            try
            {
                if (!title_textbox.Text.Equals(""))
                {
                    add.title = title_textbox.Text;
                }
                if (!description_textbox.Text.Equals(""))
                {
                    add.description = description_textbox.Text;
                }
                if (picture_box.BackgroundImage != null && picture_box.BackgroundImage.GetType().Equals(System.Drawing.Imaging.ImageFormat.Bmp))
                {
                    add.description = description_textbox.Text;
                }
                addsServices.updateAdd(add);
            }
            catch
            {
                MessageBox.Show("Update failed. ID may not be valid");
            }
            MessageBox.Show("Update succesfull");
        }

        private void delete_add_btn_Click(object sender, EventArgs e)
        {
            if (addsServices.readAdd(id_textbox.Text) == null)
            {
                MessageBox.Show("Nothing to delete");
            }
            else
            {
                addsServices.deleteAdd(id_textbox.Text);
                MessageBox.Show("Delete succesfull");
            }
        }

        private void load_bmp_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "bmp files (*.bmp)|*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picture_box.BackgroundImage = new Bitmap(dlg.FileName);
            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
