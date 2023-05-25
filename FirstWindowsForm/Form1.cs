namespace FirstWindowsForm
{
    public partial class Form1 : Form
    {
        /*
        	1. Khởi tạo biến - Đặt tên
	2. Khởi tạo hàm tạo -> Cấp phát bộ nhớ
	3. Khởi tạo property của control
Add control vào dsach các control của form -> Giúp hiển thị trên form/panel…..
        */


        public void CreateNewButton()
        {
            Button btnNewButton; //Khai báo kiểu dữ liệu (1)
            btnNewButton = new Button(); // Cấp phát bộ nhớ(2)
            btnNewButton.Text = "Hello btn"; //Gán các property(3)
            btnNewButton.Size = new Size(add.Size.Width, add.Size.Height);
            btnNewButton.Location = new Point(add.Location.X, add.Location.Y + add.Size.Height + 40);
            btnNewButton.Click += alert;
            //btnNewButton.Click += new EventHandler(btnNewButton_Click);
            this.Controls.Add(btnNewButton);//Add btnNewButton lên form (4)
        }
        public Form1()
        {
            InitializeComponent();
            //CreateNewButton();
        }
        private static List<Button> list = new List<Button>();
        static Form form = Application.OpenForms["Form1"];
        static int formHeight = form.Size.Height, formWidth = form.Size.Width, col = 1,count = 1, space = 10;

        private void alert(object sender, EventArgs e)
        {
            MessageBox.Show("Hello PRN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formHeight - add.Size.Height < count * add.Size.Height + space * (count + 1) + add.Location.Y)
            {
                count = 1;
                col++;
            }
            if(formWidth < add.Size.Width * col + (col * 50))
            {
                MessageBox.Show("Max btn have add!");
                return;
            }
            Button button = new Button();
            button.Location = new Point(add.Location.X + add.Size.Width * (col - 1) + 50 * (col - 1), add.Location.Y + space * count + add.Size.Height * count);
            button.Size = new Size(add.Width, add.Height);
            button.Text = "Add";
            list.Add(button);
            numberBtn.Text = list.Count.ToString();
            Controls.Add(button);
            count++;

        }
    }
}