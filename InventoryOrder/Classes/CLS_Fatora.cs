using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryOrder.Classes
{
    class CLS_Fatora
    {
        SqlDataReader dr;

        public DataTable SearchFatora(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@Fatora_ID", SqlDbType.VarChar,50);
            parameter[0].Value = ID;
            dt = dal.selectData("Sp_Searchfatora", parameter);
            dal.close();
            return dt;
        }
        public DataTable loadFatora()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dataTable = new DataTable();
            dataTable = dal.selectData("Sp_GetAllFatora", null);
            dal.close();
            return dataTable;
        }
        public DataTable veirfyFatoraID(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@Fatora_ID", SqlDbType.VarChar,50);
            parameter[0].Value = ID;
            dt = dal.selectData("Sp_VerifyFatoraID", parameter);
            dal.close();
            return dt;
        }
    }
}
