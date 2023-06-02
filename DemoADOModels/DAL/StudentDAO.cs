using DemoADOModels.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace DemoADOModels.DAL
{
    class StudentDAO
    {
        public static List<Student> GetAllStudents()
        {
            string sql = "Select * from Students";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
            {
                students.Add(new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["Roll#"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["MidName"].ToString(),
                    dr["LastName"].ToString()
                    ));
            }

            return students;
        }

        public static List<Student> SearchStudentByName(string key)
        {
            List<Student> students = new List<Student>();
            string sql = "SELECT * FROM Students WHERE FirstName like @key OR MidName like @key OR LastName like @key";
            SqlParameter parameter = new SqlParameter("@key", SqlDbType.NVarChar);
            parameter.Value = "%" + key + "%";
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            foreach (DataRow dr in dt.Rows)
            {
                students.Add(new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["Roll#"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["MidName"].ToString(),
                    dr["LastName"].ToString()
                    ));
            }
            return students;
        }


        public static Student GetStudentById(int id)
        {
            string sql = "Select * from Students where StudentId = @sid";
            SqlParameter parameter1 = new SqlParameter("@sid", DbType.Int32);
            parameter1.Value = id;
            SqlParameter  parameter2 = null;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            //DataTable dt = DAO.GetDataBySql(sql, parameter1, parameter2); // Khi sd từ khoá params thì tự nhóm 2 thằng này thành 1 mảng
            if (dt.Rows.Count == 0) return null;
            DataRow dr = dt.Rows[0];
            return new Student(
                    Convert.ToInt32(dr["StudentId"]),
                    dr["Roll#"].ToString(),
                    dr["FirstName"].ToString(),
                    dr["MidName"].ToString(),
                    dr["LastName"].ToString()
                    );
        }


        public static int UpdateStudent(Student student)
        {
            String sql = "UPDATE Students Set Roll# = @roll, FirstName = @fname, MidName = @mname, LastName = @lname WHERE studentId = @sid";
            SqlParameter parameter1 = new SqlParameter("@roll", SqlDbType.NVarChar);
            parameter1.Value = student.RollNumber;
            SqlParameter parameter2 = new SqlParameter("@fname", SqlDbType.NVarChar);
            parameter2.Value = student.FirstName;
            SqlParameter parameter3 = new SqlParameter("@mname", SqlDbType.NVarChar);
            parameter3.Value = student.MidName;
            SqlParameter parameter4 = new SqlParameter("@lname", SqlDbType.NVarChar);
            parameter4.Value = student.LastName;
            SqlParameter parameter5 = new SqlParameter("@sid", SqlDbType.Int);
            parameter5.Value = student.StudentId;
            return DAO.ExcuteBySql(sql, parameter1, parameter2, parameter3, parameter4, parameter5);
        }

        public static int AddStudent(Student student)
        {
            String sql = "INSERT INTO Students(Roll#, FirstName, MidName, LastName) VALUES(@roll, @fname, @mname, @lname)";
            SqlParameter parameter1 = new SqlParameter("@roll", SqlDbType.NVarChar);
            parameter1.Value = student.RollNumber;
            SqlParameter parameter2 = new SqlParameter("@fname", SqlDbType.NVarChar);
            parameter2.Value = student.FirstName;
            SqlParameter parameter3 = new SqlParameter("@mname", SqlDbType.NVarChar);
            parameter3.Value = student.MidName;
            SqlParameter parameter4 = new SqlParameter("@lname", SqlDbType.NVarChar);
            parameter4.Value = student.LastName;
            return DAO.ExcuteBySql(sql, parameter1, parameter2, parameter3, parameter4);
        }

        public static int DeleteStudent(int studentID)
        {

            string sql = "DELETE FROM Roll_Call_Books where StudentId = @sid";
            SqlParameter parameter1 = new SqlParameter("@sid", DbType.Int32);
            parameter1.Value = studentID;
            DAO.ExcuteBySql(sql, parameter1);

            sql = "DELETE FROM Student_Course WHERE StudentId = @sid";
            parameter1 = new SqlParameter("@sid", DbType.Int32);
            parameter1.Value = studentID;
            DAO.ExcuteBySql(sql, parameter1);

            sql = "Delete from students where studentId = @sid";
            parameter1 = new SqlParameter("@sid", DbType.Int32);
            parameter1.Value = studentID;

            return DAO.ExcuteBySql(sql, parameter1);
        }

    }
}
