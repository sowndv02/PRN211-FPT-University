using Microsoft.EntityFrameworkCore;
using Q1_P3.Models;

namespace Q1_P3
{
    public partial class Form1 : Form
    {
        List<string> distinctProvinces;
        private List<string> selectedProvinces;
        List<InfectedCase> infectedCases;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListBox();
            LoadDefault();
            LoadDataGridView();
        }

        private void LoadListBox()
        {
            using (var context = new PRN292_Spr2020_B1Context())
            {
                infectedCases = context.InfectedCases.ToList();
                distinctProvinces = context.InfectedCases
                .Where(ic => ic.Province != null)
                .Select(ic => ic.Province)
                .Distinct()
                .ToList();
                listBoxProvince.DataSource = distinctProvinces;
            }
        }

        private void LoadDefault()
        {
            cbMale.Checked = true;
            string defaultSelection = distinctProvinces.Where(x => x.Equals("Ha Noi")).FirstOrDefault();
            int index = listBoxProvince.FindString(defaultSelection);
            if (index != ListBox.NoMatches)
                listBoxProvince.SetSelected(index, true);

            listBoxProvince.SetSelected(0, false);
        }

        private void DesignDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Age", "Age");
            DataGridViewCheckBoxColumn gender = new DataGridViewCheckBoxColumn();
            gender.HeaderText = "Sex";
            gender.Name = "Gender";
            dataGridView1.Columns.Add(gender);
            dataGridView1.Columns.Add("Nationality", "Nationality");
            dataGridView1.Columns.Add("Province", "Province");
            dataGridView1.Columns.Add("TraveledFrom", "TraveledFrom");
            dataGridView1.Columns.Add("ConfirmationDate", "ConfirmationDate");

            dataGridView1.Columns["Name"].DataPropertyName = "Name";
            dataGridView1.Columns["Age"].DataPropertyName = "Age";
            dataGridView1.Columns["Province"].DataPropertyName = "Province";
            dataGridView1.Columns["TraveledFrom"].DataPropertyName = "TraveledFrom";
            dataGridView1.Columns["ConfirmationDate"].DataPropertyName = "ConfirmationDate";
            dataGridView1.Columns["Nationality"].DataPropertyName = "Nationality";
            dataGridView1.Columns["Gender"].DataPropertyName = "Sex";
            dataGridView1.ReadOnly = true;
        }

        private void LoadDataGridView()
        {
            DesignDataGridView();
            using (var context = new PRN292_Spr2020_B1Context())
            {
                selectedProvinces = listBoxProvince.SelectedItems.Cast<string>().ToList();
                IEnumerable<InfectedCase> filteredCases = infectedCases;
                filteredCases = filteredCases
                .Where(ic => selectedProvinces.Contains(ic.Province))
                .ToList();
                if (!cbMale.Checked && !cbFmale.Checked)
                {
                    filteredCases = new List<InfectedCase>();
                }
                else if (cbMale.Checked && !cbFmale.Checked)
                {
                    filteredCases = filteredCases
                        .Where(ic => ic.Sex == true);
                }
                else if (!cbMale.Checked && cbFmale.Checked)
                {
                    filteredCases = filteredCases
                        .Where(ic => ic.Sex == false);
                }
                dataGridView1.DataSource = filteredCases.ToList();
            }
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }


        private void listBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void cbFmale_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}