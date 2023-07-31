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
    public partial class GenerateBackUP : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        SqlCommand cmd;

        public GenerateBackUP()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == string.Empty)
            {
                MessageBox.Show("قم باختيار المكان", "Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(CS)) 
                {
                    string FileName = txtPath.Text + "\\ELMotaheda " + DateTime.Now.ToShortDateString().Replace('/', '-')   + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                    string query = "Backup Database InventoryDB to Disk = '" + FileName + ".backup'";
                    cmd = new SqlCommand(query, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("The Backup has been created successfully", "Backup Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
