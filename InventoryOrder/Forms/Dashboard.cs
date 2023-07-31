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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void Clients()
        {
            string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblClient;", con);
                con.Open();
                int Client = (int)cmd.ExecuteScalar();
                lblTotalClients.Text = Client.ToString();
            }
        }
        public void fatora()
        {
            string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblFatora Where f_status = 1;", con);
                con.Open();
                int fatora = (int)cmd.ExecuteScalar();
                lblTotalFatora.Text = fatora.ToString();
            }
        }

        public void Products()
        {
            string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblProduct where f_status = 1 and pf_status = 1;", con);
                con.Open();
                int prod = (int)cmd.ExecuteScalar();
                lblTotalProducts.Text = prod.ToString();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Clients();
            fatora();
            Products();
        }

        private void Dashboard_Enter(object sender, EventArgs e)
        {
            Clients();
            fatora();
            Products();
        }
    }
}
