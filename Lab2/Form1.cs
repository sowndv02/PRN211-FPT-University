using Lab2.DAL;
using Lab2.Logic;
using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {

        List<Student> students;
        List<Major> majors;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbId.Text = (-1).ToString();
            LoadStudent();
            LoadMajors();
        }

        private void LoadMajorsToPanel()
        {
            majors = MajorDAO.GetAllMajors();
            cbMajor.DataSource = majors;
            cbMajor.ValueMember = "Code";
            cbMajor.DisplayMember = "Title";
        }

        private void LoadMajors()
        {
            majors = MajorDAO.GetAllMajors();
            Major m = new Major() { Code = "All Majors", Title = "All Majors" };
            majors.Insert(0, m);
            cbMajor1.DataSource = majors;
            cbMajor1.ValueMember = "Code";
            cbMajor1.DisplayMember = "Title";
        }

        private void LoadStudent()
        {
            LoadMajorsToPanel();
            students = StudentDAO.GetAllStudents();
            dataGridView1.DataSource = students;
            dataGridView1.Columns.Clear();
            DesingDataGridView();
        }

        private void DesingDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("Dob", "Date of Birth");
            dataGridView1.Columns.Add("Major", "Major");
            DataGridViewCheckBoxColumn isActive = new DataGridViewCheckBoxColumn();
            isActive.HeaderText = "Active";
            isActive.Name = "Active";
            dataGridView1.Columns.Add(isActive);
            dataGridView1.Columns.Add("Scholarship", "Scholarship");

            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            dataGridView1.Columns["Name"].DataPropertyName = "Name";
            dataGridView1.Columns["Gender"].DataPropertyName = "Gender";
            dataGridView1.Columns["Dob"].DataPropertyName = "Dob";
            dataGridView1.Columns["Scholarship"].DataPropertyName = "Scholarship";
            dataGridView1.Columns["Active"].DataPropertyName = "Active";
            dataGridView1.Columns["Major"].DataPropertyName = "MajorTitle";
            dataGridView1.ReadOnly = true;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["Gender"].Index)
            {
                if (e.Value is bool gender)
                {
                    e.Value = gender ? "Male" : "Female";
                    e.FormattingApplied = true;
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Student curStudent = students[e.RowIndex];
            LoadStudentToPanel(curStudent);
        }


        private void LoadStudentToPanel(Student student)
        {

            tbId.Text = student.Id;
            tbName.Text = student.Name;
            if (student.Gender) male.Checked = true;
            else female.Checked = true;

            dob.Value = student.Dob;

            numScholarShip.Value = Convert.ToDecimal(student.Scholarship);
            cbActive.Checked = student.Active;
            cbMajor.ValueMember = "Code";
            cbMajor.DisplayMember = "Title";
            cbMajor.DataSource = majors;
            cbMajor.SelectedValue = student.MajorStudent.Code;

        }

        private void ClearPanelControls(Control panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    if (((TextBox)control).Name.Equals("tbId")) ((TextBox)control).Text = (-1).ToString();
                    else ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                if (control.HasChildren)
                {
                    ClearPanelControls(control);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Equals("-1"))
            {
                MessageBox.Show("Please choose student");
                return;
            }
            string sid = tbId.Text.ToString();
            DialogResult result = MessageBox.Show($"You want delete {tbName.Text}?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int count = StudentDAO.DeleteStudent(sid);
                if (count > 0) MessageBox.Show("Delete Sucessful");
                else MessageBox.Show("Delete Fail!");
                LoadStudent();
                ClearPanelControls(tableLayoutPanel1);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!tbId.Text.Equals("-1"))
            {
                MessageBox.Show("Please Clear and Input new Data!");
                return;
            }
            DateTime selectedDate = dob.Value;
            int age = StudentManager.CalculateAge(selectedDate);
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("Please fill input");
                return;
            }
            if ((male.Checked == false && female.Checked == false))
            {
                MessageBox.Show("Please choice Gender");
                return;
            }
            if (age < 18)
            {
                MessageBox.Show("Please choice age >= 18");
                return;
            }
            if (numScholarShip.Value < 0)
            {
                MessageBox.Show("Please input scholarShip >= 0");
                return;
            }
            string id = StudentManager.GetNextStudentId(students[students.Count - 1].Id);
            Major major = majors.FirstOrDefault(m => m.Code.Equals(cbMajor.SelectedValue.ToString()));

            Student s = new Student(
                id,
                tbName.Text,
                male.Checked,
                dob.Value,
                Convert.ToDouble(numScholarShip.Value),
                cbActive.Checked,
                major
                );
            int count = StudentDAO.AddStudent(s);
            if (count > 0)
                MessageBox.Show("Add Successful!");
            else MessageBox.Show("Add Error");
            ClearPanelControls(tableLayoutPanel1);
            LoadStudent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearPanelControls(tableLayoutPanel1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Equals("-1"))
            {
                MessageBox.Show("Please choose student!");
                return;
            }
            DateTime selectedDate = dob.Value;
            int age = StudentManager.CalculateAge(selectedDate);
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("Please fill input");
                return;
            }
            if ((male.Checked == false && female.Checked == false))
            {
                MessageBox.Show("Please choice Gender");
                return;
            }
            if (age < 18)
            {
                MessageBox.Show("Please choice age >= 18");
                return;
            }
            if (numScholarShip.Value < 0)
            {
                MessageBox.Show("Please input scholarShip >= 0");
                return;
            }
            Major major = majors.FirstOrDefault(m => m.Code.Equals(cbMajor.SelectedValue.ToString()));
            Student s = new Student(
                tbId.Text,
                tbName.Text,
                male.Checked,
                dob.Value,
                Convert.ToDouble(numScholarShip.Value),
                cbActive.Checked,
                major
                );
            int count = StudentDAO.UpdateStudent(s);
            if (count > 0)
                MessageBox.Show("Update Successful!");
            else MessageBox.Show("Update Fail");
            ClearPanelControls(tableLayoutPanel1);
            LoadStudent();
        }

        private void cbMajor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = cbMajor1.SelectedValue.ToString();
            if (code.Equals("All Majors"))
            {
                LoadStudent();
            }
            else
            {
                List<Student> list = students.Where(s => s.MajorStudent.Code.Equals(code)).ToList();
                dataGridView1.DataSource = list;
                LoadMajorsToPanel();
                dataGridView1.Columns.Clear();
                DesingDataGridView();
            }
        }
    }
}