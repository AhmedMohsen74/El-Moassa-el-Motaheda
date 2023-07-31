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
    public partial class RestoreBackUP : Form
    {
        public RestoreBackUP()
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
                string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd;
                    string query = "Alter Database InventoryDB SET OFFLINE WITH ROLLBACK IMMEDIATE;  Restore Database InventoryDB From Disk = '" + txtPath.Text + "'";
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The Backup has been Restored successfully", "BackUP Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }
    }
}
