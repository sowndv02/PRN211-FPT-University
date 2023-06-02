using DemoADOModels.DAL;
using DemoADOModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoADOModels
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                tbRoll.Text,
                tbFirstName.Text,
                tbMidName.Text,
                tbLastName.Text
                );
            int count = StudentDAO.AddStudent(student);
            if (count > 0)
                MessageBox.Show("Add Successful!");
            else MessageBox.Show("Add Error");
            this.Close();
        }
    }
}
