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
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace InventoryOrder.Forms
{
    public partial class Reciept : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;

        Cash cash;
        SqlDataReader dr;
        string storecode;
        string name;
        string OwnerName;
        string telephone;
        public Reciept(Cash c)
        {
            InitializeComponent();
            cash = c;

            LoadStore();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void LoadStore()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM tblStore", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    storecode = dr["S_id"].ToString();
                    name = dr["S_name"].ToString();
                    OwnerName = dr["S_Ownername"].ToString();
                    telephone = dr["S_Telephone"].ToString();
                }
                dr.Close();
                cn.Close();
            }
        }
        public void LoadRecept()
        {
            ReportDataSource rptDataSourece;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptRecept.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();

                    DataSet1 ds = new DataSet1();
                    SqlDataAdapter da = new SqlDataAdapter();

                    cn.Open();
                    da.SelectCommand = new SqlCommand("SELECT c.Cash_id, c.transno, c.product_id,c.out_ClientReportnumb,c.price, c.QTY, c.sdate, c.total, c.C_Status, p.fatora_id, p.product_Name " +
                        "FROM tblCash AS c INNER JOIN tblProduct AS p ON p.Product_id = c.product_id and c.fatora_id = p.fatora_id WHERE c.transno LIKE'" + cash.lblTranNo.Text + "'", cn);

                    /*da.SelectCommand = new SqlCommand("SELECT c.Cash_id,c.ProductID, c.product_id,c.fatora_id,p.product_Name,c.price,c.QTY,c.total " +
                        "FROM tblCash AS c inner join tblProduct AS p ON c.product_id = p.Product_id and c.fatora_id= p.fatora_id and p.pf_status=1 and p.f_status=1" +
                        "WHERE c.transno LIKE @transno and c.C_Status LIKE 'Pending'");*/

                    da.Fill(ds.Tables["dtRecept"]);
                    cn.Close();

                    ReportParameter pid = new ReportParameter("pid", storecode);
                    ReportParameter pname = new ReportParameter("pname", name);
                    ReportParameter ptelephone = new ReportParameter("ptelephone", telephone);
                    ReportParameter pClient = new ReportParameter("pClient", cash.lblCReport.Text);
                    ReportParameter pownername = new ReportParameter("pownername", OwnerName);

                    reportViewer1.LocalReport.SetParameters(pid);
                    reportViewer1.LocalReport.SetParameters(pname);
                    reportViewer1.LocalReport.SetParameters(ptelephone);
                    reportViewer1.LocalReport.SetParameters(pClient);
                    reportViewer1.LocalReport.SetParameters(pownername);
                 

                    rptDataSourece = new ReportDataSource("DataSet1", ds.Tables["DtRecept"]);
                    reportViewer1.LocalReport.DataSources.Add(rptDataSourece);
                    reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    reportViewer1.ZoomPercent = 100;

                    //p.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 840, 1180);
                    /*System.Drawing.Printing.PageSettings R = new System.Drawing.Printing.PageSettings();
                    R.PaperSize = new System.Drawing.Printing.PaperSize("Receipt 100X150", 1, 1);
                    reportViewer1.SetPageSettings(R);*/
                    PrinterSettings ps = new PrinterSettings();
                    PrintDocument printDoc = new PrintDocument();
                    printDoc.PrinterSettings = ps;
                    printDoc.DefaultPageSettings.PaperSize = new PaperSize("Receipt 100X150", 315, 300);
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void Reciept_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
