using DemoADOModels.DAL;
using DemoADOModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoADOModels
{
    public partial class frmEditStudent : Form
    {
        public Student CurrentStudent { get; }
        public frmEditStudent(Student student)
        {
            CurrentStudent = student;
            InitializeComponent();
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            tbStudentId.Text = CurrentStudent.StudentId.ToString();
            tbRoll.Text = CurrentStudent.RollNumber.ToString();
            tbFirstName.Text = CurrentStudent.FirstName.ToString();
            tbMidName.Text = CurrentStudent.MidName.ToString();
            tbLastName.Text = CurrentStudent.LastName.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                Convert.ToInt32(tbStudentId.Text),
                tbRoll.Text,
                tbFirstName.Text,
                tbMidName.Text,
                tbLastName.Text
                );

            int count = StudentDAO.UpdateStudent(student);
            if (count > 0)
                MessageBox.Show("Edit Successful!");
            else MessageBox.Show("Edit Error");
            this.Close();
        }
    }
}
