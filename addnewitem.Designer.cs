namespace clothShop
{
    partial class addnewitem
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.TextBox();
            this.product_id = new System.Windows.Forms.TextBox();
            this.no_pcs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.money_pcs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Stock";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show Invoice";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "Transaction";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. of pcs";
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(453, 113);
            this.product_name.Multiline = true;
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(166, 28);
            this.product_name.TabIndex = 8;
            this.product_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // product_id
            // 
            this.product_id.Location = new System.Drawing.Point(453, 186);
            this.product_id.Multiline = true;
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(166, 28);
            this.product_id.TabIndex = 9;
            this.product_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // no_pcs
            // 
            this.no_pcs.Location = new System.Drawing.Point(453, 265);
            this.no_pcs.Multiline = true;
            this.no_pcs.Name = "no_pcs";
            this.no_pcs.Size = new System.Drawing.Size(166, 28);
            this.no_pcs.TabIndex = 10;
            this.no_pcs.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Money per pcs";
            // 
            // money_pcs
            // 
            this.money_pcs.Location = new System.Drawing.Point(453, 338);
            this.money_pcs.Multiline = true;
            this.money_pcs.Name = "money_pcs";
            this.money_pcs.Size = new System.Drawing.Size(166, 28);
            this.money_pcs.TabIndex = 12;
            this.money_pcs.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(426, 438);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 38);
            this.button6.TabIndex = 14;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // addnewitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.money_pcs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.no_pcs);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "addnewitem";
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.addnewitem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.TextBox product_id;
        private System.Windows.Forms.TextBox no_pcs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox money_pcs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
    }
}