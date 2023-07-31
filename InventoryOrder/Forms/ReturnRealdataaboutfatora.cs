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
    public partial class ReturnRealdataaboutfatora : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        string fatID;
        public ReturnRealdataaboutfatora(string fatoraid)
        {
            InitializeComponent();
            fatID = fatoraid;
            Loadfatora();
            lblfat.Text = fatID;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        public void Loadfatora()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                int i = 0;

                string query = "SELECT p.Product_id,p.product_Name,p.realQTY,p.product_QTY,p.Product_PurchPrice ,p.Product_SellPrice,p.product_total FROM tblProduct AS p where p.Fatora_id = '" + fatID + "' and pf_status = 1 and f_status = 1";
                SqlCommand cm = new SqlCommand(query, cn);
                dgvReturn.Rows.Clear();
                cn.Open();
                SqlDataReader dr;   
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvReturn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Reports report = new Reports(fatID);
            string param = lblfat.Text;

            string query= "SELECT p.Product_id, p.product_Name, p.realQTY, p.product_QTY, p.Product_PurchPrice" +
                        " , p.Product_SellPrice, p.product_total" +
                        " FROM tblProduct AS p where p.Fatora_id = '" + lblfat.Text + "' and pf_status = 1 and f_status = 1"; 


            report.LoadFatoraItems(query, param);
            report.ShowDialog();
        }
    }
}
