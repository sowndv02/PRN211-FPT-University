using DemoADOModels.DAL;
using DemoADOModels.Logic;
using DemoADOModels.Models;
using System.Linq;
using System.Windows.Forms;

namespace DemoADOModels
{
    public partial class Form1 : Form
    {
        List<Student> students;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormatDataGridView();
            LoadStudent();
        }

        private void LoadStudent()
        {
            students = StudentDAO.GetAllStudents();
            dtg1.DataSource = students;
        }


        private List<Student> SearchStudentV1(string key, List<Student> students)
        {
            var result = from student in students
                         where student.FirstName.Contains(key) || student.LastName.Contains(key) || student.MidName.Contains(key)
                         select student;

            return result.ToList();
        }

        private List<Student> SearchStudentV2(string key, List<Student> students)
        {
            var result = students.Where(x => x.FirstName.Contains(key) || x.LastName.Contains(key) || x.MidName.Contains(key)).ToList();
            return result;
        }
        private List<Student> SearchStudentV3(string key)
        {
            List<Student> list = StudentDAO.SearchStudentByName(key);
            return list;
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg1.Columns[e.ColumnIndex].Name.Equals("editcol")) //bấm vào cột edit
            {
                Student curStudent = students[e.RowIndex];
                frmEditStudent frmEditStudent = new frmEditStudent(curStudent);
                frmEditStudent.FormClosed += frmEditForm_Close;
                frmEditStudent.Show();
            }

            if (dtg1.Columns[e.ColumnIndex].Name.Equals("delcol")) //Bấm vào cột delete
            {
                Student curStudent = students[e.RowIndex];
                DialogResult result = MessageBox.Show($"You want delete {curStudent.FullName}?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    StudentDAO.DeleteStudent(curStudent.StudentId);
                    LoadStudent();
                }

            }
        }
        private void frmEditForm_Close(object sender, EventArgs e)
        {
            LoadStudent();
        }


        private void FormatDataGridView()
        {
            dtg1.AutoGenerateColumns = false;

            dtg1.Columns.Add("studentId", "StudentId");
            dtg1.Columns["studentId"].DataPropertyName = "StudentId";

            dtg1.Columns.Add("rollcol", "RollNumber");
            dtg1.Columns["rollcol"].DataPropertyName = "RollNumber";

            dtg1.Columns.Add("fullname", "StudentName");
            dtg1.Columns["fullname"].DataPropertyName = "FullName";

            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "editcol";
            editCol.HeaderText = "Action";
            editCol.Text = "Update";
            editCol.UseColumnTextForButtonValue = true;
            dtg1.Columns.Add(editCol);

            DataGridViewLinkColumn delCol = new DataGridViewLinkColumn();
            delCol.Name = "delcol";
            delCol.HeaderText = "Action";
            delCol.Text = "Delete";
            delCol.UseColumnTextForLinkValue = true;
            dtg1.Columns.Add(delCol);
        }


        //Search character
        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Student> students = StudentDAO.GetAllStudents();
            List<Student> search = students.Where(x => x.MidName.Contains(tbSearch.Text)
            || x.FirstName.Contains(tbSearch.Text) || x.LastName.Contains(tbSearch.Text)).ToList();
            dtg1.DataSource = search;
        }*/

        // Search with UTF-8
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Student> students = StudentDAO.GetAllStudents();
            string searchText = tbSearch.Text.ToLower();

            List<Student> search = StudentManager.SearchStudent(students, searchText);

            dtg1.DataSource = search;
        }


        private void SetFullscreen()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddStudent = new frmAddStudent();
            frmAddStudent.FormClosed += frmEditForm_Close;
            frmAddStudent.Show();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            frmOtherType frmOtherType = new frmOtherType();
            frmOtherType.Show();
        }
    }
}