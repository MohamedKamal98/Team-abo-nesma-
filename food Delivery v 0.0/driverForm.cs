﻿using System;
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
    public partial class driverForm : Form
    {
        Account user = new Account();
        public string Customer;
        public driverForm()
        {
            InitializeComponent();

            user.con.Open();
            SqlCommand cmd = new SqlCommand("select Order_id from Order_Record", user.con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    ordersCombobox.Items.Add(dataReader.GetInt32(0));
                }
            }
            dataReader.Close();
            user.con.Close();
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

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void ordersCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            string orderId = ordersCombobox.SelectedItem.ToString();
            user.con.Open();
            SqlCommand cmd = new SqlCommand("select CustomerUsername,CookUsername,Order_Details,MealName,quantity from Order_Record where Order_id = '" + orderId + "'", user.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                 Customer = dr.GetString(0);
                string Cook = dr.GetString(1);
                string Order_Details = dr.GetString(2);
                string MealName = dr.GetString(3);
                int quantity = Int32.Parse(dr.GetString(4));
                customerTxt.Text = Customer;
                cookTxt.Text = Cook;
                orderDetailsTxt.Text = Order_Details;
                mealNameTxt.Text = MealName;
                quantityTxt.Text = quantity.ToString();
            }
            dr.Close();
            SqlCommand cd = new SqlCommand("select FullName,Phone,Address,Gender from Customer where Username = '" + Customer+"'", user.con);
            SqlDataReader d = cmd.ExecuteReader();
            if (d.HasRows)
            {
                d.Read();
                string Fullname = d.GetString(0);
                string Phone = d.GetString(1);
                string Address = d.GetString(2);
                string Gender = d.GetString(3);
                customerFullNametxt.Text = Fullname;
                phoneTxt.Text = Phone.ToString();
                addressTxt.Text = Address;
                gendertxt.Text = Gender;
            }
            d.Close();
            user.con.Close();
            groupBox1.Show();
            groupBox2.Show();
        }

        private void deliverOrderButton_Click(object sender, EventArgs e)
        {
            
            user.con.Open();
            SqlCommand cmd = new SqlCommand("Update Driver set isdriving = 1 where '"+ SignInControl.DriverUsername + "' = 'aa'; ", user.con);
            user.con.Close();

        }
    }
}
