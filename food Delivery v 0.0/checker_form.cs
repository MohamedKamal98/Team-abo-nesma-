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
    
    public partial class checker_form : Form
    {
        Account user = new Account();
        
        public checker_form()
        {
            InitializeComponent();
            requests_layout_panl.Hide();
            notification_lbl.Hide();
            meal_Details_for_checker1.Hide();
            Checked_btn.Hide();
        }
        
        private void customImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                WelcomeInterface w = new WelcomeInterface();
                w.Show();
            }
        }
        int i = 0;
        private void customImageButton3_Click(object sender, EventArgs e)
        {

            if(i==0)
            {
                requests_layout_panl.Show();
                notification_lbl.Show();
                requests_layout_panl.Controls.Clear();
                i = 1;
            }
            else if (i == 1)
            {
                requests_layout_panl.Hide();
                notification_lbl.Hide();
                meal_Details_for_checker1.Hide();
                Checked_btn.Hide();
                i = 0;
            }
            user.cmd=new SqlCommand("select meal_id from check_request where checker_id='"+SignInControl.checker_username+"'",user.con);
            user.con.Open();
           SqlDataReader dr = user.cmd.ExecuteReader() ;
            int x = 0;
           while (dr.Read())
           {
               Label mealname = new Label();
               mealname.Text = dr["meal_id"].ToString();
               mealname.Font = new System.Drawing.Font("Microsoft Sans Serif",11,System.Drawing.FontStyle.Bold);
               mealname.Click += new System.EventHandler(this.lableCLK);
               requests_layout_panl.Controls.Add(mealname);
                x++;
                  
           }
            notification_lbl.Text = "you have "+x+" requests"; dr.Close();
           user.con.Close();        
        }

        void lableCLK(object sender, EventArgs e)
        {
            Label current = (Label)sender;
            meal_Details_for_checker1.Show();
            Checked_btn.Show();
            user.con.Open();
            string MealDetailsQuery = "select CookUsername,meal_ID,price,MealName,rate,Meal_Details from Menu where meal_ID = '" + current.Text+ "'";
            SqlCommand cmd = new SqlCommand(MealDetailsQuery, user.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                meal_Details_for_checker1.M_cook_lbl.Text=dr.GetString(0);
                meal_Details_for_checker1.M_ID_lbl.Text=dr.GetString(1);
                float mealPrice = (float)dr.GetDouble(2);
                meal_Details_for_checker1.M_Price_lbl.Text=mealPrice.ToString();
                meal_Details_for_checker1.M_Name_lbl.Text=dr.GetString(3);
                float mealrate = (float)dr.GetDouble(4);
                meal_Details_for_checker1.M_Price_lbl.Text=mealrate.ToString();
                meal_Details_for_checker1.M_details_lbl.Text = dr.GetString(5);

            }
            dr.Close();
            user.con.Close();
        }

        private void Checked_btn_Click(object sender, EventArgs e)
        {
            user.done_request(meal_Details_for_checker1.M_ID_lbl.Text);
            MessageBox.Show("Meal has been checked successfuly", "Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            requests_layout_panl.Hide();
            notification_lbl.Hide();
            meal_Details_for_checker1.Hide();
            Checked_btn.Hide();
            i = 0;
        }



    }
}
