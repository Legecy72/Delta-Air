using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;


namespace Delta_Air
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\querc\source\repos\Delta Air\Delta Air\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from air", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into air "
                + "values(" + txtNum.Text + " , '" + txtName.Text + "','" + txtRe.Text + "' , '" + txtDate.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE air SET [Name] = '" + txtName.Text + "', " +
                " Region =  '" + txtRe.Text + "' WHERE [Ticket Number] = " + txtNum.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM air WHERE [Ticket Number] = " + txtNum.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}