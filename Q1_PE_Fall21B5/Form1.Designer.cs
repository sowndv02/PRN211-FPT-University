namespace Q1_PE_Fall21B5
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
            panel1 = new Panel();
            cbPositions = new ComboBox();
            label3 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            female = new RadioButton();
            male = new RadioButton();
            genderAll = new RadioButton();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbPositions);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(female);
            panel1.Controls.Add(male);
            panel1.Controls.Add(genderAll);
            panel1.Location = new Point(30, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 439);
            panel1.TabIndex = 0;
            // 
            // cbPositions
            // 
            cbPositions.FormattingEnabled = true;
            cbPositions.Location = new Point(96, 155);
            cbPositions.Name = "cbPositions";
            cbPositions.Size = new Size(176, 28);
            cbPositions.TabIndex = 4;
            cbPositions.SelectedIndexChanged += cbPositions_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 158);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Position";
            // 
            // tbName
            // 
            tbName.Location = new Point(87, 27);
            tbName.Name = "tbName";
            tbName.Size = new Size(281, 27);
            tbName.TabIndex = 3;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 30);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(290, 85);
            female.Name = "female";
            female.Size = new Size(78, 24);
            female.TabIndex = 2;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            female.CheckedChanged += female_CheckedChanged;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(173, 85);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 1;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            male.CheckedChanged += male_CheckedChanged;
            // 
            // genderAll
            // 
            genderAll.AutoSize = true;
            genderAll.Location = new Point(13, 85);
            genderAll.Name = "genderAll";
            genderAll.Size = new Size(117, 24);
            genderAll.TabIndex = 0;
            genderAll.TabStop = true;
            genderAll.Text = "Male/Female";
            genderAll.UseVisualStyleBackColor = true;
            genderAll.CheckedChanged += genderAll_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 68);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Filter";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(486, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(950, 439);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 531);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RadioButton genderAll;
        private RadioButton female;
        private RadioButton male;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private ComboBox cbPositions;
        private DataGridView dataGridView1;
    }
}