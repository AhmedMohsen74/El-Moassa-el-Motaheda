using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace InventoryOrder.Classes
{
    class CLS_Users
    {
        SqlDataReader dr;
        public DataTable SearchUser(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@userID", SqlDbType.Int);
            parameter[0].Value = ID;
            dt = dal.selectData("Sp_SearchUser", parameter);
            dal.close();
            return dt;
        }

        public DataTable LoadUsers()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dataTable = new DataTable();
            dataTable = dal.selectData("Sp_GetAllUsers", null);
            dal.close();
            return dataTable;
        }

        public void DeleteUser(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@userID", SqlDbType.Int);
            parameter[0].Value = ID;
            dal.executeCommond("Sp_DeleteUser", parameter);
            dal.close();
        }
    }
}
