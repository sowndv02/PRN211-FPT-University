using Q2_Spring23.Models;

namespace Q2_Spring23
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
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            using (var context = new Other_Spring23Context())
            {
                students = context.Students.ToList();
                dataGridView1.DataSource = students;
                dataGridView1.Columns[dataGridView1.Columns["Classes"].Index].Visible = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Student s = students[e.RowIndex];
            if (s != null)
            {
                LoadStudentDetail(s);
            }
        }
        private void LoadStudentDetail(Student s)
        {
            tbId.Text = s.Id.ToString();
            tbName.Text = s.FullName;
            tbEmail.Text = s.Email;
            if (s.Sex.Equals("Male")) Male.Checked = true;
            tbId.Enabled = false;
            if (s.Sex.Equals("Female")) Female.Checked = true;
            dob.Value = (DateTime)s.Dob;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new Other_Spring23Context())
            {
                Student s = new Student();
                s.Email = tbEmail.Text;
                s.Id = Convert.ToInt32(tbId.Text);
                s.FullName = tbName.Text;
                s.Dob = dob.Value;
                if (Male.Checked) s.Sex = Male.Name;
                if (Female.Checked) s.Sex = Female.Name;
                context.Students.Add(s);
                context.SaveChanges();
                LoadDataGridView();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(tbId.Text);
            using (var context = new Other_Spring23Context())
            {
                Student s = context.Students.Where(x => x.Id == sid).FirstOrDefault();
                s.Email = tbEmail.Text;
                s.Id = Convert.ToInt32(tbId.Text);
                s.FullName = tbName.Text;
                s.Dob = dob.Value;
                if (Male.Checked) s.Sex = Male.Name;
                if (Female.Checked) s.Sex = Female.Name;
                context.SaveChanges();
                LoadDataGridView();
            }
        }

        private void ResetControl()
        {
            tbEmail.Text = string.Empty;
            tbId.Text = string.Empty;
            tbName.Text = string.Empty;
            Male.Checked = false;
            Female.Checked = false;
            dob.Value = DateTime.Now;
            tbId.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}