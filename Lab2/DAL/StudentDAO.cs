using Lab2.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace Lab2.DAL
{
    class StudentDAO
    {
        static DateTime date = new DateTime(2022, 12, 12);
        public static List<Student> GetAllStudents()
        {
            List<Major> majors = MajorDAO.GetAllMajors();
            string sql = "Select * from Student";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
            {
                students.Add(new Student(
                    dr["Id"].ToString(),
                    dr["Name"].ToString(),
                    dr["Gender"] is DBNull ? false : Convert.ToBoolean(dr["Gender"]),
                    dr["Dob"] is DBNull ? date : Convert.ToDateTime(dr["Dob"]),
                    Convert.ToDouble(dr["Scholarship"]),
                    dr["Active"] is DBNull ? false : Convert.ToBoolean(dr["Gender"]),
                    majors.FirstOrDefault(m => m.Code.Equals(dr["Major"].ToString()))
                    ));
            }

            return students;
        }

        

        public static List<Student> SearchStudentByName(string key)
        {
            List<Major> majors = MajorDAO.GetAllMajors();
            List<Student> students = new List<Student>();
            string sql = "SELECT * FROM Student WHERE Name like @key";
            SqlParameter parameter = new SqlParameter("@key", SqlDbType.NVarChar);
            parameter.Value = "%" + key + "%";
            DataTable dt = DAO.GetDataBySql(sql, parameter);
            foreach (DataRow dr in dt.Rows)
            {
                students.Add(new Student(
                    dr["Id"].ToString(),
                    dr["Name"].ToString(),
                    dr["Gender"] is DBNull ? false : Convert.ToBoolean(dr["Gender"]),
                    dr["Dob"] is DBNull ? date : Convert.ToDateTime(dr["Dob"]),
                    Convert.ToDouble(dr["Scholarship"]),
                    dr["Active"] is DBNull ? false : Convert.ToBoolean(dr["Gender"]),
                    majors.FirstOrDefault(m => m.Code.Equals(dr["Major"].ToString()))
                    ));
            }
            return students;
        }


        public static Student GetStudentById(string id)
        {
            List<Major> majors = MajorDAO.GetAllMajors();
            string sql = "Select * from Student where Id = @sid";
            SqlParameter parameter1 = new SqlParameter("@sid", DbType.Int32);
            parameter1.Value = id;
            SqlParameter  parameter2 = null;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if (dt.Rows.Count == 0) return null;
            DataRow dr = dt.Rows[0];
            return new Student(
                    dr["Id"].ToString(),
                    dr["Name"].ToString(),
                    dr["Gender"] is DBNull ? false : Convert.ToBoolean(dr["Gender"]),
                    dr["Dob"] is DBNull ? date : Convert.ToDateTime(dr["Dob"]),
                    Convert.ToDouble(dr["Scholarship"]),
                    dr["Active"] is DBNull ? false : Convert.ToBoolean(dr["Gender"]),
                    majors.FirstOrDefault(m => m.Code.Equals(dr["Major"].ToString()))
                    );
        }


        public static int UpdateStudent(Student student)
        {
            String sql = "UPDATE Student SET Name = @name, Gender = @gender, Dob = @dob, Major = @major, Scholarship = @scholarship, Active = @active WHERE Id = @id";
            SqlParameter parameter1 = new SqlParameter("@name", SqlDbType.NVarChar);
            parameter1.Value = student.Name;

            SqlParameter parameter2 = new SqlParameter("@dob", SqlDbType.Date);
            parameter2.Value = student.Dob;

            SqlParameter parameter3 = new SqlParameter("@gender", SqlDbType.Bit);
            parameter3.Value = student.Gender;

            SqlParameter parameter4 = new SqlParameter("@major", SqlDbType.VarChar);
            parameter4.Value = student.MajorStudent.Code;

            SqlParameter parameter5 = new SqlParameter("@scholarship", SqlDbType.Float);
            parameter5.Value = student.Scholarship;

            SqlParameter parameter6 = new SqlParameter("@active", SqlDbType.Bit);
            parameter6.Value = student.Active;

            SqlParameter parameter7 = new SqlParameter("@id", SqlDbType.VarChar);
            parameter7.Value = student.Id;

            return DAO.ExcuteBySql(sql, parameter1, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7);
        }

        public static int AddStudent(Student student)
        {
            String sql = "INSERT INTO Student(Id, Name, Gender, Dob, Major, Scholarship, Active) VALUES(@id, @name, @gender, @dob, @major, @scholarship, @active)";
            SqlParameter parameter1 = new SqlParameter("@id", SqlDbType.VarChar);
            parameter1.Value = student.Id;

            SqlParameter parameter2 = new SqlParameter("@name", SqlDbType.NVarChar);
            parameter2.Value = student.Name;

            SqlParameter parameter3 = new SqlParameter("@gender", SqlDbType.Bit);
            parameter3.Value = student.Gender;

            SqlParameter parameter4 = new SqlParameter("@major", SqlDbType.VarChar);
            parameter4.Value = student.MajorStudent.Code;

            SqlParameter parameter5 = new SqlParameter("@scholarship", SqlDbType.Float);
            parameter5.Value = student.Scholarship;

            SqlParameter parameter6 = new SqlParameter("@active", SqlDbType.Bit);
            parameter6.Value = student.Active;

            SqlParameter parameter7 = new SqlParameter("@dob", SqlDbType.Date);
            parameter7.Value = student.Dob;
            return DAO.ExcuteBySql(sql, parameter1, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7);
        }

        public static int DeleteStudent(string studentID)
        {

            String sql = "Delete from student where Id = @id";
            SqlParameter parameter1 = new SqlParameter("@id", SqlDbType.VarChar);
            parameter1.Value = studentID;

            return DAO.ExcuteBySql(sql, parameter1);
        }

    }
}
