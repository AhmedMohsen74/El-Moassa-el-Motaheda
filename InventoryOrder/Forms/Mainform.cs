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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            lblName.Text = Login.empname;
            // Dashboard.ActiveForm()
        }
        private Form activeForm = null;
        //public void openChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    childForm.BringToFront();
        //    childForm.Show();
        //    }

        public void openChildForm(Form child)
        {
            panelchildform.Visible = true;
            if (activeForm != null)
                activeForm.Close();
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(child);
            panelchildform.Tag = child;
            child.BringToFront();
            child.Show();
        }
        public void CloseChildForm()
        {
            panelchildform.Visible = false;
        }
        private void اضافةفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Forms.FatoraModule f = new Forms.FatoraModule();
            f.ShowDialog();
        }

        private void ادارةالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Forms.Fatora f = new Forms.Fatora();
            f.ShowDialog();
        }

        private void اضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اداToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Forms.Product f = new Forms.Product();
            f.ShowDialog();
        }

        private void اضافةاصنافالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Forms.ProductModules f = new Forms.ProductModules("mohsen");
            f.ShowDialog();
        }

        private void صرفمنتجاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Forms.Cash f = new Forms.Cash();
            f.ShowDialog();
        }

        private void منتجاتالفاتورةالأصليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Forms.Product f = new Forms.Product();
            f.groupBox2.Enabled = false;
            f.btnRefresh.Enabled = false;
            f.ShowDialog();
        }

        private void عملBackUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            RestoreBackUP f = new RestoreBackUP();
            f.ShowDialog();
        }

        private void بياناتالشركةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Store f = new Store();
            f.ShowDialog();
        }

        private void استرجاعبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            GenerateBackUP f = new GenerateBackUP();
            f.ShowDialog();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Clients f =new Clients();
            f.ShowDialog();

        }

        private void المبيعاتاليوميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Record f = new Record();
            f.ShowDialog();

        }
        private void dashboardToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            About f = new About();
            f.ShowDialog();

        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تسجيل الخروج؟", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login f = new Login();
                f.ShowDialog();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Users f = new Users();
            f.ShowDialog();

        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Dashboard f = new Forms.Dashboard();
            openChildForm(f);
            //f.Show();            
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void استرجاعمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Damaged f = new Damaged();
            f.ShowDialog();
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            //dashboardToolStripMenuItem.PerformClick();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainform_Shown(object sender, EventArgs e)
        {
           dashboardToolStripMenuItem.PerformClick();
        }

        private void Mainform_EnabledChanged(object sender, EventArgs e)
        {
            //dashboardToolStripMenuItem.PerformClick();
        }
    }
}
