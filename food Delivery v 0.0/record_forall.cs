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
    public partial class record_forall : UserControl
    {
        public record_forall()
        {
            InitializeComponent();
        }
        Account user = new Account();
        public void put(string un, string fn, string g, string p)
        {
            usern_lbl.Text = un;
            full_lbl.Text = fn;
            ph_lbl.Text = p;
            gen_lbl.Text = g;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (fire.take == "Cooks")
            {
                DialogResult d = MessageBox.Show("Do you want to fire this worker", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete from Cooks where Username='" + usern_lbl.Text + "'", user.con);
                    user.con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fired successfully :(", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.con.Close();
                }
            }
            else if (fire.take == "Driver")
            {
                DialogResult d = MessageBox.Show("Do you want to fire this worker", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("Delete from Driver where Username='" + usern_lbl.Text + "'", user.con);
                    user.con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fired successfully :(", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.con.Close();
                }
            }

        }

        private void record_forall_Load(object sender, EventArgs e)
        {

        }
    }
}
