using DemoEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEntityFramework
{
    public partial class frmEditCar : Form
    {
        private Car car;
        public frmEditCar(Car c)
        {
            car = c;
            InitializeComponent();
        }
    }
}
