namespace clothShop
{
    partial class signup
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
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(372, 120);
            this.Name_txt.Multiline = true;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(258, 33);
            this.Name_txt.TabIndex = 0;
            this.Name_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(372, 280);
            this.Phone_txt.Multiline = true;
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(258, 33);
            this.Phone_txt.TabIndex = 1;
            this.Phone_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(372, 366);
            this.Address_txt.Multiline = true;
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(258, 33);
            this.Address_txt.TabIndex = 2;
            this.Address_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(372, 194);
            this.Email_txt.Multiline = true;
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(258, 33);
            this.Email_txt.TabIndex = 3;
            this.Email_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(372, 450);
            this.Password_txt.Multiline = true;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(258, 33);
            this.Password_txt.TabIndex = 4;
            this.Password_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Registration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.Name_txt);
            this.Name = "signup";
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}