using Q2_Sample_By_Son.Models;

namespace Q2_Sample_By_Son
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllCombobox();
            LoadGroupBox();
        }

        private void LoadAllCombobox()
        {
            using (var context = new APContext())
            {
                cbCampus.DataSource = context.Campuses.ToList();
                cbCampus.DisplayMember = "CampusName";
                cbCampus.ValueMember = "CampusId";

                cbInstructor.DataSource = context.Instructors.ToList();
                cbInstructor.DisplayMember = "InstructorLastName";
                cbInstructor.ValueMember = "InstructorId";

                cbSubject.DataSource = context.Subjects.ToList();
                cbSubject.DisplayMember = "SubjectName";
                cbSubject.ValueMember = "SubjectId";


                cbTerm.DataSource = context.Terms.ToList();
                cbTerm.DisplayMember = "TermName";
                cbTerm.ValueMember = "TermId";
            }
        }


        private void LoadGroupBox()
        {
            using (var context = new APContext())
            {
                listBox1.DataSource = context.Students.ToList();
                listBox1.DisplayMember = "LastName";
                listBox1.ValueMember = "StudentId";
            }
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            using(var context = new APContext())
            {
                Course course = new Course();
                course.CourseCode = tbCourseCode.Text;
                course.CourseDescription = tbCourseDescription.Text;
                course.InstructorId = (int?)cbInstructor.SelectedValue;
                course.CampusId =  (int?)cbInstructor.SelectedValue;
                course.SubjectId = (int)cbSubject.SelectedValue;
                course.TermId = (int?)cbTerm.SelectedValue;
                List<Student> students = listBox1.SelectedItems.Cast<Student>().ToList();
                foreach(Student student1 in students)
                {
                    if (!context.Students.Local.Contains(student1))
                    {
                       context.Students.Attach(student1);
                    }
                }
                foreach(Student student in students)
                {
                    course.Students.Add(student);
                }
                context.Courses.Add(course);
                context.SaveChanges();
                MessageBox.Show("Done");
            }
        }
    }
}