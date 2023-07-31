using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace InventoryOrder.Forms
{
    public partial class DamgedSticker : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;

        Damaged damge;
        public DamgedSticker(Damaged d)
        {
            InitializeComponent();
            damge = d;
        }
        public void LoadDamgedSticker()
        {
            //ReportDataSource rptDataSourece;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptDamged.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();

                    DataSet1 ds = new DataSet1();
                    SqlDataAdapter da = new SqlDataAdapter();

                    ReportParameter pStoreName = new ReportParameter("pStoreName", damge.txtname.Text);
                    ReportParameter pStoreCode = new ReportParameter("pStoreCode", damge.txtCode.Text);
                    ReportParameter pClientReport = new ReportParameter("pClientReport", damge.txtReport.Text);
                    ReportParameter pProductCode = new ReportParameter("pProductCode", damge.txtProductid.Text);
                    ReportParameter pFatoraCode = new ReportParameter("pFatoraCode", damge.txtFatoraid.Text);

                    reportViewer1.LocalReport.SetParameters(pStoreName);
                    reportViewer1.LocalReport.SetParameters(pStoreCode);
                    reportViewer1.LocalReport.SetParameters(pClientReport);
                    reportViewer1.LocalReport.SetParameters(pProductCode);
                    reportViewer1.LocalReport.SetParameters(pFatoraCode);

                    reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    reportViewer1.ZoomPercent = 235;
                   
                    System.Drawing.Printing.PageSettings pg = new System.Drawing.Printing.PageSettings();

                    pg.Margins.Top = 16;
                    pg.Margins.Bottom = 10;
                    pg.Margins.Left = 6;
                    pg.Margins.Right = 6;
                    pg.Landscape = false;
                    reportViewer1.SetPageSettings(pg);
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
        void rpvInformes_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            e.PrinterSettings.DefaultPageSettings.Landscape = false;
        }
        private void DamgedSticker_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            e.PrinterSettings.DefaultPageSettings.Landscape = false;
        }
    }
}
