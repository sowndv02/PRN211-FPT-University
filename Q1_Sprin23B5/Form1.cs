using Q1_Spring23B5;
using System.Data;
using System.Text;

namespace Q1_Sprin23B5
{
    public partial class Form1 : Form
    {
        List<Employee> employees;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            openFileDialog.Title = "Select a Text File";
            employees = new List<Employee>();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                urlPath.Text = filePath;
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    Employee emp = new Employee();
                    emp.ReadDataFromLine(line);
                    employees.Add(emp);
                }
                dataGridView1.DataSource = employees;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

            foreach (DataGridViewRow row in selectedRows)
            {
                if (row.DataBoundItem is Employee selectedEmployee)
                {
                    employees.RemoveAll(emp => emp.Id == selectedEmployee.Id);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employees;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(urlPath.Text))
            {
                StringBuilder sb = new StringBuilder();

                foreach (Employee emp in employees)
                {
                    string line = emp.GetLineFromData();
                    sb.AppendLine(line);
                }

                File.WriteAllText(urlPath.Text, sb.ToString());

                MessageBox.Show("Data saved successfully!");
            }
            else
            {
                MessageBox.Show("No file selected.");
            }
        }

    }
}