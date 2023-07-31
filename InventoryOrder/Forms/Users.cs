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
    public partial class Users : Form
    {
        Classes.CLS_Users users = new Classes.CLS_Users();
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        string title = "المؤسسة المتحدة للتكيف";
        public Users()
        {
            InitializeComponent();
            this.dgvUsers.DataSource = users.LoadUsers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //dataTable = users.SearchUser(txtSearch.Text);
            //this.dgvUsers.DataSource = dataTable;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //txtSearch.Text = "";
            this.dgvUsers.DataSource = users.LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المستخدم؟", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Sp_DeleteUser", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter param = new SqlParameter();

                        param = new SqlParameter("@ID", SqlDbType.Int);
                        param.Value = dgvUsers.CurrentRow.Cells[0].Value.ToString();

                        cmd.Parameters.Add(param);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("تم الحذف بنجاح", title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.dgvUsers.DataSource = users.LoadUsers();
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
            Forms.UpdateUsers c = new Forms.UpdateUsers(this);
            c.lblId.Text = this.dgvUsers.CurrentRow.Cells[0].Value.ToString();
            c.txtusername.Text = this.dgvUsers.CurrentRow.Cells[1].Value.ToString();
            c.txtpass.Text = this.dgvUsers.CurrentRow.Cells[2].Value.ToString();
            c.txtname.Text = this.dgvUsers.CurrentRow.Cells[3].Value.ToString();
            c.Text = "تحديث بيانات العميل : " + this.dgvUsers.CurrentRow.Cells[3].Value.ToString();
            c.txtusername.Focus();
            c.btnAdd.Enabled = false;
            c.btnUpdate.Enabled = true;
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.UpdateUsers u = new Forms.UpdateUsers(this);
            u.ShowDialog();
            u.btnAdd.Enabled = true;
            u.btnUpdate.Enabled = false;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
