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
    public partial class SignUpControl : UserControl
    {
        Account user = new Account();//Created an object of the class "Account"
        public SignUpControl()
        {
            InitializeComponent();
            CivilIdNote_Lbl.Hide();
            CivilId_Lbl.Hide();
            DriverCivilID_txt.Hide();
            CookWorkingHours_txt.Hide();
            WorkingHours_Lbl.Hide();
        }
        string gender; //To be able to put a string value into database

        private void Driver_CheckedChanged(object sender, EventArgs e)
        {
            if (Driver_Rb.Checked)
            {
                CivilIdNote_Lbl.Show();
                CivilId_Lbl.Show();
                DriverCivilID_txt.Show();
;            }
            else
            {
                CivilIdNote_Lbl.Hide();
                CivilId_Lbl.Hide();
                DriverCivilID_txt.Hide();
            }

        }

        private void Cook_CheckedChanged(object sender, EventArgs e)
        {
            if (Cook_Rb.Checked)
            {
                CookWorkingHours_txt.Show();
                WorkingHours_Lbl.Show();               
            }
            else
            {
                CookWorkingHours_txt.Hide();
                WorkingHours_Lbl.Hide();
            }
        }

        private void SignUp_bt_Click(object sender, EventArgs e)
        {

            if (FullName_txt.Text == "" || UserName_txt.Text == "" || Password_txt.Text == "" || Address_txt.Text == "" || PhoneNumber_txt.Text == "" || (GenderMale.Checked == false && GenderFemale.Checked == false) || (Cook_Rb.Checked == false && Driver_Rb.Checked == false && Checker_Rb.Checked == false && Customer_Rb.Checked == false) || (Driver_Rb.Checked == true && DriverCivilID_txt.Text=="") || (Cook_Rb.Checked == true && CookWorkingHours_txt.Text== ""))
                MessageBox.Show("Please enter all information", "Error to Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Passing the entered data into the object data members
                try
                {
                    user.FullName = FullName_txt.Text;
                    user.UserName = UserName_txt.Text;
                    user.Password = Password_txt.Text;
                    user.PhoneNumber = Convert.ToInt32(PhoneNumber_txt.Text);
                    user.Address = Address_txt.Text;

                    //This statments for passing a string value for the gender because we can't send a boolean value to the database
                    if (GenderMale.Checked == true)
                        gender = "Male";
                    else
                        gender = "Female";

                    user.Gender = gender;

                    if (Cook_Rb.Checked == true)
                    {
                        user.Acc_Type = "Cook";
                        user.Cook_WorkingHours = CookWorkingHours_txt.Text;
                    }
                    else if (Customer_Rb.Checked == true)
                        user.Acc_Type = "Customer";
                    else if (Driver_Rb.Checked == true)
                    {
                        user.Acc_Type = "Driver";
                        user.Driver_CivilId = DriverCivilID_txt.Text;

                    }
                    else if (Checker_Rb.Checked == true)
                        user.Acc_Type = "Checker";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured! Please fill your data accurately." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                //Checking if the entered username is existed
                if (user.Is_data_Existed())
                    MessageBox.Show("Username is already existed! Please enter another one.", "Username is existed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // A try-catch statment for avoiding the runtime errors and program crashing
                    try
                    {
                        //Passing the (modified) entered data into the object data members again
                        user.FullName = FullName_txt.Text;
                        user.UserName = UserName_txt.Text;
                        user.Password = Password_txt.Text;
                        user.PhoneNumber = Convert.ToInt32(PhoneNumber_txt.Text);
                        user.Address = Address_txt.Text;


                        if (GenderMale.Checked == true)
                            gender = "Male";
                        else
                            gender = "Female";

                        user.Gender = gender;

                        if (Cook_Rb.Checked == true)
                        {
                            user.Acc_Type = "Cook";
                            user.Cook_WorkingHours = CookWorkingHours_txt.Text;
                        }
                        else if (Customer_Rb.Checked == true)
                            user.Acc_Type = "Customer";
                        else if (Driver_Rb.Checked == true)
                        {
                            user.Acc_Type = "Driver";
                            user.Driver_CivilId = DriverCivilID_txt.Text;

                        }
                        else if (Checker_Rb.Checked == true)
                            user.Acc_Type = "Checker";

                        //Insterting the registration data into database
                        string Reg_Done = user.Insert_Reg_Data();
                        DialogResult result = MessageBox.Show(Reg_Done, "Successful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {                           
                            FullName_txt.Text = "";
                            UserName_txt.Text = "";
                            Password_txt.Text = "";
                            PhoneNumber_txt.Text = "";
                            Address_txt.Text = "";
                            DriverCivilID_txt.Text = "";
                            CookWorkingHours_txt.Text = "";
                            GenderMale.Checked = false;
                            GenderFemale.Checked = false;
                            Driver_Rb.Checked = false;
                            Customer_Rb.Checked = false;
                            Cook_Rb.Checked = false;
                            Checker_Rb.Checked = false;
                        }
                    }
                    catch (Exception ex)       //what will happen if there is a run time error,instead of stopping the application
                    {
                        MessageBox.Show("An error has occured! Please fill your data accurately." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally    //what will happen after "try" or "catch"
                    {
                        user.con.Close();
                    }
                }
            }
        }

        private void SignUpControl_VisibleChanged(object sender, EventArgs e) //to clear all the fields so when it loads again it will not contain old data
        {
            FullName_txt.Text = "";
            UserName_txt.Text = "";
            Password_txt.Text = "";
            Address_txt.Text = "";
            PhoneNumber_txt.Text = "";
            DriverCivilID_txt.Text = "";
            CookWorkingHours_txt.Text = "";
            GenderMale.Checked = false;
            GenderFemale.Checked = false;
            Customer_Rb.Checked = false;
            Driver_Rb.Checked = false;
            Cook_Rb.Checked = false;
            Checker_Rb.Checked = false;
        }

        private void customImageButton1_Click(object sender, EventArgs e)
        {
        }

        private void customImageButton1_MouseHover(object sender, EventArgs e)
        {
            Password_txt.PasswordChar = '\0';
            
        }

        private void customImageButton1_MouseLeave(object sender, EventArgs e)
        {
            Password_txt.PasswordChar = '*';

        }
    }
}
