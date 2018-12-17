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
    public partial class Meal_Details_for_checker : UserControl
    {
        Account user = new Account();

        public Meal_Details_for_checker()
        {
            InitializeComponent();
        }

        private void Meal_Details_for_checker_Load(object sender, EventArgs e)
        {

        
        }
        public void show_meal_details()
        {

            //SqlCommand cmd = new SqlCommand("select * from Menu where meal_ID='" + checker_requests.meal_ID + "'", user.con);
            //user.con.Open();
            //SqlDataReader rd = cmd.ExecuteReader();
            //if (rd.Read())
            //{
            //    M_cook_lbl.Text = rd["CookUsername"].ToString();
            //    M_details_lbl.Text = rd["Meal_Details"].ToString();
            //    M_ID_lbl.Text = rd["meal_ID"].ToString();
            //    M_Name_lbl.Text = rd["MealName"].ToString();
            //    M_Price_lbl.Text = rd["Price"].ToString();
            //    M_Rate_lbl.Text = rd["rate"].ToString();
            //}
            //user.con.Close();
        }


    }
}
