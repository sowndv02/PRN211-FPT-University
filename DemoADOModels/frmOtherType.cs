using DemoADOModels.DAL;
using DemoADOModels.Logic;
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
    public partial class frmOtherType : Form
    {
        List<Student> students;
        public frmOtherType()
        {
            InitializeComponent();
        }

        private void frmOtherType_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void LoadStudent()
        {
            students = StudentDAO.GetAllStudents();
            dataGridView1.DataSource = students;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Student> list = StudentManager.SearchStudent(students, tbSearch.Text);
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Student curStudent = students[e.RowIndex];
            LoadStudentToPanel(curStudent);
        }

        private void LoadStudentToPanel(Student student)
        {
            tbStudentId.Text = student.StudentId.ToString();
            tbRoll.Text = student.RollNumber.ToString();
            tbFirstName.Text = student.FirstName.ToString();
            tbMidName.Text = student.MidName.ToString();
            tbLastName.Text = student.LastName.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPanelControls(panel1);
        }

        private void ClearPanelControls(Control panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren)
                {
                    ClearPanelControls(control);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if ( string.IsNullOrEmpty(tbFirstName.Text.Trim()) && string.IsNullOrEmpty(tbMidName.Text.Trim()) && string.IsNullOrEmpty(tbMidName.Text.Trim()) && string.IsNullOrEmpty(tbLastName.Text.Trim()))
            {
                MessageBox.Show("Please fill input");
            }
            else
            {
                Student student = new Student(
                tbRoll.Text,
                tbFirstName.Text,
                tbMidName.Text,
                tbLastName.Text
                );
                int count = StudentDAO.AddStudent(student);
                if (count > 0)
                    MessageBox.Show("Add Successful!");
                else MessageBox.Show("Add Error");
                LoadStudent();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(tbFirstName.Text.Trim())
                && string.IsNullOrEmpty(tbMidName.Text.Trim()) && string.IsNullOrEmpty(tbMidName.Text.Trim())
                && string.IsNullOrEmpty(tbLastName.Text.Trim()))
            {
                MessageBox.Show("Please fill input");
            }
            else
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
                LoadStudent();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbStudentId.Text))
            {
                MessageBox.Show("Please choose student");
            }
            int sid = Convert.ToInt32(tbStudentId.Text);
            DialogResult result = MessageBox.Show($"You want delete {tbFirstName.Text} {tbMidName.Text} {tbLastName.Text}?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StudentDAO.DeleteStudent(sid);
                LoadStudent();
                ClearPanelControls(panel1);
            }
        }
    }
}
