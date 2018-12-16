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
    public partial class WelcomeInterface : Form
    {

        public WelcomeInterface()
        {
            InitializeComponent();
            label6.BackColor = Color.FromArgb(150, Color.Black);
            label7.BackColor = Color.FromArgb(150, Color.Black);
            SignUpControl.BackColor = Color.FromArgb(150, Color.Black);
            SignUpControl.Hide();
            BackBt.Hide();
            SignInControl.BackColor = Color.FromArgb(150, Color.Black);
            SignInControl.Hide();
        }

        private void regButton_Click(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {

        }

        //Slider
        private int Img_Num = 1;
        private void Load_Next_Img()
        {
            if (Img_Num == 4)
                Img_Num = 1;

            Slider_Pic.ImageLocation = string.Format(@"Images\{0}.png", Img_Num);
            Img_Num++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Load_Next_Img();
        }

        private void circularButton1_MouseEnter(object sender, EventArgs e)
        {
            SignInButton.BackColor = Color.MediumSeaGreen;
        }

        private void circularButton1_MouseLeave(object sender, EventArgs e)
        {
            SignInButton.BackColor = Color.Transparent;
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

        }

        private void customImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void WelcomeInterface_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.BLEND);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignUpControl.Hide();
            label6.Hide();
            label7.Hide();
            bunifuTransition1.ShowSync(SignInControl);
            BackBt.Show();
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
            SignInControl.Hide();
            label6.Hide();
            label7.Hide();
            bunifuTransition1.ShowSync(SignUpControl);
            BackBt.Show();
        }

        private void customImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SignUpControl.Hide();
            SignInControl.Hide();
            BackBt.Hide();
            label6.Show();
            label7.Show();
        }

        private void signUpControl1_Load(object sender, EventArgs e)
        {

        }

        private void Back_bt_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            SignUpControl.Hide();
            SignInControl.Hide();
            BackBt.Hide();
            label6.Show();
            label7.Show();
        }

        private void Slider_Pic_Click(object sender, EventArgs e)
        {

        }
    }
}
