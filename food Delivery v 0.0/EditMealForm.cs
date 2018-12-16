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
    public partial class EditMealForm : Form
    {
        Account user = new Account();
        public EditMealForm()
        {
            InitializeComponent();
            groupBox3.BackColor = Color.FromArgb(150, Color.Black);
            groupBox1.BackColor = Color.FromArgb(150, Color.Black);
        }

        private void EditMealForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_bt_Click(object sender, EventArgs e)
        {
            user.con.Open();
            user.cmd = new SqlCommand("Update Menu set MealName='" + MealName_txt.Text + "' ,Meal_Details='" + MealDetails_txt.Text + "', price='" + MealPrice_txt.Text + "' ,CookUsername='" + CookUsername_txt.Text + "' where meal_ID='" + MealID_txt.Text + "' ", user.con);
            user.cmd.ExecuteNonQuery();
            user.con.Close();

            DialogResult result = MessageBox.Show("Meal edited successfuly!", "Edit done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_bt_Click_1(object sender, EventArgs e)
        {
            user.con.Open();
            user.cmd = new SqlCommand("select MealName,Meal_Details,price,CookUsername from Menu where meal_ID='" + MealID_txt.Text + "'", user.con);
            user.sdr = user.cmd.ExecuteReader();
            while (user.sdr.Read())
            {
                MealName_txt.Text = user.sdr["MealName"].ToString();
                MealDetails_txt.Text = user.sdr["Meal_Details"].ToString();
                MealPrice_txt.Text = user.sdr["price"].ToString();
                CookUsername_txt.Text = user.sdr["CookUsername"].ToString();
            }
            user.sdr.Close();
            user.con.Close();
        }
    }
}
