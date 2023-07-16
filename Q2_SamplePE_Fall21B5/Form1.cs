using Q2_SamplePE_Fall21B5.Models;

namespace Q2_SamplePE_Fall21B5
{
    public partial class Form1 : Form
    {
        List<Employee> emps;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            using (var context = new PE_Fall21B5Context())
            {
                emps = context.Employees.ToList();
                dataGridView1.DataSource = emps;
                dataGridView1.Columns["DepartmentNavigation"].Visible = false;
            }
        }

        private void LoadComboBox()
        {
            using (var context = new PE_Fall21B5Context())
            {
                List<string> lists = context.Employees.Select(x => x.Position).Distinct().ToList();
                cbPosition.DataSource = lists;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new PE_Fall21B5Context())
            {
                Employee employee = new Employee();
                employee.Name = tbName.Text;
                employee.Position = cbPosition.SelectedItem as string;
                if (Male.Checked) employee.Sex = "Male";
                if (Female.Checked) employee.Sex = "Female";
                employee.Dob = dob.Value;
                context.Employees.Add(employee);
                context.SaveChanges();
                LoadDataGridView();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbId.Text = string.Empty;
            tbName.Text = string.Empty;
            Male.Checked = false;
            Female.Checked = false; 
            dob.Value = DateTime.Now;
            cbPosition.SelectedIndex = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using(var context = new PE_Fall21B5Context())
            {
                Employee emp = context.Employees.Where(x => x.Id == Convert.ToInt32(tbId.Text)).FirstOrDefault();
                emp.Name = tbName.Text;
                emp.Dob = dob.Value;    
                emp.Position = cbPosition.SelectedItem as string;
                if (Male.Checked) emp.Sex = "Male";
                if (Female.Checked) emp.Sex = "Female";
                context.SaveChanges();
                LoadDataGridView();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employee = emps[e.RowIndex];   
            LoadCurrentEmployee(employee);
        }

        private void LoadCurrentEmployee(Employee employee)
        {
            tbId.Text = employee.Id.ToString();
            tbName.Text = employee.Name.ToString();
            if (employee.Sex.Equals("Male")) Male.Checked = true;
            else Female.Checked = true;
            dob.Value = employee.Dob;
            cbPosition.SelectedItem = employee.Position;    
        }
    }
}