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
    public partial class AdminRequestToChecker : UserControl
    {
        Account user = new Account();
        public AdminRequestToChecker()
        {
            InitializeComponent();
        }

        private void AdminRequestToChecker_Load(object sender, EventArgs e)
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

        private void requestsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM check_request ", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void request_btn_Click(object sender, EventArgs e)
        {
            user.con.Close();
            if (request_txt.Text == "checker username" || meal_id.Text == "meal ID")
                MessageBox.Show("Please enter checker username and meal ID", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                if (user.check_meal(Convert.ToInt32(meal_id.Text)))
                {
                    if (!user.check_requested(Convert.ToInt32(meal_id.Text)))
                    {
                        SqlCommand cmd = new SqlCommand("set identity_insert check_request on  insert into check_request(checker_id,meal_id)values('" + request_txt.Text + "','" + Convert.ToInt32(meal_id.Text) + "')", user.con);
                        user.con.Open();
                        cmd.ExecuteNonQuery();
                        user.con.Close();
                        MessageBox.Show("Request sent successfully !", "success!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        request_txt.ForeColor = Color.Silver;
                        request_txt.Text = "checker username";
                        meal_id.ForeColor = Color.Silver;
                        meal_id.Text = "meal ID";
                    }
                }
            }
        }

        private void meal_id_Leave(object sender, EventArgs e)
        {
            if (meal_id.Text == "")
            {
                meal_id.ForeColor = Color.Silver;
                meal_id.Text = "meal ID";
            }
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

        private void meal_id_Enter(object sender, EventArgs e)
        {
            meal_id.ForeColor = Color.Black;
            if (meal_id.Text == "meal ID")
                meal_id.Text = "";
        }
    }
}
