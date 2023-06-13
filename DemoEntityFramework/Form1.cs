using DemoEntityFramework.Models;

namespace DemoEntityFramework
{
    public partial class Form1 : Form
    {
        private List<Car> cars;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void FormatDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("CarID", "CarID");
            dataGridView1.Columns["CarID"].DataPropertyName = "CarID";

            dataGridView1.Columns.Add("Make", "Make");
            dataGridView1.Columns["Make"].DataPropertyName = "Make";

            dataGridView1.Columns.Add("Color", "Color");
            dataGridView1.Columns["Color"].DataPropertyName = "Color";

            dataGridView1.Columns.Add("PetName", "PetName");
            dataGridView1.Columns["PetName"].DataPropertyName = "PetName";

            DataGridViewButtonColumn detailCol = new DataGridViewButtonColumn();
            detailCol.Name = "detail";
            detailCol.HeaderText = "Detail";
            detailCol.Text = "Detail";
            detailCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(detailCol);

            DataGridViewButtonColumn editCol = new DataGridViewButtonColumn();
            editCol.Name = "editcol";
            editCol.HeaderText = "Update";
            editCol.Text = "Update";
            editCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editCol);

            DataGridViewButtonColumn delCol = new DataGridViewButtonColumn();
            delCol.Name = "delcol";
            delCol.HeaderText = "Delete";
            delCol.Text = "Delete";
            delCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(delCol);


        }

        private void frmEditForm_Close(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void dtg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("editcol"))
            {
                Car curCar = cars[e.RowIndex];
                frmEditCar frmEditCar = new frmEditCar(curCar);
                frmEditCar.FormClosed += frmEditForm_Close;
                this.Close();
                frmEditCar.Show();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("detail"))
            {
                frmEditCar frmEditCar = new frmEditCar(null);
                frmEditCar.FormClosed += frmEditForm_Close;
                this.Hide();
                frmEditCar.Show();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("delcol"))
            {
                Car carCur = cars[e.RowIndex];
                DialogResult result = MessageBox.Show($"You want delete {carCur.CarId}?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (var context = new CarsContext())
                    {
                        cars.Remove(carCur);
                        context.SaveChanges();
                        LoadCars();
                    }
                }

            }
        }

        private void LoadCars()
        {
            using (var context = new CarsContext())
            {
                cars = context.Cars.ToList();
                dataGridView1.DataSource = cars;
                dataGridView1.Columns.Clear();
                FormatDataGridView();
            }
        }


    }
}