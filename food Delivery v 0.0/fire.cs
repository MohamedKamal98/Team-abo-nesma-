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
using food_Delivery_v_0._0.User_Controls;

namespace food_Delivery_v_0._0
{
    public partial class fire : Form
    {
        Account user = new Account();
        public fire()
        {
            InitializeComponent();
            groupBox1.BackColor = Color.FromArgb(150, Color.Black);

        }
        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public static string take;
        private void button11_Click(object sender, EventArgs e)
        {
            if (cookRadiobox.Checked)
            {
                take = "Cooks";
                flowLayoutPanel1.Controls.Clear();
                SqlCommand cmd = new SqlCommand("Select * from Cooks", user.con);
                //MessageBox.Show(fire.take);
                user.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    panel2.Show();
                    flowLayoutPanel1.Show();
                    record_forall us = new record_forall();
                    us.put(dr["Username"].ToString(), dr["FullName"].ToString(), dr["Gender"].ToString(), dr["phone"].ToString());
                    flowLayoutPanel1.Controls.Add(us);
                }
                dr.Close();
                user.con.Close();

            }
            else if (driverRadiobox.Checked)
            {
                take = "Driver";

                flowLayoutPanel1.Controls.Clear();
                SqlCommand cmd = new SqlCommand("Select * from Driver", user.con);
                //MessageBox.Show(fire.take);
                user.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    panel2.Show();
                    flowLayoutPanel1.Show();
                    record_forall us = new record_forall();
                    us.put(dr["Username"].ToString(), dr["FullName"].ToString(), dr["Gender"].ToString(), dr["phone"].ToString());
                    flowLayoutPanel1.Controls.Add(us);
                }
                dr.Close();
                user.con.Close();
            }
        }

        private class Record
        {
            public Record()
            {
            }

            internal void put(string v1, string v2, string v3, string v4)
            {
                throw new NotImplementedException();
            }
        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fire_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void customImageButton2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_form a = new Admin_form();
            a.Show();
        }
    }
}
