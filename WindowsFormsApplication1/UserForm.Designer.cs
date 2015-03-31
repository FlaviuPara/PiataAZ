namespace WindowsFormsApplication1
{
    partial class UserForm
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
            this.create_add_btn = new System.Windows.Forms.Button();
            this.read_add_btn = new System.Windows.Forms.Button();
            this.update_add_btn = new System.Windows.Forms.Button();
            this.delete_add_btn = new System.Windows.Forms.Button();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.load_jped_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // create_add_btn
            // 
            this.create_add_btn.Location = new System.Drawing.Point(12, 12);
            this.create_add_btn.Name = "create_add_btn";
            this.create_add_btn.Size = new System.Drawing.Size(118, 23);
            this.create_add_btn.TabIndex = 0;
            this.create_add_btn.Text = "Create add";
            this.create_add_btn.UseVisualStyleBackColor = true;
            this.create_add_btn.Click += new System.EventHandler(this.create_add_btn_Click);
            // 
            // read_add_btn
            // 
            this.read_add_btn.Location = new System.Drawing.Point(136, 12);
            this.read_add_btn.Name = "read_add_btn";
            this.read_add_btn.Size = new System.Drawing.Size(118, 23);
            this.read_add_btn.TabIndex = 1;
            this.read_add_btn.Text = "Read add";
            this.read_add_btn.UseVisualStyleBackColor = true;
            this.read_add_btn.Click += new System.EventHandler(this.read_add_btn_Click);
            // 
            // update_add_btn
            // 
            this.update_add_btn.Location = new System.Drawing.Point(260, 12);
            this.update_add_btn.Name = "update_add_btn";
            this.update_add_btn.Size = new System.Drawing.Size(118, 23);
            this.update_add_btn.TabIndex = 2;
            this.update_add_btn.Text = "Update add";
            this.update_add_btn.UseVisualStyleBackColor = true;
            this.update_add_btn.Click += new System.EventHandler(this.update_add_btn_Click);
            // 
            // delete_add_btn
            // 
            this.delete_add_btn.Location = new System.Drawing.Point(384, 12);
            this.delete_add_btn.Name = "delete_add_btn";
            this.delete_add_btn.Size = new System.Drawing.Size(118, 23);
            this.delete_add_btn.TabIndex = 3;
            this.delete_add_btn.Text = "Delete add";
            this.delete_add_btn.UseVisualStyleBackColor = true;
            this.delete_add_btn.Click += new System.EventHandler(this.delete_add_btn_Click);
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(162, 72);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(144, 22);
            this.id_textbox.TabIndex = 4;
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(160, 193);
            this.description_textbox.Multiline = true;
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(342, 130);
            this.description_textbox.TabIndex = 5;
            // 
            // picture_box
            // 
            this.picture_box.Location = new System.Drawing.Point(360, 72);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(142, 79);
            this.picture_box.TabIndex = 6;
            this.picture_box.TabStop = false;
            // 
            // title_textbox
            // 
            this.title_textbox.Location = new System.Drawing.Point(162, 129);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(144, 22);
            this.title_textbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description :";
            // 
            // load_jped_btn
            // 
            this.load_jped_btn.Location = new System.Drawing.Point(384, 157);
            this.load_jped_btn.Name = "load_jped_btn";
            this.load_jped_btn.Size = new System.Drawing.Size(108, 30);
            this.load_jped_btn.TabIndex = 11;
            this.load_jped_btn.Text = "Load Jped";
            this.load_jped_btn.UseVisualStyleBackColor = true;
            this.load_jped_btn.Click += new System.EventHandler(this.load_bmp_btn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 345);
            this.Controls.Add(this.load_jped_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.picture_box);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.delete_add_btn);
            this.Controls.Add(this.update_add_btn);
            this.Controls.Add(this.read_add_btn);
            this.Controls.Add(this.create_add_btn);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_add_btn;
        private System.Windows.Forms.Button read_add_btn;
        private System.Windows.Forms.Button update_add_btn;
        private System.Windows.Forms.Button delete_add_btn;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button load_jped_btn;
    }
}