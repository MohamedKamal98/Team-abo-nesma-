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
    public partial class MakeorderUsercontrol : UserControl
    {
        Account user = new Account();
        int mealId = 0;
        Button btn1;
        Button btn2;
        public MakeorderUsercontrol(Button order, Button track)
        {
            InitializeComponent();
            btn1 = order;
            btn2 = track;
            //read from database all required data
            try
            {
                user.con.Open();
                string query = "select Username from Cooks";
                SqlCommand cmd = new SqlCommand(query, user.con);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        chiefsCombobox.Items.Add(dataReader.GetString(0));
                    }
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                user.con.Close();
            }
            groupBox1.Visible = false;
        }

        private void chiefsCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            //mealNameLabel.Text = null;
            //MealDiscriptionLabel.Text = null;
            //priceLabel.Text = null;
            //rateLabel.Text = null;
            menuListbox.Items.Clear();
            quantityTextbox.Text = null;
            string chiefName = chiefsCombobox.SelectedItem.ToString();
            //MessageBox.Show(chiefName);
            try
            {
                user.con.Open();
                if(chiefName == "Chief")
                    MessageBox.Show("Chiefs selection error", "Please select a chief from chiefs menu to view his menu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string mealSelectQuery = "select MealName from Menu where CookUsername = '" + chiefName + "'";
                    SqlCommand cmd = new SqlCommand(mealSelectQuery, user.con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.HasRows)
                    {
                        while(dr.Read())
                        {
                            menuListbox.Items.Add(dr.GetString(0));
                        }
                    }
                    dr.Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                user.con.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(meal);
            try
            {
                user.con.Open();
                string meal = menuListbox.SelectedItem.ToString();
                string MealDetailsQuery = "select price, Meal_Details, rate, meal_ID from Menu where MealName = '" + meal + "'";
                SqlCommand cmd = new SqlCommand(MealDetailsQuery, user.con);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    dr.Read();
                    float mealPrice = (float) dr.GetDouble(0);
                    string mealDescription = dr.GetString(1);
                    float mealRate = (float)dr.GetDouble(2);
                    mealId = Int32.Parse(dr[3].ToString());
                  //MessageBox.Show(mealId.ToString());
                  //MessageBox.Show(mealPrice.ToString() + ' ' + mealDescription + ' ' + mealRate.ToString());
                    mealNameLabel.Text = meal;
                    MealDiscriptionLabel.Text = mealDescription;
                    priceLabel.Text = mealPrice.ToString();
                    rateLabel.Text = mealRate.ToString();
                }
                dr.Close();
                quantityTextbox.Text = "1";
                groupBox1.Visible = true;
            }
            catch (System.NullReferenceException err)
            {
                //MessageBox.Show(err.ToString());
            }
            finally
            {
                user.con.Close();
            }
        }
        DataTable table = new DataTable();
        private void MakeorderUsercontrol_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Meal Name", typeof(string));
            table.Columns.Add("Chief", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Price", typeof(float));

            OrderDataGridView.DataSource = table;
            OrderDataGridView.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (menuListbox.SelectedIndex < 0 || quantityTextbox.Text == null || chiefsCombobox.Text == "Chiefs")
                {
                    MessageBox.Show("Please choose an item");
                }
                else
                {
                    float price = float.Parse(priceLabel.Text) * float.Parse(quantityTextbox.Text);
                    table.Rows.Add(mealNameLabel.Text, chiefsCombobox.SelectedItem.ToString(), float.Parse(quantityTextbox.Text), price);
                    OrderDataGridView.DataSource = table;
                    OrderDataGridView.Visible = true;
                    removeButton.Visible = true;
                    checkoutButton.Visible = true;
                    float total = 0;
                    for (int i = 0; i < OrderDataGridView.Rows.Count; i++)
                    {
                        DataGridViewRow selectedRow = OrderDataGridView.Rows[i];
                        total += float.Parse(selectedRow.Cells[3].Value.ToString());
                    }
                    totalCost.Visible = true;
                    totalCost.Text = total.ToString();
                }
            }
            catch(System.NullReferenceException)
            {

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int rowIndex = OrderDataGridView.CurrentCell.RowIndex;
            OrderDataGridView.Rows.RemoveAt(rowIndex);
            if (OrderDataGridView.Rows.Count == 0)
            {
                OrderDataGridView.Visible = false;
                removeButton.Visible = false;
                checkoutButton.Visible = false;
                totalCost.Visible = false;
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.Month.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Second.ToString();
            MessageBox.Show(date);
            try
            {
                int rowsNum = OrderDataGridView.Rows.Count;
                //user.cmd = new System.Data.SqlClient.SqlCommand("select Order from Order_Record where Order_id = 0", user.con);
                //user.cmd 
                for (int i = 0; i < rowsNum; i++)
                {
                    DataGridViewRow selectedRow = OrderDataGridView.Rows[i];
                    string CustomerUsername = SignInControl.customerUsername;
                    string mealname = selectedRow.Cells[0].Value.ToString();
                    string CookUsername = selectedRow.Cells[1].Value.ToString();
                    int quantity = Int32.Parse(selectedRow.Cells[2].Value.ToString());
                    user.cmd = new System.Data.SqlClient.SqlCommand("insert into Order_Record(meal_id, MealName, CookUsername, quantity, CustomerUsername, driverUsername, isDelivered, isPrepared, serial) values('" + mealId + "','" + mealname + "','" + CookUsername + "','" + quantity + "','" + CustomerUsername + "' , 'no driver' , 0, 0, '" + date + "')", user.con);
                    user.con.Open();
                    user.cmd.ExecuteNonQuery();
                    user.con.Close();
                }
                MessageBox.Show("Successful order", "Order is checked out succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }            
            this.Hide();
            btn1.Visible = true;
            btn2.Visible = true;
        }
    }
}