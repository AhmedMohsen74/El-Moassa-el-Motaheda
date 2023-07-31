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
    public partial class Record : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        SqlDataReader dr;
        public Record()
        {
            InitializeComponent();
        }

        private void btnLoadCancel_Click(object sender, EventArgs e)
        {

        }
        public void LoadSoldItems()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    dgvSoldItems.Rows.Clear();
                    int i = 0;
                    cn.Open();

                    string query = "SELECT p.fatora_id, c.product_id, p.product_Name, c.price, sum(c.QTY) AS qty ,SUM(c.total) AS Total " +
                        "FROM tblCash AS c INNER JOIN tblProduct AS p ON c.product_id = p.Product_id" +
                        " WHERE C_Status LIKE 'Sold' AND convert(date,sdate) BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "'" +
                        " GROUP BY p.fatora_id, c.product_id , p.product_Name, c.price";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        i++;
                        dgvSoldItems.Rows.Add(i, dr["fatora_id"].ToString(), dr["product_id"].ToString(), dr["product_Name"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,##0.00"), dr["qty"].ToString(), double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                    }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cmd = new SqlCommand("SELECT ISNULL(SUM(total),0) FROM tblCash WHERE C_Status LIKE 'Sold' AND convert(date,sdate) BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "'", cn);
                    lblTotal.Text = double.Parse(cmd.ExecuteScalar().ToString()).ToString("#,##0.00");
                    cn.Close();
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
        

        private void btnLoadSoldItems_Click_2(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        private void btnPrintSoldItems_Click(object sender, EventArgs e)
        {
            Reports report = new Reports("");
            string param = "From : " + dtFromSoldItems.Value.ToString() + " To : " + dtToSoldItems.Value.ToString();

            string query = "SELECT p.fatora_id, c.product_id, p.product_Name, c.price, sum(c.QTY) AS qty ,SUM(c.total) AS Total " +
                        "FROM tblCash AS c INNER JOIN tblProduct AS p ON c.product_id = p.Product_id" +
                        " WHERE C_Status LIKE 'Sold' AND convert(date,sdate) BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "'" +
                        " GROUP BY p.fatora_id, c.product_id , p.product_Name, c.price";

            //string query = "SELECT * FROM vSoldItems WHERE C_Status LIKE 'Sold' AND sdate BETWEEN '" + dtFromSoldItems.Value.ToString() + "' AND '" + dtToSoldItems.Value.ToString() + "'GROUP BY p.fatora_id, c.product_id , p.product_Name, c.price";

            report.LoadSoldItems(query, param);
            report.ShowDialog();
        }
    }
}
