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
    public partial class Product : Form
    {
        Classes.CLS_Products bs = new Classes.CLS_Products();
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        SqlDataReader dr;
        string title = "المؤسسة المتحدة لتكيف";
        public Product()
        {
            InitializeComponent();
            //this.dgvProducts.DataSource = bs.loadproducts();
            loadprod();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadprod();
            //DataTable dataTable = new DataTable();
            //dataTable = bs.SearchProducts(txtSearch.Text);
            //this.dgvProducts.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    if (MessageBox.Show("هل تريد حذف المنتج المجدد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string prodId = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                        //string query = "Sp_deleteProduct";
                        //SqlCommand cmd = new SqlCommand(query, cn);
                        //cmd.CommandType = CommandType.StoredProcedure;


                        //SqlParameter param = new SqlParameter();
                        //param = new SqlParameter("@Product_id", SqlDbType.VarChar,50);
                        //param.Value = dgvProducts.CurrentRow.Cells[1].Value.ToString();

                        //cmd.Parameters.Add(param);
                        string query = " update tblProduct set pf_status = 0 where Product_id ='" + prodId + "'";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم حذف المنتج بنجاح", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // this.dgvProducts.DataSource = bs.loadproducts();
                        loadprod();
                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عملية الحذف","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        #region method
        public void loadprod()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                int i = 0;
                dgvProducts.Rows.Clear();
                string query = " select p.fatora_id, p.Product_id,p.product_Name,p.realQTY,p.product_QTY,p.Product_PurchPrice,p.Product_SellPrice ,p.product_total from tblProduct as p where p.pf_status=1 and p.f_status=1 and Fatora_ID+Product_id+product_Name like '%" + txtSearch.Text + "%'";
                SqlCommand cm = new SqlCommand(query, cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvProducts.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(),dr[7].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.UpdateProducts p = new Forms.UpdateProducts();
            p.txtFatId.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
            p.txtID.Text = this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
            p.txtname.Text = this.dgvProducts.CurrentRow.Cells[3].Value.ToString();
            p.txtrealQTY.Text = this.dgvProducts.CurrentRow.Cells[4].Value.ToString();
            p.txtQTY.Text = this.dgvProducts.CurrentRow.Cells[5].Value.ToString();
            p.txtpurch.Text = this.dgvProducts.CurrentRow.Cells[6].Value.ToString();
            p.txtsell.Text = this.dgvProducts.CurrentRow.Cells[7].Value.ToString();
            p.txttotal.Text = this.dgvProducts.CurrentRow.Cells[8].Value.ToString();
            p.Text = "تحديث المنتج: " + this.dgvProducts.CurrentRow.Cells[2].Value.ToString();
            p.txtFatId.ReadOnly = true;
            p.txtID.ReadOnly = true;
            p.ShowDialog();
            loadprod();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //this.dgvProducts.DataSource = bs.loadproducts();
            txtSearch.Text = "";
            loadprod();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvProducts.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvProducts.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvProducts.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvProducts.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvProducts.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
