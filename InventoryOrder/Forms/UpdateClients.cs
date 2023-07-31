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
    public partial class UpdateClients : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        bool check = false;
        Clients client;
        string title = "المؤسسة المتحدة للتكيف";
        public UpdateClients(Clients c)
        {
            InitializeComponent();
            client = c;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCReportNumb_Validated(object sender, EventArgs e)
        {
            //Classes.CLS_Clients bs = new Classes.CLS_Clients();
            //DataTable dt = new DataTable();
            //dt = bs.veirfyClient(txtCReportNumb.Text);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("قد تم ادخال هذا العميل مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtCname.Text = "";
            //    txtCReportNumb.Text = "";
            //    txtCReportNumb.SelectionStart = 0;
            //    txtCReportNumb.SelectionLength = txtCReportNumb.TextLength;
            //}
        }

        #region methods
        public void checkField()
        {
            if (txtCname.Text == "" || txtCReportNumb.Text == "")
            {
                MessageBox.Show("قم بادخال البيانات", "خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                        string query = "Sp_UpdateClient";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter[] param = new SqlParameter[2];

                        param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
                        param[0].Value = txtCReportNumb.Text;

                        param[1] = new SqlParameter("@name", SqlDbType.VarChar, 100);
                        param[1].Value = txtCname.Text;

                        cmd.Parameters.AddRange(param);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("تم التعديل بنجاح", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        //Classes.CLS_Clients bs = new Classes.CLS_Clients();
                        //this.client.dgvClients.DataSource = bs.loadClients();
                        client.LoadClient();
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
    }
}
