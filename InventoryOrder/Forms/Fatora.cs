using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace InventoryOrder.Forms
{
    public partial class Fatora : Form
    {
        SqlDataReader dr;
        public static string fatora_id;
        Classes.CLS_Fatora getfatora = new Classes.CLS_Fatora();
        public Fatora()
        {
            InitializeComponent();
            //this.dgvfatora.DataSource = getfatora.loadFatora();
            Loadfatora();
        }
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.FatoraModule f = new Forms.FatoraModule();
            f.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblfatora.Text != "label2")
            {
                Forms.ProductModules fm = new Forms.ProductModules(lblfatora.Text);
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("من فضلك اختار كود الفاتورة من الجدول");
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Forms.FatoraModule d = new Forms.FatoraModule();
            txtfatoraSearch.Text = d.txtfatoraid.Text;       
        }

        private void txtfatora_TextChanged(object sender, EventArgs e)
        {
            Loadfatora();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
        }

        #region method
        public void Loadfatora()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                int i = 0;
                dgvfatora.Rows.Clear();
                string query = "Select fat.Fatora_ID ,fat.Fatora_Date from tblFatora as fat where f_status=1 and Fatora_ID like '%" + txtfatoraSearch.Text + "%'";
                SqlCommand cm = new SqlCommand(query, cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvfatora.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }
        #endregion

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvfatora_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvfatora.SelectedRows.Count != 0) 
            {
                fatora_id = dgvfatora.SelectedRows[0].Cells[1].Value.ToString();
                lblfatora.Text = fatora_id;
            }
        }

        private void btnUpdaFatora_Click(object sender, EventArgs e)
        {

        }

        private void dgvfatora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvfatora.Columns[e.ColumnIndex].Name;
            if (colName == "View")
            {
                Forms.ReturnRealdataaboutfatora real = new Forms.ReturnRealdataaboutfatora(fatora_id);
                real.ShowDialog();
            }
        }

        private void btnDelfatora_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS)) 
            {
                try
                {
                    if (MessageBox.Show("هل تريد حذف المنتج المجدد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query = " update tblFatora set f_status = 0 where Fatora_ID ='" + lblfatora.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم الحذف بنجاح", "تمت", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        string query2 = "  update tblProduct set f_status = 0 where fatora_id = '" + lblfatora.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.ExecuteNonQuery();
                        cn.Close();
                        Loadfatora();
                        Classes.CLS_Products cs = new Classes.CLS_Products();
                        cs.loadproducts();
                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عملية الحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnprintFatoras_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports("");
            reports.LoadFatora();
            reports.ShowDialog();
        }
    }
}
