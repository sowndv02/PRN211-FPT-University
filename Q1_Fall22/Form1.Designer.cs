namespace Q1_Fall22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbTitle = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            tbDescription = new TextBox();
            tbLanguage = new TextBox();
            cbProducer = new ComboBox();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 105);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 171);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "ReleaseDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 236);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 465);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Language";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 523);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 4;
            label5.Text = "Producer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(721, 105);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 5;
            label6.Text = "Genres";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(182, 102);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(250, 27);
            tbTitle.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(182, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(182, 229);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(343, 160);
            tbDescription.TabIndex = 8;
            // 
            // tbLanguage
            // 
            tbLanguage.Location = new Point(182, 458);
            tbLanguage.Name = "tbLanguage";
            tbLanguage.Size = new Size(250, 27);
            tbLanguage.TabIndex = 9;
            // 
            // cbProducer
            // 
            cbProducer.FormattingEnabled = true;
            cbProducer.Location = new Point(182, 523);
            cbProducer.Name = "cbProducer";
            cbProducer.Size = new Size(250, 28);
            cbProducer.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(268, 618);
            button1.Name = "button1";
            button1.Size = new Size(210, 29);
            button1.TabIndex = 11;
            button1.Text = "Add new movie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(721, 171);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(283, 384);
            listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 680);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(cbProducer);
            Controls.Add(tbLanguage);
            Controls.Add(tbDescription);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbTitle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbTitle;
        private DateTimePicker dateTimePicker1;
        private TextBox tbDescription;
        private TextBox tbLanguage;
        private ComboBox cbProducer;
        private Button button1;
        private ListBox listBox1;
    }
}