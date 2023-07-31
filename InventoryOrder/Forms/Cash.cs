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
    public partial class Cash : Form
    {
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        int qty;
        string cashid;
        string price;
        string stitle = "المؤسسة المتحدة للتكيف";

        Classes.CLS_Products bs = new Classes.CLS_Products();
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        public Cash()
        {
            InitializeComponent();
            //date.Text= DateTime.Now.ToString("dd-MM-yyyy");
            GetTranNo();
            date.Text = DateTime.Now.ToShortDateString();
            gbCash.Enabled = false;
            pItems.Enabled = false;
            gbOrder.Enabled = false;
            btnLookUpProd.Enabled = false;

        }

        private void txtSearchprod_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void GetTranNo()
        {
            using (SqlConnection cn = new SqlConnection(CS)) 
            {
                //try
                //{
                    string sdate = DateTime.Now.ToString("yyyyMMdd");
                    int count;
                    string transno;
                    cn.Open();
                    cm = new SqlCommand("SELECT TOP 1 transno FROM tblCash WHERE transno LIKE '" + sdate + "%' ORDER BY Cash_id desc", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        transno = dr[0].ToString();
                        count = int.Parse(transno.Substring(8, 4));
                        lblTranNo.Text = sdate + (count + 1);
                    }
                    else
                    {
                        transno = sdate + "1001";
                        lblTranNo.Text = transno;
                    }
                    dr.Close();
                    cn.Close();
                //}
                //catch (Exception ex)
                //{

                //    cn.Close();
                //    MessageBox.Show(ex.Message, stitle);
                //}
                //finally
                //{
                //    cn.Close();
                //}
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    if (txtCname.Text == "" || txtCReportNumb.Text == "")
                    {
                        MessageBox.Show("قم بادخال البيانات ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query = "Sp_insertClient";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter[] param = new SqlParameter[2];

                        param[0] = new SqlParameter("@out_ClientReportnumb", SqlDbType.VarChar, 50);
                        param[0].Value = txtCReportNumb.Text;

                        param[1] = new SqlParameter("@out_ClientName", SqlDbType.NVarChar, 100);
                        param[1].Value = txtCname.Text;

                        cmd.Parameters.AddRange(param);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("تمت إضافة العميل بنجاح","تمت",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtCname.Enabled = false;
                        txtCReportNumb.Enabled = false;
                        btnAdd.Enabled = false;
                        gbCash.Enabled = true;
                        btnLookUpProd.Enabled = true;
                        pItems.Enabled = true;

                        lblCReport.Text = txtCReportNumb.Text;
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            

        }

        private void btncanOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                if (MessageBox.Show("هل تريد إلغاء هذه العملية؟", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from tblCash where transno like'" + lblTranNo.Text + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("تم إلغاء العملية بنجاح", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
        }

        private void txtCReportNumb_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS)) 
            {
                cn.Open();
                if (txtCReportNumb.Text != "")
                {
                    string query = " SELECT * FROM tblClient WHERE out_ClientReportnumb = @out_ClientReportnumb";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@out_ClientReportnumb", txtCReportNumb.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        txtCname.Text = dr.GetValue(1).ToString();
                        txtCname.ReadOnly = true;
                        gbCash.Enabled = true;
                        pItems.Enabled = true;
                        btnLookUpProd.Enabled = true;
                        btnAdd.Enabled = false;
                        txtCReportNumb.Enabled = false;
                        lblCReport.Text = txtCReportNumb.Text;
                    }
                    cn.Close();
                }
            }
        }

        #region method
        public void ShowData(string query)
        {
            string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter Da = new SqlDataAdapter(cmd);
                    DataTable Dt = new DataTable();
                    Da.Fill(Dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,stitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadCart()
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    Boolean hascart = false;
                    int i = 0;
                    double total = 0;
                    dgvCash.Rows.Clear();
                    cn.Open();

                //string query = "SELECT c.id, c.pcode," +
                //    " p.pdesc, c.price, c.qty, c.disc," +
                //    " c.total FROM tbCart AS c " +
                //    "INNER JOIN tbProduct AS p ON c.pcode=p.pcode " +
                //    "WHERE c.transno LIKE @transno and c.status LIKE 'Pending'";


                //string query = " SELECT c.Cash_id, c.product_id,c.fatora_id,p.product_Name,c.price,c.QTY,c.total " +
                //        "FROM tblCash AS c inner join tblProduct AS p ON c.ProductID = p.ID " +
                //        "WHERE c.transno LIKE @transno and c.C_Status LIKE 'Pending'";


                //string query = " SELECT c.Cash_id,c.ProductID, c.product_id,c.fatora_id,p.product_Name,c.price,c.QTY,c.total " +
                //        "FROM tblCash AS c , tblProduct AS p  " +
                //        "WHERE   c.product_id = p.Product_id and c.transno LIKE @transno and c.C_Status LIKE 'Pending'";


                string query = " SELECT c.Cash_id,c.ProductID, c.product_id,c.fatora_id,p.product_Name,c.price,c.QTY,c.total " +
                        "FROM tblCash AS c inner join tblProduct AS p ON c.product_id = p.Product_id and" +
                        " c.fatora_id= p.fatora_id and p.pf_status=1 and p.f_status=1" +
                        "WHERE c.transno LIKE @transno and c.C_Status LIKE 'Pending'";

                cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@transno", lblTranNo.Text);

                dr = cm.ExecuteReader();

                while (dr.Read())
                    {
                    //  double totalRow = Convert.ToDouble(dr["price"].ToString()) * Convert.ToDouble(dr["QTY"].ToString());
                    i++;
                    total += Convert.ToDouble(dr["total"].ToString());
                    //total += totalRow; 
                    dgvCash.Rows.Add(i,
                            dr["Cash_id"].ToString(),
                            dr["ProductID"].ToString(),
                            dr["fatora_id"].ToString(),
                            dr["product_id"].ToString(),
                            dr["product_Name"].ToString(),
                            dr["price"].ToString(), 
                            dr["QTY"].ToString(),
                            double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                            //double.Parse(totalRow.ToString("#,##0.00")));
                        hascart = true;
                }
                dr.Close();
                    cn.Close();
                    lbltotal.Text = total.ToString("#,##0.00");
                    if (hascart) { gbOrder.Enabled = true; }
                    else { gbOrder.Enabled = false; }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, stitle);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        #endregion

        public void AddToCart(int _pid, string _pcode,string _fatoracode, double _price, int _qty)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    string id = "";
                    int cart_qty = 0;
                    bool found = false;
                    cn.Open();
                    cm = new SqlCommand(" SELECT * FROM tblCash WHERE transno=@transno AND out_ClientReportnumb=@out_ClientReportnumb AND product_id = @product_id AND ProductID = @ProductID", cn);
                    cm.Parameters.AddWithValue("@out_ClientReportnumb", lblCReport.Text);
                    cm.Parameters.AddWithValue("@fatora_id", _fatoracode);
                    cm.Parameters.AddWithValue("@product_id", _pcode);
                    cm.Parameters.AddWithValue("@ProductID", _pid);
                    cm.Parameters.AddWithValue("@transno", lblTranNo.Text);

                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        id = dr["Cash_id"].ToString();
                        cart_qty = int.Parse(dr["QTY"].ToString());
                        found = true;
                    }
                    else found = false;
                    dr.Close();
                    cn.Close();

                    if (found)
                    {
                        if (qty < (int.Parse(txtQty.Text) + cart_qty))
                        {
                            MessageBox.Show("نفذت الكمية " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cn.Open();
                        cm = new SqlCommand("Update tblCash set QTY = (QTY + " + _qty + ")Where Cash_id= '" + id + "'", cn);
                        cm.ExecuteReader();
                        cn.Close();
                        txtBarcode.SelectionStart = 0;
                        txtBarcode.SelectionLength = txtBarcode.Text.Length;
                        LoadCart();
                    }
                    else
                    {
                        if (qty < (int.Parse(txtQty.Text) + cart_qty))
                        {
                            MessageBox.Show("غير قادر على التقديم. الكمية المتبقية في متناول اليد " + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        cn.Open();

                        cm = new SqlCommand("INSERT INTO tblCash(out_ClientReportnumb, transno, product_id,ProductID, price, QTY , sdate, fatora_id)VALUES(@out_ClientReportnumb,@transno, @product_id,@ProductID, @price, @QTY, @sdate, @fatora_id)", cn);
                        cm.Parameters.AddWithValue("@out_ClientReportnumb", lblCReport.Text);
                        cm.Parameters.AddWithValue("@transno", lblTranNo.Text);
                        cm.Parameters.AddWithValue("@product_id", _pcode);
                        cm.Parameters.AddWithValue("@ProductID", _pid);
                        cm.Parameters.AddWithValue("@price", _price);
                        cm.Parameters.AddWithValue("@QTY", _qty);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.Parameters.AddWithValue("@fatora_id", _fatoracode);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        LoadCart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, stitle);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnLookUpProd_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                try
                {
                    if (txtBarcode.Text == string.Empty) return;
                    else
                    {
                        int _pid;
                        string _pcode;
                        double _price;
                        int _qty;
                        string _fatoracode;
                        cn.Open();
                        string query = "SELECT * FROM tblProduct WHERE f_status = 1 AND pf_status = 1 AND Product_id LIKE '" + txtBarcode.Text + "'";
                        cm = new SqlCommand(query, cn);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            qty = int.Parse(dr["product_QTY"].ToString());
                            _pcode = dr["Product_id"].ToString();
                            _pid = int.Parse(dr["ProductID"].ToString());
                            _fatoracode = dr["fatora_id"].ToString();
                            _price = double.Parse(dr["Product_SellPrice"].ToString());
                            _qty = int.Parse(txtQty.Text);
                            dr.Close();
                            cn.Close();
                            //insert to tbCart
                            AddToCart(_pid, _pcode, _fatoracode, _price, _qty);
                            txtBarcode.Text = "";
                        }
                        dr.Close();
                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void dgvCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCash.Columns[e.ColumnIndex].Name;


            using (SqlConnection cn = new SqlConnection())
            {
                DAL.DataAccessLayer d = new DAL.DataAccessLayer();

                if (colName == "Delete")
                {
                    if (MessageBox.Show("Remove this item", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        d.ExecuteQuery("Delete from tblCash where Cash_id like'" + dgvCash.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                        MessageBox.Show("تم الحذف بنجاح", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCart();
                    }
                }
            }
        }

        private void dgvCash_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvCash.CurrentRow.Index;
            cashid = dgvCash[1, i].Value.ToString();
            price = dgvCash[5, i].Value.ToString();
        }

        private void Cash_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLookUpProd_Click_1(object sender, EventArgs e)
        {
            LookUpProducts lookUp = new LookUpProducts(this);
            lookUp.loadprod();
            lookUp.ShowDialog();
        }

        private void btnAddorder_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                if (MessageBox.Show("هل تريد تأكيد هذه العملية؟", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        for (int i = 0; i < dgvCash.Rows.Count; i++)
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tblProduct SET product_QTY = product_QTY - " + int.Parse(dgvCash.Rows[i].Cells[7].Value.ToString()) + "WHERE Product_id= '" + dgvCash.Rows[i].Cells[4].Value.ToString() + "' and fatora_id = '" + dgvCash.Rows[i].Cells[3].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();

                            cm = new SqlCommand("UPDATE tblCash SET C_Status = 'Sold' WHERE Cash_id = '" + dgvCash.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        Reciept recept = new Reciept(this);
                        recept.LoadRecept();
                        recept.ShowDialog();
                        MessageBox.Show("تمت العملية بنجاح", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetTranNo();
                        LoadCart();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }

        private void dgvCash_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtCname.Text = "";
            txtCReportNumb.Text = "";
            txtCname.ReadOnly = false;
            gbCash.Enabled = false;
          
            txtCname.Enabled = true;
            pItems.Enabled = false;
            txtCReportNumb.Enabled = true;
            btnLookUpProd.Enabled = false;
            btnAdd.Enabled = true;

        }

        private void btnPrintOrd_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCReportNumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Cash_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
