using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace InventoryOrder.Forms
{
    public partial class Clients : Form
    {
        Classes.CLS_Clients clients = new Classes.CLS_Clients();
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        string title = "المؤسسة المتحدة للتكيف";
        SqlDataReader dr;
        public static string Report_ID;

        public Clients()
        {
            InitializeComponent();
            //this.dgvClients.DataSource = clients.loadClients();
            LoadClient();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //dataTable = clients.SearchClient(txtSearch.Text);
            //this.dgvClients.DataSource = dataTable;
            LoadClient();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            //this.dgvClients.DataSource = clients.loadClients();
            LoadClient();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العميل؟", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Sp_DeleteClient", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter param = new SqlParameter();

                        param = new SqlParameter("@ID", SqlDbType.Int);
                        param.Value = dgvClients.CurrentRow.Cells[1].Value.ToString();

                        cmd.Parameters.Add(param);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم الحذف بنجاح", title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LoadClient();                
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Forms.UpdateClients c = new Forms.UpdateClients(this);
            c.txtCname.Text = this.dgvClients.CurrentRow.Cells[2].Value.ToString();
            c.txtCReportNumb.Text = this.dgvClients.CurrentRow.Cells[1].Value.ToString();
            c.Text = "تحديث بيانات العميل : " + this.dgvClients.CurrentRow.Cells[2].Value.ToString();
            c.txtCReportNumb.ReadOnly = true;
            c.txtCname.Focus();
            c.ShowDialog();
        }

       #region method
        public void LoadClient()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                int i = 0;
                dgvClients.Rows.Clear();
                string query = "SELECT  c.out_ClientReportnumb,c.out_ClientName FROM tblClient AS c WHERE c.out_ClientName + c.out_ClientReportnumb LIKE '%" + txtSearch.Text + "%'";
                SqlCommand cm = new SqlCommand(query, cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvClients.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
                }
                dr.Close();
                cn.Close();
            }
        }
        #endregion

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClients.SelectedRows.Count != 0)
                {
                    Report_ID = dgvClients.SelectedRows[0].Cells[1].Value.ToString();
                    lblreport.Text = Report_ID;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvClients.Columns[e.ColumnIndex].Name;
            if (colName == "View")
            {
                Forms.ReturnCash real = new Forms.ReturnCash(Report_ID);
                real.ShowDialog();
            }
        }
    }
}
