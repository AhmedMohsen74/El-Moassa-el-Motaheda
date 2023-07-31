using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryOrder.Classes
{
    class CLS_Products
    {
        SqlDataReader dr;
        public DataTable loadproducts()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dataTable = new DataTable();
            dataTable = dal.selectData("Sp_GetAllProducts", null);
            dal.close();
            return dataTable;
        }

        public DataTable veirfyproductID(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@Product_id", SqlDbType.VarChar,50);
            parameter[0].Value = ID;
            dt = dal.selectData("Sp_VerifyProductID", parameter);
            dal.close();
            return dt;
        }

        public DataTable SearchProducts(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@Product_id", SqlDbType.VarChar,50);
            parameter[0].Value = ID;
            dt = dal.selectData("Sp_SearchProduct", parameter);
            dal.close();
            return dt;
        }

    }
}
