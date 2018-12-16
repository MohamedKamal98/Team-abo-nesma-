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
            request_txt.Hide();
            request_btn.Hide();
        }

        private void orderRecordsButton_Click(object sender, EventArgs e)
        {
            request_txt.Hide();
            request_btn.Hide();
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
            request_txt.Hide();
            request_btn.Hide();
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
            request_txt.Hide();
            request_btn.Hide();
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
            request_txt.Hide();
            request_btn.Hide();
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
            request_txt.Hide();
            request_btn.Hide();
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
            request_txt.Hide();
            request_btn.Hide();
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
            request_btn.Show();
            request_txt.Show();
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Checker ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void request_txt_Enter(object sender, EventArgs e)
        {
            request_txt.ForeColor = Color.Black;
            if (request_txt.Text == "checker username")
                request_txt.Text = "";
        }

        private void request_txt_Leave(object sender, EventArgs e)
        {
            if (request_txt.Text == "")
            {
                request_txt.ForeColor = Color.Silver;
                request_txt.Text = "checker username";
            }
        }

        private void request_btn_Click(object sender, EventArgs e)
        {
            user.con.Close();
            SqlCommand cmd = new SqlCommand("update Checker set Request='" + 1 + "'where  Username='" + request_txt.Text + "'",user.con);
             user.con.Open();
            cmd.ExecuteNonQuery();
            user.con.Close();
            MessageBox.Show("Request sent successfully !", "success!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                request_txt.ForeColor = Color.Silver;
                request_txt.Text = "checker username";

        }
    }
}
