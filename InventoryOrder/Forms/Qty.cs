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
    public partial class Qty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string pcode;
        private double price;
        private String transno;
        private string fatoracode;
        private int prodid;

        string stitle = "المؤسسة المتحدة";
        string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;

        private int qty;
        Cash cash;
        public Qty(Cash c)
        {
            InitializeComponent();
            cash = c;
        }

        private void Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void ProductDetails(int prodid , string fatoracode ,string pcode, double price, string transno, int qty)
        {
            this.prodid = prodid;
            this.fatoracode = fatoracode;
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            this.qty = qty;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            using (SqlConnection cn = new SqlConnection(CS))
            {
                if ((e.KeyChar == 13) && (txtQty.Text != string.Empty))
                {
                    try
                    {
                        string id = "";
                        int cart_qty = 0;
                        bool found = false;
                        cn.Open();
                        cm = new SqlCommand(" SELECT * FROM tblCash WHERE transno = @transno AND product_id = @product_id", cn);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@product_id", pcode);
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
                                MessageBox.Show("نفذت الكمية" + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else if (qty == 1 )
                            {
                                cn.Open();
                                cm = new SqlCommand("Update tblCash set QTY = (QTY + " + int.Parse(txtQty.Text) + ")Where Cash_id= '" + id + "'", cn);
                                cm.ExecuteReader();
                                cn.Close();
                                cash.txtBarcode.Clear();
                                cash.txtBarcode.Focus();
                                cash.LoadCart();
                                this.Close();
                            }
                            cn.Open();
                            cm = new SqlCommand("Update tblCash set QTY = (QTY + " + int.Parse(txtQty.Text) + ")Where Cash_id= '" + id + "'", cn);
                            cm.ExecuteReader();
                            cn.Close();
                            cash.txtBarcode.Clear();
                            cash.txtBarcode.Focus();
                            cash.LoadCart();
                            this.Close();
                        }
                        else
                        {
                            if (qty < (int.Parse(txtQty.Text) + cart_qty))
                            {
                                MessageBox.Show("نفذت الكمية" + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else if (qty == 1)
                            {
                                cn.Open();
                                cm = new SqlCommand("INSERT INTO tblCash(ProductID, transno, out_ClientReportnumb, product_id, price, QTY , sdate , fatora_id,ProductID)VALUES(@ProductID, @transno, @out_ClientReportnumb, @product_id, @price, @QTY, @sdate, @fatora_id)", cn);
                                cm.Parameters.AddWithValue("@ProductID", prodid);
                                cm.Parameters.AddWithValue("@transno", cash.lblTranNo.Text);
                                cm.Parameters.AddWithValue("@out_ClientReportnumb", cash.lblCReport.Text);
                                cm.Parameters.AddWithValue("@product_id", pcode);
                                cm.Parameters.AddWithValue("@price", price);
                                cm.Parameters.AddWithValue("@QTY", int.Parse(txtQty.Text));
                                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                                cm.Parameters.AddWithValue("@fatora_id", fatoracode);
                                cm.ExecuteNonQuery();
                                cn.Close();
                                cash.txtBarcode.Clear();
                                cash.txtBarcode.Focus();
                                cash.LoadCart();
                                this.Close();
                            }
                            else
                            {
                                cn.Open();
                                cm = new SqlCommand("INSERT INTO tblCash(ProductID, transno, out_ClientReportnumb, product_id, price, QTY , sdate , fatora_id)VALUES(@ProductID,@transno, @out_ClientReportnumb, @product_id, @price, @QTY, @sdate, @fatora_id)", cn);
                                cm.Parameters.AddWithValue("@ProductID", prodid);
                                cm.Parameters.AddWithValue("@transno", cash.lblTranNo.Text);
                                cm.Parameters.AddWithValue("@out_ClientReportnumb", cash.lblCReport.Text);
                                cm.Parameters.AddWithValue("@product_id", pcode);
                                cm.Parameters.AddWithValue("@price", price);
                                cm.Parameters.AddWithValue("@QTY", int.Parse(txtQty.Text));
                                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                                cm.Parameters.AddWithValue("@fatora_id", fatoracode);
                                cm.ExecuteNonQuery();
                                cn.Close();
                                cash.txtBarcode.Clear();
                                cash.txtBarcode.Focus();
                                cash.LoadCart();
                                this.Close();
                            } 
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                if (txtQty.Text != string.Empty)
                {
                    try
                    {
                        string id = "";
                        int cart_qty = 0;
                        bool found = false;
                        cn.Open();
                        cm = new SqlCommand(" SELECT * FROM tblCash WHERE transno = @transno AND product_id = @product_id AND fatora_id = @fatora_id ", cn);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@product_id", pcode);
                        cm.Parameters.AddWithValue("@fatora_id", fatoracode);

                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                         {
                            id = dr["Cash_id"].ToString();
                            cart_qty = int.Parse(dr["QTY"].ToString());
                            found = true;
                         }
                        else
                           {
                            found = false;
                         }

                        dr.Close();
                        cn.Close();
                        if (found)
                        {

                        if (qty < (int.Parse(txtQty.Text) + cart_qty))     //  (qty <= (int.Parse(txtQty.Text) + cart_qty)) 
                            {
                                MessageBox.Show("نفذت الكمية" + qty, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            cn.Open();
                            cm = new SqlCommand("Update tblCash set QTY = (QTY + " + int.Parse(txtQty.Text) + ")Where Cash_id= '" + id + "'", cn);
                            cm.ExecuteReader();
                            cn.Close();
                            cash.txtBarcode.Clear();
                            cash.txtBarcode.Focus();
                            cash.LoadCart();
                            this.Close();
                            // this.Dispose();
                        }
                        else
                        {
                            if (qty < (int.Parse(txtQty.Text) + cart_qty))                                 //(qty <= (int.Parse(txtQty.Text) + cart_qty))
                            {
                                MessageBox.Show("{" + qty + "}"+" الكمية الموجودة غير كافية " , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else if (qty == 1)
                            {
                                cn.Open();
                                cm = new SqlCommand("INSERT INTO tblCash(ProductID,transno, out_ClientReportnumb, product_id, price, QTY , sdate , fatora_id)VALUES(@ProductID,@transno, @out_ClientReportnumb, @product_id, @price, @QTY, @sdate, @fatora_id)", cn);
                                cm.Parameters.AddWithValue("@ProductID", prodid);
                                cm.Parameters.AddWithValue("@transno", cash.lblTranNo.Text);
                                cm.Parameters.AddWithValue("@out_ClientReportnumb", cash.lblCReport.Text);
                                cm.Parameters.AddWithValue("@product_id", pcode);
                                cm.Parameters.AddWithValue("@price", price);
                                cm.Parameters.AddWithValue("@QTY", int.Parse(txtQty.Text));
                                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                                cm.Parameters.AddWithValue("@fatora_id", fatoracode);
                                cm.ExecuteNonQuery();
                                cn.Close();
                                cash.txtBarcode.Clear();
                                cash.txtBarcode.Focus();
                                cash.LoadCart();
                                this.Close();
                            }
                            else
                            {
                                cn.Open();
                                cm = new SqlCommand("INSERT INTO tblCash(ProductID,transno, out_ClientReportnumb, product_id, price, QTY , sdate , fatora_id)VALUES(@ProductID,@transno, @out_ClientReportnumb, @product_id, @price, @QTY, @sdate, @fatora_id" +
                                    ")", cn);
                                cm.Parameters.AddWithValue("@ProductID", prodid);
                                cm.Parameters.AddWithValue("@transno", cash.lblTranNo.Text);
                                cm.Parameters.AddWithValue("@out_ClientReportnumb", cash.lblCReport.Text);
                                cm.Parameters.AddWithValue("@product_id", pcode);
                                cm.Parameters.AddWithValue("@price", price);
                                cm.Parameters.AddWithValue("@QTY", int.Parse(txtQty.Text));
                                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                                cm.Parameters.AddWithValue("@fatora_id", fatoracode);
                                cm.ExecuteNonQuery();
                                cn.Close();
                                cash.txtBarcode.Clear();
                                cash.txtBarcode.Focus();
                                cash.LoadCart();
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }
    }
}
