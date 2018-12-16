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

namespace food_Delivery_v_0._0.User_Controls
{
    public partial class show_all : UserControl
    {
        Account user = new Account();
        public show_all()
        {
            InitializeComponent();
        }
    
        private void show_all_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlCommand cmd = new SqlCommand("Select * from '"+fire.take+"'", user.con);
            MessageBox.Show(fire.take);
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
}
