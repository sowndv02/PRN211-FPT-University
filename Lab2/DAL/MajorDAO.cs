using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.DAL
{
    internal class MajorDAO
    {
        public static List<Major> GetAllMajors()
        {
            string sql = "Select * from Major";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Major> majors = new List<Major>();
            foreach (DataRow dr in dt.Rows)
            {
                majors.Add(new Major(
                    dr["Code"].ToString(),
                    dr["Title"].ToString()
                    ));
            }

            return majors;
        }
    }
}
