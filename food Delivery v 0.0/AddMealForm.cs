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
    public partial class AddMealForm : Form
    {
        Account user = new Account();
        public AddMealForm()
        {
            InitializeComponent();
            groupBox1.BackColor = Color.FromArgb(150, Color.Black);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_bt_Click(object sender, EventArgs e)
        {
            user.cmd = new System.Data.SqlClient.SqlCommand("insert into Menu(meal_ID,MealName,price,CookUsername,Meal_Details,rate) values('"+ MealID_txt.Text + "','" + MealName_txt.Text + "','" + MealPrice_txt.Text + "','" + CookUsername_txt.Text + "','"+MealDetails_txt.Text+"',0)", user.con);
            user.con.Open();
            user.cmd.ExecuteNonQuery();
            user.con.Close();

           DialogResult result = MessageBox.Show("Meal added successfuly!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMealForm_Load(object sender, EventArgs e)
        {

        }
    }
}
