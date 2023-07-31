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
    public partial class ProductModules : Form
    {
        public string state = "add";
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        public string fat_id;
        string title = "المؤسسة المتحدة للتكيف";
        public ProductModules(string fatora_ID)
        {
            InitializeComponent();
            fat_id = fatora_ID;
        }

        private void ProductModules_Load(object sender, EventArgs e)
        {
            txtpurch.Enabled = false;
            txtQTY.Enabled = false;
            txtpurch.Enabled = false;
            txtsell.Enabled = false;
            txttotal.Enabled = false;
        }


        public DataTable FatoraNumb()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblFatora", cn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
      

        private void button3_Click(object sender, EventArgs e)
        {  
        }

        public void Clear()
        {
            txtID.Clear();
            txtname.Clear();
            txtpurch.Text = "0";
            txtQTY.Text = "0";
            txtsell.Clear();
            txttotal.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (fat_id == "mohsen")
            {
                txtFatId.Text = FatoraModule.Fatid;
            }
            else
            {
                txtFatId.Text = fat_id;
            }
        }

        private void txtpuch_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtID_Validated(object sender, EventArgs e)
        {

            //if (state == "add")
            //{
            //    Classes.CLS_Products bs = new Classes.CLS_Products();
            //    DataTable dt = new DataTable();
            //    dt = bs.veirfyproductID(txtID.Text);
            //    if (dt.Rows.Count > 0)
            //    {
            //        MessageBox.Show("هذا المنتج قد تم اضافته مسبفا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtID.Text = "";
            //        txtpurch.Enabled = false;
            //        txtQTY.Enabled = false;
            //        txtpurch.Enabled = false;
            //        txtsell.Enabled = false;
            //        txttotal.Enabled = false;
            //    }
            //    else
            //    {
            //        txtpurch.Enabled = true;
            //        txtQTY.Enabled = true;
            //        txtpurch.Enabled = true;
            //        txtsell.Enabled = true;
            //        txttotal.Enabled = true;
            //    }
            //}
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtname_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtpurch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// only allow digit number
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
            //// only allow one decimal 
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtID_Validated_1(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                if (state == "add")
                {
                    SqlDataReader dr;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string quey = "SELECT * FROM tblProduct WHERE Product_id ='" + txtID.Text + "' AND" +
                        " fatora_id = '" + txtFatId.Text + "' AND pf_status = 1 and f_status = 1";
                    SqlCommand cmd = new SqlCommand(quey, cn);
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("هذا المنتج قد تم اضافته مسبقاً في هذة الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Text = "";
                        txtpurch.Enabled = false;
                        txtQTY.Enabled = false;
                        txtpurch.Enabled = false;
                        txtsell.Enabled = false;
                        txttotal.Enabled = false;
                    }
                    else
                    {
                        txtpurch.Enabled = true;
                        txtQTY.Enabled = true;
                        txtpurch.Enabled = true;
                        txtsell.Enabled = true;
                        txttotal.Enabled = true;
                    }
                    cn.Close();
                    dr.Close();
                }
            }
        }

        private void txtFatId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtQTY_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtpurch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
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

        private void txtpurch_Validated(object sender, EventArgs e)
        {

        }

        private void txtpurch_TextChanged(object sender, EventArgs e)
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
                    txtpurch.Text = "0";
                    txtQTY.Text = "0";
                    txtsell.Clear();
                    txttotal.Clear();
                }
            }
            catch(Exception ex)
            {
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    if (txtID.Text == "" || txtname.Text == "" || txtQTY.Text == "" || txtpurch.Text == "" || txtFatId.Text == "")
                    {
                        MessageBox.Show("قم بادخال البيانات ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query = "InsertProduct";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] param = new SqlParameter[8];

                        param[0] = new SqlParameter("@Fatora_ID", SqlDbType.VarChar, 50);

                        if (fat_id == "mohsen")
                        {
                            param[0].Value = FatoraModule.Fatid;
                            txtFatId.Text = FatoraModule.Fatid;
                        }
                        else
                        {
                            param[0].Value = fat_id;
                            txtFatId.Text = fat_id;
                        }
                        param[1] = new SqlParameter("@Product_id", SqlDbType.VarChar, 50);
                        param[1].Value = txtID.Text;

                        param[2] = new SqlParameter("@product_Name", SqlDbType.VarChar, 100);
                        param[2].Value = txtname.Text;

                        param[3] = new SqlParameter("@product_QTY", SqlDbType.Int);
                        param[3].Value = txtQTY.Text;

                        param[4] = new SqlParameter("@realQTY", SqlDbType.Int);
                        param[4].Value = txtQTY.Text;

                        param[5] = new SqlParameter("@Product_PurchPrice", SqlDbType.VarChar, 100);
                        param[5].Value = txtpurch.Text;

                        param[6] = new SqlParameter("@Product_SellPrice", SqlDbType.VarChar, 100);
                        param[6].Value = txtsell.Text;

                        param[7] = new SqlParameter("@product_total", SqlDbType.VarChar, 100);
                        param[7].Value = txttotal.Text;

                        string fat_ID = param[0].Value.ToString();
                        string prod_ID = param[0].Value.ToString();

                        cmd.Parameters.AddRange(param);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("تمت الاضافة بنجاح", title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        string query2 = "insert into tblFatoraItem(Fatora_id,Product_id)values(" + txtFatId.Text + "," + txtID.Text + ")";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cn.Open();
                        cmd2.ExecuteNonQuery();
                        cn.Close();
                        Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
