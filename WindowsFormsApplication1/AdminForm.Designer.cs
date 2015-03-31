namespace WindowsFormsApplication1
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_btn = new System.Windows.Forms.Button();
            this.read_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_user = new System.Windows.Forms.Button();
            this.count_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.salary_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.admin_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(19, 21);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(103, 23);
            this.create_btn.TabIndex = 0;
            this.create_btn.Text = "Create user";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // read_btn
            // 
            this.read_btn.Location = new System.Drawing.Point(19, 67);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(103, 23);
            this.read_btn.TabIndex = 1;
            this.read_btn.Text = "Read user";
            this.read_btn.UseVisualStyleBackColor = true;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(19, 117);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(103, 23);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "Update user";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(19, 167);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(103, 23);
            this.delete_user.TabIndex = 3;
            this.delete_user.Text = "Delete user";
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // count_btn
            // 
            this.count_btn.Location = new System.Drawing.Point(19, 220);
            this.count_btn.Name = "count_btn";
            this.count_btn.Size = new System.Drawing.Size(103, 23);
            this.count_btn.TabIndex = 4;
            this.count_btn.Text = "User\'s activity";
            this.count_btn.UseVisualStyleBackColor = true;
            this.count_btn.Click += new System.EventHandler(this.count_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "First name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Admin :";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(341, 22);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(160, 22);
            this.username_textbox.TabIndex = 12;
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(341, 52);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(160, 22);
            this.firstname_textbox.TabIndex = 13;
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(341, 84);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(160, 22);
            this.lastname_textbox.TabIndex = 14;
            // 
            // salary_textbox
            // 
            this.salary_textbox.Location = new System.Drawing.Point(341, 117);
            this.salary_textbox.Name = "salary_textbox";
            this.salary_textbox.Size = new System.Drawing.Size(160, 22);
            this.salary_textbox.TabIndex = 15;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(341, 154);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(160, 22);
            this.phone_textbox.TabIndex = 16;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(341, 191);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(160, 22);
            this.email_textbox.TabIndex = 17;
            // 
            // admin_textbox
            // 
            this.admin_textbox.Location = new System.Drawing.Point(341, 223);
            this.admin_textbox.Name = "admin_textbox";
            this.admin_textbox.Size = new System.Drawing.Size(160, 22);
            this.admin_textbox.TabIndex = 18;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 266);
            this.Controls.Add(this.admin_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.salary_textbox);
            this.Controls.Add(this.lastname_textbox);
            this.Controls.Add(this.firstname_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_btn);
            this.Controls.Add(this.delete_user);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.create_btn);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button read_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_user;
        private System.Windows.Forms.Button count_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.TextBox salary_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox admin_textbox;
    }
}