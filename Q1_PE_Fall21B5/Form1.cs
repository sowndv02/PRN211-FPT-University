using Q1_PE_Fall21B5.DAL;
using Q1_PE_Fall21B5.Model;

namespace Q1_PE_Fall21B5
{
    public partial class Form1 : Form
    {
        List<Employee> list; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genderAll.AutoCheck = true;
            LoadComboBox();
            LoadDataGridView();
        }


        private void LoadComboBox()
        {
            List<string> positions = EmployeeDAO.GetAllPositions();
            positions.Insert(0, "All positions");
            cbPositions.DataSource = positions;
            cbPositions.SelectedIndex = 0;
        }

        private void LoadDataGridView()
        {

            string pos = cbPositions.SelectedItem as string;
            if (pos.Equals("All positions"))
                list = EmployeeDAO.GetAllEmployees().ToList();
            else
                list = EmployeeDAO.GetAllEmployees().Where(x => x.Position.Equals(pos)).ToList();
            if(male.Checked)
                list = list.Where(x => x.Sex.Contains(male.Text)).ToList();
            if(female.Checked)
                list = list.Where(x => x.Sex.Contains(female.Text)).ToList();
            if(genderAll.Checked)
                list = list.Where(x => x.Sex.Contains(male.Text) || x.Sex.Contains(female.Text)).ToList();


            if (!string.IsNullOrEmpty(tbName.Text))
                list = list.Where(x => x.Name.Contains(tbName.Text.ToString())).ToList();

            dataGridView1.DataSource = list;

        }

        private void cbPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void genderAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}