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

namespace food_Delivery_v_0._0
{
    public partial class Cook_Requests : UserControl
    {
        Account user = new Account();
        public Cook_Requests()
        {
            InitializeComponent();
        }

        private void UpdateMeal_bt_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMenu_lbl_Click(object sender, EventArgs e)
        {           
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int mealserial =Int32.Parse(selectedRow.Cells[12].Value.ToString());


            user.cmd = new SqlCommand("Update Order_Record set isPrepared=1 where serial='"+mealserial+"'", user.con);
            user.con.Open();
            user.cmd.ExecuteNonQuery();
            user.con.Close();

            MessageBox.Show("Meal submitted successfuly!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Cook_Requests_Load(object sender, EventArgs e)
        {
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from Order_Record where CookUsername='" + SignInControl.username + "' and isPrepared=0", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();

            //data grid view design
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

        private void BackBt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateMenu_lbl_Click_1(object sender, EventArgs e)
        {
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from Order_Record where CookUsername='" + SignInControl.username + "' and isPrepared=0", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }
    }
}
