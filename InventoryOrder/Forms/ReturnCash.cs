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
    public partial class ReturnCash : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        string repID;
        string title = "المؤسسة المتحدة للتكيف";
        public ReturnCash(string clientiD)
        {
            InitializeComponent();
            repID = clientiD;
            loadCashClient();
            lblrep.Text = repID;

        }

        public void loadCashClient()
        {

            using (SqlConnection cn = new SqlConnection(CS))
            {
                if (txtprodid.Text != "")
                {
                    int i = 0;
                    string query = "SELECT sdate, fatora_id, product_id, QTY, price, total FROM dbo.tblCash WHERE out_ClientReportnumb = '" + repID + "' AND " +
                        "convert(date,sdate) BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "' AND product_id = '" + txtprodid.Text + "'";

                    //string query = "SELECT p.Product_id,p.product_Name,p.realQTY,p.product_QTY,p.Product_PurchPrice ,p.Product_SellPrice,p.product_total FROM tblProduct AS p where p.Fatora_id = '" + fatID + "'";
                    SqlCommand cm = new SqlCommand(query, cn);
                    dgvReturn.Rows.Clear();
                    cn.Open();
                    SqlDataReader dr;
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i++;
                        dgvReturn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
                else
                {
                    int i = 0;
                    string query = "SELECT sdate, fatora_id, product_id, QTY, price, total FROM dbo.tblCash WHERE out_ClientReportnumb = '" + repID + "' AND " +
                        "convert(date,sdate) BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "'";

                    //string query = "SELECT p.Product_id,p.product_Name,p.realQTY,p.product_QTY,p.Product_PurchPrice ,p.Product_SellPrice,p.product_total FROM tblProduct AS p where p.Fatora_id = '" + fatID + "'";
                    SqlCommand cm = new SqlCommand(query, cn);
                    dgvReturn.Rows.Clear();
                    cn.Open();
                    SqlDataReader dr;
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i++;
                        dgvReturn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvReturn.Columns[e.ColumnIndex].Name;
            if (colName == "print")
            {
                Damaged d = new Damaged();
                d.txtReport.Text = lblrep.Text;
                d.txtFatoraid.Text = this.dgvReturn.CurrentRow.Cells[2].Value.ToString();
                d.txtProductid.Text = this.dgvReturn.CurrentRow.Cells[3].Value.ToString();
                d.Text = "تلفيات لرقم بلاغ:" + this.dgvReturn.CurrentRow.Cells[1].Value.ToString();

                d.txtProductid.ReadOnly = true;
                d.txtFatoraid.ReadOnly = true;
                d.txtReport.ReadOnly = true;
                d.ShowDialog();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReturn.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvReturn.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvReturn.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvReturn.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvReturn.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvReturn.Rows[i].Cells[j].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            loadCashClient();
        }
    }
}
