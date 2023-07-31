using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryOrder.Forms
{
    public partial class FatoraModule : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        public static string Fatid;
        public FatoraModule()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtfatoraid.Text == "")
            {
                MessageBox.Show("قم باضافة رقم الفاتورة","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(CS))
                {
                    string query = "InsertFatora";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] param = new SqlParameter[3];

                    param[0] = new SqlParameter("@Fatora_ID", SqlDbType.VarChar, 50);
                    param[0].Value = txtfatoraid.Text;

                    param[1] = new SqlParameter("@Fatora_Date", SqlDbType.DateTime);
                    param[1].Value = datefatoradate.Value;

                    param[2] = new SqlParameter("@message", SqlDbType.VarChar, 50);
                    param[2].Direction = System.Data.ParameterDirection.Output;

                    cmd.Parameters.AddRange(param);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    Fatid = txtfatoraid.Text;

                    string msg = param[2].Value.ToString();
                    if (msg == "Done!")
                    {
                        MessageBox.Show("تمت الاضافة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Forms.Fatora f = new Forms.Fatora();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("خطأ في الادخال", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtfatoraid_Validated(object sender, EventArgs e)
        {
            Classes.CLS_Fatora bs = new Classes.CLS_Fatora();
            DataTable dt = new DataTable();
            dt = bs.veirfyFatoraID(txtfatoraid.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("قد تم ادخال هذا الرقم مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfatoraid.Text = "";
            }
        }

        private void txtfatoraid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtfatoraid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
