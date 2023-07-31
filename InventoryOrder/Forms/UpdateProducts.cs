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
    public partial class UpdateProducts : Form
    {
        bool check = false;
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;

        public UpdateProducts()
        {
            InitializeComponent();
        }

        #region methods
        public void checkField()
        {
            if (txtsell.Text == "" || txtID.Text == "" || txtname.Text == "" || txtpurch.Text == "" || txtQTY.Text == ""||txttotal.Text=="")
            {
                MessageBox.Show("قم بادخال البيانات", "خطأ");
                return; // return to the data field and form
            }

            check = true;
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    checkField();
                    if (check)
                    {
                        string query = "Sp_UpdateProduct";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter[] param = new SqlParameter[8];

                        param[0] = new SqlParameter("@fatora_id", SqlDbType.VarChar,50);
                        param[0].Value = txtFatId.Text;

                        param[1] = new SqlParameter("@Product_id", SqlDbType.VarChar, 50);
                        param[1].Value = txtID.Text;

                        param[2] = new SqlParameter("@product_Name", SqlDbType.NVarChar, 100);
                        param[2].Value = txtname.Text;

                        param[3] = new SqlParameter("@realQTY", SqlDbType.Int);
                        param[3].Value = txtrealQTY.Text;

                        param[4] = new SqlParameter("@product_QTY",SqlDbType.Int);
                        param[4].Value = txtQTY.Text;

                        param[5] = new SqlParameter("@Product_PurchPrice", SqlDbType.VarChar, 100);
                        param[5].Value = txtpurch.Text;

                        param[6] = new SqlParameter("@Product_SellPrice", SqlDbType.VarChar, 100);
                        param[6].Value = txtsell.Text;

                        param[7] = new SqlParameter("@product_total", SqlDbType.VarChar,100);
                        param[7].Value = txttotal.Text;

                        cmd.Parameters.AddRange(param);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("تم التعديل بنجاح", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        Classes.CLS_Products bs = new Classes.CLS_Products();
                        bs.loadproducts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }

        }

        private void txtpurch_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void txtQTY_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtpurch.Text != "" || txtQTY.Text != "")
                {
                    double purch = double.Parse(txtpurch.Text);
                    int qty = int.Parse(txtQTY.Text);
                    txtsell.Text = (purch + (purch * 0.14)).ToString();
                    txttotal.Text = (purch * qty).ToString();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ادخل الكمية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpurch_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtpurch.Text != "" || txtQTY.Text != "")
                {
                    double purch = double.Parse(txtpurch.Text);
                    int qty = int.Parse(txtQTY.Text);
                    txtsell.Text = (purch + (purch * 0.14)).ToString();
                    txttotal.Text = (purch * qty).ToString();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ادخل السعر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtpurch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow digit number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
