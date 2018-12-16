using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_Delivery_v_0._0
{
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
            adminReviews1.BackColor = Color.FromArgb(150, Color.Black);
            adminReviews1.Hide();
            BackBt.Hide();
        }
        User_Controls.AdminRequestToChecker obj = new User_Controls.AdminRequestToChecker();

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void customImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void customImageButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log out ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                WelcomeInterface w = new WelcomeInterface();
                w.Show();
            }
        }

        private void fire_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fire f = new fire();
            f.Show();
            
        }

        private void adminReviewButton_Click_1(object sender, EventArgs e)
        {
            checkerRequestButton.Hide();
            fire_btn.Hide();
            adminReviewButton.Hide();
            BackBt.Show();
            adminReviews1.Show();
        }

        private void checkerRequestButton_Click(object sender, EventArgs e)
        {
            adminReviewButton.Hide();
            fire_btn.Hide();
            checkerRequestButton.Hide();
            BackBt.Show();
            Controls.Add(obj);
            obj.Font = new Font("Microsoft Sans Serif", 8);
            obj.BackColor = Color.FromArgb(150, Color.Black);
            obj.Location = new Point(14, 212);
            obj.Size = new Size(826, 328);
            obj.Margin = new Padding(5, 5, 5, 5);
            obj.Visible = true;


        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            checkerRequestButton.Show();
            fire_btn.Show();
            adminReviewButton.Show();
            BackBt.Hide();
            adminReviews1.Hide();
            obj.Visible = false;
        }
    }
}
