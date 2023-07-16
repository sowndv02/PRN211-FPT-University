using Q1_PE_Fall21B5.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q1_PE_Fall21B5.DAL
{
    internal class EmployeeDAO
    {
        static DateTime date = new DateTime(2022, 12, 12);

        public static List<Employee> GetAllEmployees()
        {

            string sql = "Select * from Employee";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Employee> list = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                int depId = Convert.ToInt32(dr["Department"]);
                list.Add(new Employee(
                    Convert.ToInt32(dr["ID"]),
                    dr["Name"].ToString(),
                    dr["Dob"] is DBNull ? date : Convert.ToDateTime(dr["Dob"]),
                    dr["Sex"].ToString(),
                    dr["Position"].ToString(),
                    DepartmentDAO.GetDepartmentById(depId).Id,
                    DepartmentDAO.GetDepartmentById(depId).Name
                    ));
            }

            return list;
        }

        public static List<string> GetAllPositions()
        {
            List<string> list = GetAllEmployees().Where(ic => ic.Position != null)
                .Select(ic => ic.Position)
                .Distinct()
                .ToList();
            return list;
        }
    }
}
