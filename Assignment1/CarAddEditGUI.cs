using Assignment1.Logic;
using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class CarAddEditGUI : Form
    {
        private Car car;
        private string username;
        public CarAddEditGUI(Car car, string username)
        {
            this.car = car;
            this.username = username;
            InitializeComponent();
        }

        private void CarAddEditGUI_Load(object sender, EventArgs e)
        {
            LoadCarData();
        }
        private void LoadCarData()
        {
            if (car != null)
            {
                string color = CarManager.UppercaseFirstCharacter(car.Color);
                tbCarId.Text = car.CarId.ToString();
                tbColor.Text = color;
                tbMake.Text = car.Make;
                tbPetName.Text = car.PetName;
                tbHexColor.BackColor = CarManager.GetColorFromName(color);
            }
            if (car == null)
            {
                tbCarId.Text = (-1).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCarGUI frmCarGUI = new frmCarGUI(username);
            frmCarGUI.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbColor.Text.Trim()) && string.IsNullOrEmpty(tbMake.Text.Trim()) && string.IsNullOrEmpty(tbPetName.Text.Trim())) 
            {
                MessageBox.Show("Please fill input");
            }
            else
            {
                string color = tbColor.Text;
                int carId = Convert.ToInt32(tbCarId.Text);
                if (color.StartsWith("#"))
                {
                    color = CarManager.GetColorNameFromHex(color);
                }
                if (carId == -1)
                {
                    Car c = new Car(tbMake.Text.Trim(), color, tbPetName.Text.Trim());
                    CarManager.AddCar(c);
                    MessageBox.Show("A new Car is added!");
                    car = c;
                }
                if (carId != -1)
                {
                    Car c = new Car(Convert.ToInt32(tbCarId.Text), tbMake.Text.Trim(), color, tbPetName.Text.Trim());
                    CarManager.EditCar(c);
                    MessageBox.Show("This Car is update!");
                    car = c;
                }
                LoadCarData();
            }
        }

        private void tbColor_TextChanged(object sender, EventArgs e)
        {
            string color = CarManager.UppercaseFirstCharacter(tbColor.Text);
            tbHexColor.BackColor = CarManager.GetColorFromName(color);
        }

        private void tbColor_Leave(object sender, EventArgs e)
        {
            string hexColor = tbColor.Text;
            if(hexColor.StartsWith("#"))
            {
                Color color = CarManager.GetColorFromHex(hexColor);
                tbHexColor.BackColor = color;
            }
            else
            {
                string color = CarManager.UppercaseFirstCharacter(tbColor.Text);
                tbHexColor.BackColor = CarManager.GetColorFromName(color);
            }
            
        }
    }
}
