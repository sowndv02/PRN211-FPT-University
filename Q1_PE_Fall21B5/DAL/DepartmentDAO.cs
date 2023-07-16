using Q1_PE_Fall21B5.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_PE_Fall21B5.DAL
{
    internal class DepartmentDAO
    {
        public List<Department> GetAllDepartments()
        {
            string sql = "Select * from Department";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Department> list = new List<Department>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Department(
                    Convert.ToInt32(dr["ID"]),
                    dr["Name"].ToString()
                    ));
            }
            return list;
        }


        public static Department GetDepartmentById(int id)
        {
            string sql = "Select * from Department where Id = @id";
            SqlParameter parameter1 = new SqlParameter("@id", DbType.Int32);
            parameter1.Value = id;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if (dt.Rows.Count == 0) return null;
            DataRow dr = dt.Rows[0];
            return new Department(
                    Convert.ToInt32(dr["ID"]),
                    dr["Name"].ToString()
                    );
        }

    }
}
