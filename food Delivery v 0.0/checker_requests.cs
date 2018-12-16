using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food_Delivery_v_0._0
{
    public partial class checker_requests : UserControl
    {
        Account user = new Account();
        public checker_requests()
        {
            InitializeComponent();
            mealname_lbl.ForeColor = Color.Black;

        }

        private void mealname_lbl_Click(object sender, EventArgs e)
        {
            if (mealname_lbl.Text != "Checked")
            {
                user.done_request(mealname_lbl.Text);
                mealname_lbl.Text = "Checked";
                mealname_lbl.ForeColor = Color.Green;
            }
        }
        public void put(string meal_id)
        {
            mealname_lbl.Text = meal_id;
        }
    }
}
