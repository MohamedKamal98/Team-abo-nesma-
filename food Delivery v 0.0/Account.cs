using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace food_Delivery_v_0._0
{

    class Account
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CEO0JJM\KAMAL1;Initial Catalog=is_project;Integrated Security=True");
        public  SqlCommand cmd;
        public SqlDataReader sdr;

        //Users data
        public String FullName;
        public String UserName;
        public String Password;
        public String Address;
        public String Gender;
        public int PhoneNumber;
        public String Acc_Type;
        public String Driver_CivilId;
        public String Cook_WorkingHours;

        //Function for pushing data into database tables
        public String Insert_Reg_Data()
        {
            if (Acc_Type == "Cook")
            {
                cmd = new SqlCommand("insert into Cooks(FullName,Username,Password,Gender,phone,Address,isworking) values('" +FullName+ "','" + UserName + "','" + Password + "','" + Gender + "','" + PhoneNumber + "','" + Address + "','" + Cook_WorkingHours + "')",con);
                con.Open(); //opens connection
                cmd.ExecuteNonQuery(); //excutes the command
                con.Close(); //closes connection  
            }
            else if (Acc_Type == "Customer")
            {
                cmd = new SqlCommand("insert into Customer(Username,FullName,Password,Phone,Address,Gender) values('" + UserName + "', '" + FullName + "' ,'" + Password + "','" + PhoneNumber + "','" + Address + "','" + Gender + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (Acc_Type == "Driver")
            {
                cmd = new SqlCommand("insert into Driver(Username,FullName,Password,Civil_ID,Phone,Address,Gender,isdriving) values('" + UserName + "', '" + FullName + "' ,'" + Password + "', '"+ Driver_CivilId +"' ,'" + PhoneNumber + "','" + Address + "','"+Gender+"',0)", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (Acc_Type == "Checker")
            {
                cmd = new SqlCommand("insert into Checker(Username,FullName,Password,Phone,Address,Gender) values('" + UserName + "', '" + FullName + "' ,'" + Password + "','" + PhoneNumber + "','" + Address + "','"+ Gender +"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            return "You have been registered successfully! Now you can sign in.";
        }

        //Function for checking if the current entered username is already existed
        public bool Is_data_Existed()
        {
            SqlDataAdapter Cooks_sda = new SqlDataAdapter("SELECT * FROM Cooks WHERE Username='"+UserName+"' ",con);  //SqlDataAdapter is responsible of filling a new data table
            SqlDataAdapter Customer_sda = new SqlDataAdapter("SELECT * FROM Customer WHERE Username='" + UserName + "' ", con);
            SqlDataAdapter Driver_sda = new SqlDataAdapter("SELECT * FROM Driver WHERE Username='" + UserName + "' ", con);
            SqlDataAdapter Checker_sda = new SqlDataAdapter("SELECT * FROM Checker WHERE Username='" + UserName + "' ", con);
            DataTable dt = new DataTable(); //A new data table to put the username's data in (if existed)
            Cooks_sda.Fill(dt); //Filling the data table with the username's data (if existed)
            Customer_sda.Fill(dt);
            Driver_sda.Fill(dt);
            Checker_sda.Fill(dt);

            if (dt.Rows.Count == 1) //If no. of rows = 1 , it means that there is a username in the database similar to the one that was entered
                return true;
            else
                return false;            
        }

        //Function for checking if a meal is already existed
        public bool check_meal(int Meal_id)
        {
            bool reply;
            con.Open();
            cmd = new SqlCommand("select * from Menu  where meal_ID='" + Meal_id + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();

             if(RD.Read())
            {
                string x = RD["checked"].ToString();
                if (x == "1")
                {
                    MessageBox.Show("Meal has been checked !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    reply= false;
                }
                else reply= true;
            }
    
           else if (!RD.Read())
            {
                MessageBox.Show("Meal Does Not Exist !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                reply= false;
            }
            else
            {
                con.Close();
                reply= true;
            }
             con.Close();
             if (reply) return true;
             else return false;
        }

        //Function for checking if a request is already existed
        public bool check_requested(int Meal_id)
        {
            con.Open();
            cmd = new SqlCommand("select * from check_request  where meal_ID='" + Meal_id + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();

            if (RD.Read())
            {
                MessageBox.Show("This requist has been send !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return true;
            }

            else
            {
                con.Close();
                return false;
            }
        }

        public void done_request(string meal_id)
        {
            cmd = new SqlCommand("UPDATE Menu set Checker_ID='"+SignInControl.checker_username+"',checked='"+1+ "' where meal_id='" + Convert.ToInt32(meal_id) + "' delete from check_request where meal_id='" + Convert.ToInt32(meal_id) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}