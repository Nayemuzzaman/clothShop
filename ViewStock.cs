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
    public partial class ViewStock : Form, addnewitem
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nayemuzzaman\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        public ViewStock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void disp_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from additem";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            viewstockGirdView.DataSource = dt;

            conn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ViewStock_Load(object sender, EventArgs e)
        {
            disp_data();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from additem where ProID='" + product_id.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();

            disp_data();
            MessageBox.Show("Record deleted successfully");
        }
        
    }
}
