using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryOrder.Forms
{
    public partial class Forgetpass : Form
    {
        Login l;
        String title = "المؤسسة المتحدة للتكيف";
        public Forgetpass(Login log)
        {
            InitializeComponent();
            l = log;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Security.Text == "21222425")
            {
                MessageBox.Show("اهلا بك", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                l.Hide();

                Mainform s = new Mainform();
                this.Hide();
                s.Show();
            }
            else
            {
                MessageBox.Show("ليست لديك احقية الدخول", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Security_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
