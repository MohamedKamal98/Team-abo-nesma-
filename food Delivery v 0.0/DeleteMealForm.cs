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

namespace food_Delivery_v_0._0
{
    public partial class DeleteMealForm : Form
    {
        Account user = new Account();
        public DeleteMealForm()
        {
            InitializeComponent();
            groupBox1.BackColor = Color.FromArgb(150, Color.Black);
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_bt_Click(object sender, EventArgs e)
        {

        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteMealForm_Load(object sender, EventArgs e)
        {

        }

        private void Delete_bt_Click_1(object sender, EventArgs e)
        {
            user.con.Open();
            user.cmd = new SqlCommand("delete from Menu where meal_ID='" + MealID_txt.Text + "' ", user.con);
            user.cmd.ExecuteNonQuery();
            user.con.Close();

            DialogResult result = MessageBox.Show("Meal was deleted successfuly!", "Delete done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void Cancel_bt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
