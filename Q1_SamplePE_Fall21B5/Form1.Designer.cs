namespace Q1_SamplePE_Fall21B5
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
            groupBox1 = new GroupBox();
            cbPosition = new ComboBox();
            Female = new RadioButton();
            Male = new RadioButton();
            MF = new RadioButton();
            tbName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbPosition);
            groupBox1.Controls.Add(Female);
            groupBox1.Controls.Add(Male);
            groupBox1.Controls.Add(MF);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 423);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(101, 179);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(255, 28);
            cbPosition.TabIndex = 7;
            cbPosition.SelectedIndexChanged += cbPosition_SelectedIndexChanged;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(278, 115);
            Female.Name = "Female";
            Female.Size = new Size(78, 24);
            Female.TabIndex = 6;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            Female.CheckedChanged += Female_CheckedChanged;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(178, 115);
            Male.Name = "Male";
            Male.Size = new Size(63, 24);
            Male.TabIndex = 5;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            Male.CheckedChanged += Male_CheckedChanged;
            // 
            // MF
            // 
            MF.AutoSize = true;
            MF.Location = new Point(18, 115);
            MF.Name = "MF";
            MF.Size = new Size(117, 24);
            MF.TabIndex = 4;
            MF.TabStop = true;
            MF.Text = "Male/Female";
            MF.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Location = new Point(101, 49);
            tbName.Name = "tbName";
            tbName.Size = new Size(255, 27);
            tbName.TabIndex = 2;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 182);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Position";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(516, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1015, 423);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 653);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbName;
        private Label label2;
        private Label label1;
        private RadioButton Female;
        private RadioButton Male;
        private RadioButton MF;
        private DataGridView dataGridView1;
        private ComboBox cbPosition;
    }
}