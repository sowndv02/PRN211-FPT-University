using Q1_SamplePE_Fall21B5.DAL;
using Q1_SamplePE_Fall21B5.Model;

namespace Q1_SamplePE_Fall21B5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGridView();
            LoadDefault();
        }

        private void LoadComboBox()
        {
            List<string> lists = new List<string>
            {
                "All positions",
                "Developer",
                "Leader",
                "Tester",
                "Manager"
            };
            cbPosition.DataSource = lists;

        }
        private void LoadDefault()
        {
            cbPosition.SelectedIndex = 0;
            tbName.Text = string.Empty;
            MF.Checked = true;
        }

        private void LoadDataGridView()
        {
            List<Employee> employees = EmployeeDAO.GetAllEmployees(); ;
            if(!string.IsNullOrEmpty(tbName.Text))
            {
                employees = employees.Where(x => x.Name.Contains(tbName.Text)).ToList();
            }
            if(cbPosition.SelectedIndex != 0) 
            {
                employees = employees.Where(x => x.Position.Equals(cbPosition.SelectedItem as string)).ToList();
            }
            if (Male.Checked || Female.Checked)
            {
                if(Male.Checked)
                    employees = employees.Where(x => x.Sex.Equals("Male")).ToList();
                else
                    employees = employees.Where(x => x.Sex.Equals("Female")).ToList();
            }

            dataGridView1.DataSource = employees;

        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}