using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace clothShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nayemuzzaman\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where UserName ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Transaction transactionOb = new Transaction();
                transactionOb.Show();
            }
            else
            {
                MessageBox.Show("Please check you username and Password");
            }*/
            this.Hide();
            addnewitem addnewitemOb = new addnewitem();
            addnewitemOb.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup signupOb = new signup();
            signupOb.Show();
        }

    }
}
