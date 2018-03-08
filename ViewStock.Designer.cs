namespace clothShop
{
    partial class ViewStock
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewstockGirdView = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewstockGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 55);
            this.button5.TabIndex = 24;
            this.button5.Text = "Transaction";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 55);
            this.button4.TabIndex = 23;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 55);
            this.button3.TabIndex = 22;
            this.button3.Text = "Show Invoice";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 55);
            this.button2.TabIndex = 21;
            this.button2.Text = "View Stock";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 55);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewstockGirdView
            // 
            this.viewstockGirdView.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.viewstockGirdView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewstockGirdView.Location = new System.Drawing.Point(307, 70);
            this.viewstockGirdView.Name = "viewstockGirdView";
            this.viewstockGirdView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewstockGirdView.Size = new System.Drawing.Size(521, 463);
            this.viewstockGirdView.TabIndex = 25;
            this.viewstockGirdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(739, 582);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 41);
            this.button6.TabIndex = 26;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.viewstockGirdView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ViewStock";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ViewStock";
            this.Load += new System.EventHandler(this.ViewStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewstockGirdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView viewstockGirdView;
        private System.Windows.Forms.Button button6;
    }
}