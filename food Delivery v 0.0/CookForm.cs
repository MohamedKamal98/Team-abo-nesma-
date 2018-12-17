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
    public partial class CookForm : Form
    {
        public CookForm()
        {
            InitializeComponent();
            cook_Menu1.Hide();
            cook_Requests1.Hide();
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

        private void BackBt_Click(object sender, EventArgs e)
        {
            cook_Menu1.Show();
        }

        private void BackBt2_Click(object sender, EventArgs e)
        {
            cook_Menu1.Hide();
        }

        private void ShowReq_bt_Click(object sender, EventArgs e)
        {
            cook_Requests1.Show();
        }
    }
}
