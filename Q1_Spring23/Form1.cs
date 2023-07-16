using Q1_Spring23.Models;

namespace Q1_Spring23
{
    public partial class Form1 : Form
    {
        List<Q1_Spring23.Models.Button> buttons;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGriview();
        }

        private void LoadDataGriview()
        {
            using (var context = new Q1_SP23Context())
            {
                buttons = context.Buttons.ToList();
                dataGridView1.DataSource = buttons;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var button in buttons)
            {
                System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                b.Text = button.Text;
                b.Width = 94;
                b.Height = 29;
                b.BackColor = ColorTranslator.FromHtml(button.Color);
                flowLayoutPanel1.Controls.Add(b);
            }

        }
    }
}