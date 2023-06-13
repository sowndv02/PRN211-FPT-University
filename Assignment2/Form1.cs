using Assignment2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        private List<RollCallBook> modifiedRollCallBooks = new List<RollCallBook>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }


        private void LoadCourses()
        {
            using (var context = new APDatabaseContext())
            {
                List<Course> courses = context.Courses.ToList();
                cbCourse.DisplayMember = "CourseCode";
                cbCourse.ValueMember = "CourseId";
                cbCourse.DataSource = courses;
            }

        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSchedule();
            
        }

        public void LoadSchedule()
        {
            using (var context = new APDatabaseContext())
            {
                int cid = Convert.ToInt32(cbCourse.SelectedValue);
                List<CourseSchedule> schedules = context.CourseSchedules.Where(x => x.CourseId == cid).ToList();
                cbSchedule.DisplayMember = "TeachingDate";
                cbSchedule.ValueMember = "TeachingScheduleId";
                cbSchedule.DataSource = schedules;
            }
        }

        private void LoadStudent()
        {
            DesiginDataGridView();
            using (var context = new APDatabaseContext())
            {
                int courseId = Convert.ToInt32(cbCourse.SelectedValue);
                int scheduleId = Convert.ToInt32(cbSchedule.SelectedValue.ToString());

                var students = context.Students
            .Include(s => s.RollCallBooks)
            .Where(s => s.Courses.Any(c => c.CourseId == courseId))
            .Select(s => new Student
            {
                StudentId = s.StudentId,
                Roll = s.Roll,
                FirstName = s.FirstName,
                LastName = s.LastName,
                IsAbsent = s.RollCallBooks.Any(r => r.TeachingScheduleId == scheduleId && r.IsAbsent == true)
            })
            .ToList();



                dataGridView1.DataSource = students;
            }
        }


        private void DesiginDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("studentId", "StudentId");
            dataGridView1.Columns["studentId"].DataPropertyName = "StudentId";

            dataGridView1.Columns.Add("rollcol", "RollNumber");
            dataGridView1.Columns["rollcol"].DataPropertyName = "RollNumber";

            dataGridView1.Columns.Add("firstName", "FirstName");
            dataGridView1.Columns["firstName"].DataPropertyName = "FirstName";

            dataGridView1.Columns.Add("midName", "MidName");
            dataGridView1.Columns["midName"].DataPropertyName = "MidName";

            dataGridView1.Columns.Add("lastName", "LastName");
            dataGridView1.Columns["lastName"].DataPropertyName = "LastName";

            DataGridViewCheckBoxColumn isActive = new DataGridViewCheckBoxColumn();
            isActive.Name = "IsAbsent";
            isActive.HeaderText = "IsAbsent";
            isActive.DataPropertyName = "IsAbsent";
            dataGridView1.Columns.Add(isActive);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("IsAbsent") && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["IsAbsent"];
                bool currentValue = (cell.Value == null || !(bool)cell.Value);
                cell.Value = currentValue;
            }
        }

        private void UpdateRollCallBooks()
        {

            using(var context = new APDatabaseContext()) 
            {
                int TeachingScheduleId = Convert.ToInt32(cbSchedule.SelectedValue.ToString());

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int studentId = Convert.ToInt32(row.Cells["studentId"].Value);
                        bool isAbsent = Convert.ToBoolean(row.Cells["IsAbsent"].Value);
                        RollCallBook rollCallBook = context.RollCallBooks.FirstOrDefault(rb => rb.StudentId == studentId && rb.TeachingScheduleId == TeachingScheduleId);
                        if (rollCallBook != null)
                        {
                            rollCallBook.IsAbsent = isAbsent;
                        }
                    }
                }
                context.SaveChanges();
            }

        }

        private void cbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            LoadStudent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateRollCallBooks();
            MessageBox.Show("Update sucessful!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}