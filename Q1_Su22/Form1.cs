using System.Windows.Forms;

namespace Q1_Su22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateButton();
        }

        private void GenerateButton()
        {
            groupBox1.Controls.Clear();
            int number = (int)numberBtns.Value;
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    Label label = new Label();

                    label.AutoSize = true;
                    label.Location = new Point(6, i * 23 + i * 20);
                    label.Name = $"{i}";
                    label.Size = new Size(114, 20);
                    label.Text = $"Text of button {i}";

                    Button button = new Button();
                    button.Location = new Point(496, i * 19 + i * 20);
                    button.Name = $"{i}";
                    button.Size = new Size(94, 29);
                    button.Text = $"Button {i}";
                    button.UseVisualStyleBackColor = true;

                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(160, i * 20 + i * 20);
                    textBox.Name = $"TextboxValue{i}";
                    textBox.Size = new Size(276, 27);

                    button.Click += button_click;

                    groupBox1.Controls.Add(button);
                    groupBox1.Controls.Add(label);
                    groupBox1.Controls.Add(textBox);

                    

                }
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            string index = ((Button)sender).Name;
            string textBoxValue = ((TextBox)groupBox1.Controls[$"TextboxValue{index}"]).Text;
            MessageBox.Show(textBoxValue);
        }
    }
}