using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace food_Delivery_v_0._0.User_Controls
{
    public partial class AdminReviews : UserControl
    {
        Account user = new Account();
        public AdminReviews()
        {
            InitializeComponent();
        }

        private void AdminReviews_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void orderRecordsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Order_Record ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Rate ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void adminsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Admin ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Customer ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void cooksButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Cooks ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void driversButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Driver ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void checkersButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Checker ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }
        private void menusButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Menu ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }
    }
}
