using Q1_SamplePE_BySon_Verson2.Models;

namespace Q1_SamplePE_BySon_Verson2
{
    public partial class Form1 : Form
    {
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
            using (var context = new BookStoreContext())
            {
                dataGridView1.DataSource = context.Customers.ToList();

                //DataGridViewCheckBoxColumn genderColumn = new DataGridViewCheckBoxColumn();
                //genderColumn.HeaderText = "Gender";
                //genderColumn.Name = "Gender";
                //genderColumn.DataPropertyName = "Gender";

                //dataGridView1.Columns["Gender"].Visible = false;
                //dataGridView1.Columns.Insert(2, genderColumn);

                DataGridViewCheckBoxColumn genderColumn2 = new DataGridViewCheckBoxColumn();
                genderColumn2.HeaderText = "Gender2";
                genderColumn2.Name = "Gender2";
                genderColumn2.DataPropertyName = "Gender2"; // Set the DataPropertyName

                dataGridView1.Columns["Gender2"].Visible = false;
                dataGridView1.Columns.Insert(3, genderColumn2);

                


                DataGridViewTextBoxColumn genderColumn3 = new DataGridViewTextBoxColumn();
                genderColumn3.HeaderText = "Gender3";
                genderColumn3.Name = "Gender3";
                genderColumn3.DataPropertyName = "Gender";

                dataGridView1.Columns["Gender"].Visible = false;
                dataGridView1.Columns.Insert(4, genderColumn3);


                dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Gender2"].Index && e.Value != null)
            {
                string gender = e.Value.ToString();
                if (gender == "Male")
                {
                    e.Value = true;
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = false;
                    e.FormattingApplied = true;
                }
            }


            if (e.ColumnIndex == dataGridView1.Columns["Gender3"].Index && e.Value != null)
            {
                bool gender = (bool)e.Value;
                if (gender)
                {
                    e.Value = "Male";
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "Female";
                    e.FormattingApplied = true;
                }
            }

        }



        }
    }