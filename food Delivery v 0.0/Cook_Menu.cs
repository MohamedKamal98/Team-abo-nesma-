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
    public partial class Cook_Menu : UserControl
    {
        Account user = new Account();
        public Cook_Menu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cook_Menu_Load(object sender, EventArgs e)
        {
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from Menu where CookUsername='"+SignInControl.username+"' ",user.con);
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

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            AddMeal_lbl.ForeColor = Color.Gray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            AddMeal_lbl.ForeColor = Color.Black;
        }

        private void EditMeal_lbl_MouseEnter(object sender, EventArgs e)
        {
            EditMeal_lbl.ForeColor = Color.Gray;
        }

        private void EditMeal_lbl_MouseLeave(object sender, EventArgs e)
        {
            EditMeal_lbl.ForeColor = Color.Black;

        }

        private void DeleteMeal_lbl_MouseEnter(object sender, EventArgs e)
        {
            DeleteMeal_lbl.ForeColor = Color.Gray;

        }

        private void DeleteMeal_lbl_MouseLeave(object sender, EventArgs e)
        {
            DeleteMeal_lbl.ForeColor = Color.Black;

        }

        private void AddMeal_lbl_Click(object sender, EventArgs e)
        {
            AddMealForm amf = new AddMealForm();
            amf.Show();
        }

        private void UpdateMenu_lbl_MouseEnter(object sender, EventArgs e)
        {
            UpdateMenu_lbl.ForeColor = Color.Gray;

        }

        private void UpdateMenu_lbl_MouseLeave(object sender, EventArgs e)
        {
            UpdateMenu_lbl.ForeColor = Color.Black;

        }

        private void UpdateMenu_lbl_Click(object sender, EventArgs e)
        {
            user.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from Menu where CookUsername='" + SignInControl.username + "'", user.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            user.con.Close();
        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditMeal_lbl_Click(object sender, EventArgs e)
        {
            EditMealForm f = new EditMealForm();
            f.Show();
        }

        private void DeleteMeal_lbl_Click(object sender, EventArgs e)
        {
            DeleteMealForm f = new DeleteMealForm();
            f.Show();
        }
    }
}
