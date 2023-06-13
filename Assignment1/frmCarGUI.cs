using Assignment1.Logic;
using Assignment1.Models;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace Assignment1
{
    public partial class frmCarGUI : Form
    {
        List<Car> cars;
        string defaultText = "Number of Cars: ";
        private string loggedInUser;
        public frmCarGUI(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void frmCarGUI_Load(object sender, EventArgs e)
        {
            CreateNewButton();
            FormatDataGridView();
            LoadCar();
        }

        private bool checkLogin()
        {
            return string.IsNullOrEmpty(loggedInUser);
        }
        private void LoadCar()
        {
            var context = new CarsContext();
            numberOfCars.Text += context.Cars.Count();
            cars = context.Cars.ToList();
            dataGridView1.DataSource = cars;
        }

        public void CreateNewButton()
        {
            LinkLabel btnNewButton = new LinkLabel();

            if (checkLogin())
            {
                btnNewButton.Text = "Login";
                btnNewButton.Name = "login";
                btnNewButton.Click += login_Click;
            }
            else
            {
                btnNewButton.Text = $"Logout({loggedInUser})";
                btnNewButton.Name = "logout";
                btnNewButton.Click += logout_Click;


                Button btnNew = new Button();
                btnNew.Name = "add";
                btnNew.Text = "Add new...";
                btnNew.Location = new Point(12, 43);
                btnNew.Size = new Size(101, 37);
                btnNew.Click += add_Click;
                this.Controls.Add(btnNew);
            }
            btnNewButton.Size = new Size(300, 20);
            btnNewButton.Location = new Point(12, 12);

            this.Controls.Add(btnNewButton);
        }

        private void FormatDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("Make", "Make");
            dataGridView1.Columns["Make"].DataPropertyName = "Make";

            dataGridView1.Columns.Add("Color", "Color");
            dataGridView1.Columns["Color"].DataPropertyName = "Color";

            dataGridView1.Columns.Add("PetName", "PetName");
            dataGridView1.Columns["PetName"].DataPropertyName = "PetName";

            DataGridViewButtonColumn Detail = new DataGridViewButtonColumn();
            Detail.Name = "detail";
            Detail.HeaderText = "Detail";
            Detail.Text = "Detail";
            Detail.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(Detail);
            if (!checkLogin())
            {
                DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                Edit.Name = "edit";
                Edit.HeaderText = "Edit";
                Edit.Text = "Edit";
                Edit.UseColumnTextForButtonValue = true;

                DataGridViewButtonColumn Delete = new DataGridViewButtonColumn();
                Delete.Name = "delete";
                Delete.HeaderText = "Delete";
                Delete.Text = "Delete";
                Delete.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(Edit);
                dataGridView1.Columns.Add(Delete);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("detail"))
            {
                Car curCar = cars[e.RowIndex];
                CarDetailGUI carDetailGUI = new CarDetailGUI(curCar, loggedInUser);
                this.Hide();
                carDetailGUI.Show();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("edit"))
            {
                Car curCar = cars[e.RowIndex];
                CarAddEditGUI addEditGUI = new CarAddEditGUI(curCar, loggedInUser);
                this.Hide();
                addEditGUI.Show();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("delete"))
            {
                Car curCar = cars[e.RowIndex];
                DialogResult result = MessageBox.Show($"Do you want delete?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CarManager.RemoveCar(curCar.CarId);
                    LoadCar();
                }

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            CarAddEditGUI addEditGUI = new CarAddEditGUI(null, loggedInUser);
            this.Hide();
            addEditGUI.Show();
        }


        private void login_Click(object sender, EventArgs e)
        {
            LoginGUI loginGUI = new LoginGUI();
            this.Hide();
            loginGUI.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loggedInUser = null;
            ClearDynamicButtons();
            CreateNewButton();
            dataGridView1.Columns.Clear();
            FormatDataGridView();
            LoadCar();
            numberOfCars.Text = defaultText + cars.Count;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearDynamicButtons()
        {
            var dynamicButtons = this.Controls.OfType<Button>().ToList();

            var dynamicLabels = this.Controls.OfType<LinkLabel>().ToList();

            foreach (var button in dynamicButtons)
            {
                this.Controls.Remove(button);
                button.Dispose();
            }

            foreach (var label in dynamicLabels)
            {
                this.Controls.Remove(label);
                label.Dispose();
            }
        }

    }
}