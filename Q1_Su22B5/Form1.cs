namespace Q1_Su22B5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbNumberChars.Text, out int number))
            {
                string studentID = "HE164023";
                string txt = studentID.Substring(0, number);
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(504, 442);
                label.Name = "result";
                label.Size = new Size(123, 20);
                label.Text = $"Result: {txt}";
                Controls.Add(label);
            }
            else
            {
                MessageBox.Show("You must input an integer number.");
            }
        }
    }
}