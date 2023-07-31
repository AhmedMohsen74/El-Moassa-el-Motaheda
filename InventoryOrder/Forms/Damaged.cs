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
using System.Configuration;

namespace InventoryOrder.Forms
{
    public partial class Damaged : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;

        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        bool havestoreinfo = false;
        string title = "المؤسسة المتحدة للتكيف";
        public Damaged()
        {
            InitializeComponent();
            txtCode.ReadOnly = true;
            txtname.ReadOnly = true;
            LoadStore();
            this.ActiveControl = txtReport;
        }

        public void LoadStore()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("SELECT * FROM tblStore", cn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        havestoreinfo = true;
                        txtCode.Text = dr["S_id"].ToString();
                        txtname.Text = dr["S_name"].ToString();
                    }
                    else
                    {
                        txtCode.Clear();
                        txtname.Clear();
                    }
                    dr.Close();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtProductid.Text == "" || txtReport.Text == "" || txtFatoraid.Text == "") 
            {
                MessageBox.Show("ثم بإدخال بيانات","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DamgedSticker report = new DamgedSticker(this);
                report.LoadDamgedSticker();
                report.ShowDialog();
            }
        }

        private void txtReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFatoraid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtProductid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
