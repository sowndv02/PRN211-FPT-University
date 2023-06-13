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
    public partial class CarDetailGUI : Form
    {
        Car car;
        string user;
        public CarDetailGUI(Car car, string user)
        {
            this.car = car;
            this.user = user;
            InitializeComponent();
        }

        private void CarDetailGUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            String color = CarManager.UppercaseFirstCharacter(car.Color.Trim());
            tbCarId.Text = car.CarId.ToString();
            tbMake.Text = car.Make;
            tbPetName.Text = car.PetName;
            tbColor.Text = color;
            tbHexColor.BackColor = CarManager.GetColorFromName(color);
        }

        



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCarGUI frmCarGUI = new frmCarGUI(user);
            frmCarGUI.ShowDialog();
        }


    }
}
