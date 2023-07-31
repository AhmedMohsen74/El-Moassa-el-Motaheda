using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace InventoryOrder.DAL
{
    class DataAccessLayer
    {
        SqlConnection cn;
        public string CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
        private string con;
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
       
        
        public DataAccessLayer()
        {
            cn = new SqlConnection(@"data source=DESKTOP-MTGIS8R; database= InventoryDB ; integrated security = SSPI");
            //cn = new SqlConnection(@"data source=DESKTOP-796GM96; database= InventoryDB ; integrated security = SSPI");
        }

        public void open()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }

        public void close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        //method to read data from database
        public DataTable selectData(string stored_procedure, SqlParameter[] param)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procedure;

                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        cmd.Parameters.Add(param[i]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void executeCommond(string stored_procedure, SqlParameter[] param)
        {
            using (SqlConnection cn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procedure;
                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                cmd.ExecuteNonQuery();
            }
        }

        
        public void ExecuteQuery(String sql)
        {
            try
            {
               // cn.ConnectionString = myConnection();
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
