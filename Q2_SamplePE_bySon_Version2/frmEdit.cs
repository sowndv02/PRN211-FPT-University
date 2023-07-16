using Microsoft.EntityFrameworkCore;
using Q2_SamplePE_bySon_Version2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_SamplePE_bySon_Version2
{
    public partial class frmEdit : Form
    {
        int courseId;
        public frmEdit(int Id)
        {
            courseId = Id;
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            LoadStudent();
            textBox1.Text = courseId.ToString();
        }

        private void LoadStudent()
        {
            using (var context = new APContext())
            {
                Course c = context.Courses.Include(x => x.Students).Where(x => x.CourseId == courseId).FirstOrDefault();
                List<Student> students = c.Students.ToList();
                listBox1.DataSource = students;
                listBox1.DisplayMember = "StudentId";
                listBox1.ValueMember = "StudentId";


                List<Student> all = context.Students.AsEnumerable().Except(students).ToList();
                listBox2.DataSource = all;
                listBox2.DisplayMember = "StudentId";
                listBox2.ValueMember = "StudentId";
            }
        }

        private void tbnSave_Click(object sender, EventArgs e)
        {
            List<Student> students = listBox2.SelectedItems.Cast<Student>().ToList();
            List<Student> remove = listBox1.SelectedItems.Cast<Student>().ToList();
            using (var context = new APContext())
            {

                Course c = context.Courses.Include(x => x.Students).Where(x => x.CourseId == Convert.ToInt32(textBox1.Text)).FirstOrDefault();
                foreach (Student student in remove)
                {
                    var studentToRemove = c.Students.FirstOrDefault(s => s.StudentId == student.StudentId);
                    if (studentToRemove != null)
                    {
                        c.Students.Remove(studentToRemove);
                    }
                }
                foreach (var student in students)
                {
                    if (!context.Students.Local.Contains(student))
                    {
                        context.Students.Attach(student);
                    }
                }
                foreach (Student student in students)
                {
                    c.Students.Add(student);

                }
                
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
