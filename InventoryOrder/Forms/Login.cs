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
    public partial class Login : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        SqlDataReader dr;
        public static string empname = "";

        public Login()
        {
            InitializeComponent();
            txtName.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/A.Mohsen74/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    /*
                     Create proc SP_Login
                    @UserName varchar(100), @UserPW varchar(100),@Error varchar(max) OUTPUT
                        as
                    begin try
                    select * from EmployeeTBL where
                    empName=@empName AND empPassword=@empPassword
                    END try
                    begin catch
                    Select @Error='Wrong Username or password'
                    END CATCH
                    */
                    string query = "SELECT username,name FROM tbluser WHERE username ='" + txtName.Text + "' AND user_password ='" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        //string quer = "SELECT name FROM tbluser WHERE username = '" + txtName.Text + "'";
                        empname = dr[1].ToString();
                        MessageBox.Show(empname + " اهلا بك يا  " , "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        Mainform main = new Mainform();
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(".خطأ في تسجيل الدخول..الرجاء مراجعة البيانات", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cn.Close();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); ;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            Forgetpass f = new Forgetpass(this);
            f.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد إغلاق البرنامج؟", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send/?phone=%2B201094245097&text&type=phone_number&app_absent=0");
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtName.Focus();

        }
    }
}
