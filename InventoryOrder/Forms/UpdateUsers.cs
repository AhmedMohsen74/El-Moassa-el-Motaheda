using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace InventoryOrder.Forms
{
    public partial class UpdateUsers : Form
    {
        Classes.CLS_Users bs = new Classes.CLS_Users();

        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        bool check = false;
        Users user;
        string title = "المؤسسة المتحدة للتكيف";
    public UpdateUsers(Users u)
        {
            InitializeComponent();
            user = u;
        }

        #region methods
        public void checkField()
        {
            if (txtusername.Text == "" || txtpass.Text == "" || txtpass.Text == "") 
            {
                MessageBox.Show("قم بادخال البيانات", "خطأ");
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
                        string query = "Sp_UpdateUser";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter[] param = new SqlParameter[4];

                        param[0] = new SqlParameter("@ID", SqlDbType.Int);
                        param[0].Value =lblId.Text ;

                        param[1] = new SqlParameter("@username", SqlDbType.VarChar, 50);
                        param[1].Value = txtusername.Text;

                        param[2] = new SqlParameter("@userpass", SqlDbType.VarChar, 100);
                        param[2].Value = txtpass.Text;

                        param[3] = new SqlParameter("@name", SqlDbType.VarChar, 100);
                        param[3].Value = txtname.Text;

                        cmd.Parameters.AddRange(param);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("تم تعديل المستخدم بنجاح", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        this.user.dgvUsers.DataSource = bs.LoadUsers();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtpass.Text = "";
            txtusername.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    checkField();
                    if (check)
                    {
                        string query = "Sp_InsertUser";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter[] param = new SqlParameter[3];

                        param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
                        param[0].Value = txtusername.Text;

                        param[1] = new SqlParameter("@user_password", SqlDbType.NVarChar, 100);
                        param[1].Value = txtpass.Text;

                        param[2] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                        param[2].Value = txtname.Text;

                        cmd.Parameters.AddRange(param);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("تمت إضافة المستخدم بنجاح", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.user.dgvUsers.DataSource = bs.LoadUsers();

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
