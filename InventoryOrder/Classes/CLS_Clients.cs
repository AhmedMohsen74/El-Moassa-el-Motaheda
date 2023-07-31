using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryOrder.Classes
{
    class CLS_Clients
    {
        SqlDataReader dr;

        public DataTable SearchClient(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@out_ClientReportnumb", SqlDbType.VarChar, 50);
            parameter[0].Value = ID;
            dt = dal.selectData("Sp_SearchClient", parameter);
            dal.close();
            return dt;
        }

        public DataTable loadClients()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dataTable = new DataTable();
            dataTable = dal.selectData("Sp_GetAllClients", null);
            dal.close();
            return dataTable;
        }

        public void DeleteClient(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@out_ClientReportnumb", SqlDbType.VarChar, 50);
            parameter[0].Value = ID;
            dal.executeCommond("Sp_DeleteClient", parameter);
            dal.close();
        }

        public DataTable veirfyClient(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@ClientID", SqlDbType.VarChar, 50);
            parameter[0].Value = ID;
            dt = dal.selectData("Sp_VerifyClient", parameter);
            dal.close();
            return dt;
        }
    }
}
