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

namespace InventoryOrder.Forms
{
    public partial class Reports : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        SqlDataReader dr;
        string storecode;
        string name;
        string OwnerName;
        string telephone;

        string fatoraID = "";
        public Reports(string fatID)
        {
            InitializeComponent();
            fatoraID = fatID;
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

        public void LoadSoldItems(string sql, string param)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    ReportDataSource rptDS;
                    this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptSoldItems.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();

                    DataSet1 ds = new DataSet1();
                    SqlDataAdapter da = new SqlDataAdapter();
                    cn.Open();
                    da.SelectCommand = new SqlCommand(sql, cn);
                    da.Fill(ds.Tables["DtSoldItem"]);
                    cn.Close();

                    ReportParameter pDate = new ReportParameter("pDate", param);
                    reportViewer1.LocalReport.SetParameters(pDate);
                    rptDS = new ReportDataSource("DataSet1", ds.Tables["DtSoldItem"]);
                    reportViewer1.LocalReport.DataSources.Add(rptDS);
                    reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;                 
                    reportViewer1.ZoomPercent = 100;
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

        public void LoadFatora()
        {
            ReportDataSource rptDataSourece;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptFatora.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();

                    DataSet1 ds = new DataSet1();
                    SqlDataAdapter da = new SqlDataAdapter();

                    cn.Open();
                    string query = "SELECT fat.Fatora_ID ,fat.Fatora_Date  FROM tblFatora AS fat WHERE f_status = 1";
                    da.SelectCommand = new SqlCommand(query, cn);
                    da.Fill(ds.Tables["DtFatora"]);
                    cn.Close();

                    rptDataSourece = new ReportDataSource("DataSet1", ds.Tables["DtFatora"]);
                    reportViewer1.LocalReport.DataSources.Add(rptDataSourece);
                    reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    reportViewer1.ZoomPercent = 100;
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

        public void LoadFatoraItems(string sql, string param)
        {
            ReportDataSource rptDataSourece;
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptFatoraItems.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();

                    DataSet1 ds = new DataSet1();
                    SqlDataAdapter da = new SqlDataAdapter();

                    cn.Open();                 
                    da.SelectCommand = new SqlCommand(sql, cn);
                    da.Fill(ds.Tables["DtFatoraItems"]);
                    cn.Close();

                    ReportParameter fatora_id = new ReportParameter("fatora_id", param);
                    reportViewer1.LocalReport.SetParameters(fatora_id);

                    rptDataSourece = new ReportDataSource("DataSet1", ds.Tables["DtFatoraItems"]);
                    reportViewer1.LocalReport.DataSources.Add(rptDataSourece);
                    reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                    reportViewer1.ZoomMode = ZoomMode.Percent;
                    reportViewer1.ZoomPercent = 80;
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

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
