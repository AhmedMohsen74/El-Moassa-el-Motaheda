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
    public partial class Store : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;

        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        bool havestoreinfo = false;
        string title = "المؤسسة المتحدة للتكيف";

        public Store()
        {
            InitializeComponent();
            LoadStore();
        }

        public void LoadStore()
        {
            using (SqlConnection cn = new SqlConnection(CS)) 
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM tblStore", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    havestoreinfo = true;
                    txtStoreCode.Text = dr["S_id"].ToString();
                    txtStName.Text = dr["S_name"].ToString();
                    txtStoreOwner.Text = dr["S_Ownername"].ToString();
                    txtStorePhone.Text = dr["S_Telephone"].ToString();
                }
                else
                {
                    txtStName.Clear();
                    txtStoreCode.Clear();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                cn.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    if (MessageBox.Show("حفظ التعديلات؟", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (havestoreinfo)
                        {
                            string query = "Sp_updateStore";
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter[] param = new SqlParameter[4];

                            param[0] = new SqlParameter("@S_name", SqlDbType.VarChar, 100);
                            param[0].Value = txtStName.Text;

                            param[1] = new SqlParameter("@S_id", SqlDbType.Int);
                            param[1].Value = txtStoreCode.Text;

                            param[2] = new SqlParameter("@S_Ownername", SqlDbType.VarChar, 100);
                            param[2].Value = txtStoreOwner.Text;

                            param[3] = new SqlParameter("@S_Telephone", SqlDbType.VarChar, 11);
                            param[3].Value = txtStorePhone.Text;
                            cmd.Parameters.AddRange(param);

                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                        else
                        {
                            string query = "Sp_insertStore";
                            SqlCommand cmd = new SqlCommand(query, cn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            SqlParameter[] param = new SqlParameter[4];

                            param[0] = new SqlParameter("@S_name", SqlDbType.VarChar, 100);
                            param[0].Value = txtStName.Text;

                            param[1] = new SqlParameter("@S_id", SqlDbType.Int);
                            param[1].Value = txtStoreCode.Text;

                            param[2] = new SqlParameter("@S_Ownername", SqlDbType.VarChar, 100);
                            param[2].Value = txtStoreOwner.Text;

                            param[3] = new SqlParameter("@S_Telephone", SqlDbType.VarChar, 11);
                            param[3].Value = txtStorePhone.Text;
                            cmd.Parameters.AddRange(param);

                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                        MessageBox.Show("!تم حفظ بيانات الشركة بنجاح", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStoreCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
