using Q2_SamplePE_bySon_Version2.Models;

namespace Q2_SamplePE_bySon_Version2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCourse();
        }

        private void LoadCourse()
        {
            using (var context = new APContext())
            {
                cbCourse.DataSource = context.Courses.ToList();
                cbCourse.DisplayMember = "CourseCode";
                cbCourse.ValueMember = "CourseId";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbCourse.SelectedValue);
            frmEdit frmEdit = new frmEdit(id);
            frmEdit.Show();
        }
    }
}