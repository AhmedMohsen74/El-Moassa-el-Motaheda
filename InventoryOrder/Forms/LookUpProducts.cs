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
    public partial class LookUpProducts : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        Classes.CLS_Products bs = new Classes.CLS_Products();

        SqlDataReader dr;
        Cash cash;
        public LookUpProducts(Cash c)
        {
            InitializeComponent();
            loadprod();
            cash = c;
        }

        public void loadprod()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                int i = 0;
                dgvproduct.Rows.Clear();
                string query = " SELECT p.ID,p.fatora_id, p.Product_id,p.product_Name, p.Product_SellPrice, p.product_QTY FROM tblProduct as p WHERE p.pf_status=1 AND p.f_status=1 AND CONCAT(Fatora_ID, Product_id, product_Name) LIKE '%" + txtSearch.Text + "%'";
                SqlCommand cm = new SqlCommand(query, cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvproduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[5].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadprod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            this.prodid = prodid;
            this.fatoracode = fatoracode;
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
            */
            string colName = dgvproduct.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                Qty qty = new Qty(cash);
                qty.ProductDetails(int.Parse(dgvproduct.Rows[e.RowIndex].Cells[1].Value.ToString()),dgvproduct.Rows[e.RowIndex].Cells[2].Value.ToString(), dgvproduct.Rows[e.RowIndex].Cells[3].Value.ToString(), double.Parse(dgvproduct.Rows[e.RowIndex].Cells[5].Value.ToString()), cash.lblTranNo.Text, int.Parse(dgvproduct.Rows[e.RowIndex].Cells[6].Value.ToString()));
                qty.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadprod();
        }

        private void gbProducts_Enter(object sender, EventArgs e)
        {

        }
    }
}
