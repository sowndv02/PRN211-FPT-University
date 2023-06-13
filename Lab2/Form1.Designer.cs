namespace Lab2
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
            cbMajor1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            tbName = new TextBox();
            panel16 = new Panel();
            btnReset = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            panel15 = new Panel();
            label16 = new Label();
            panel14 = new Panel();
            cbActive = new CheckBox();
            panel13 = new Panel();
            label14 = new Label();
            panel12 = new Panel();
            numScholarShip = new NumericUpDown();
            panel1 = new Panel();
            label2 = new Label();
            panel11 = new Panel();
            cbMajor = new ComboBox();
            panel10 = new Panel();
            label11 = new Label();
            panel9 = new Panel();
            dob = new DateTimePicker();
            panel8 = new Panel();
            label9 = new Label();
            panel7 = new Panel();
            female = new RadioButton();
            male = new RadioButton();
            panel6 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            tbId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel16.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numScholarShip).BeginInit();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbMajor1
            // 
            cbMajor1.FormattingEnabled = true;
            cbMajor1.Location = new Point(86, 50);
            cbMajor1.Name = "cbMajor1";
            cbMajor1.Size = new Size(339, 28);
            cbMajor1.TabIndex = 0;
            cbMajor1.SelectedIndexChanged += cbMajor1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Major";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(992, 529);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.0757179F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.9242821F));
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel16, 1, 7);
            tableLayoutPanel1.Controls.Add(panel15, 0, 7);
            tableLayoutPanel1.Controls.Add(panel14, 1, 6);
            tableLayoutPanel1.Controls.Add(panel13, 0, 6);
            tableLayoutPanel1.Controls.Add(panel12, 1, 5);
            tableLayoutPanel1.Controls.Add(panel1, 0, 5);
            tableLayoutPanel1.Controls.Add(panel11, 1, 4);
            tableLayoutPanel1.Controls.Add(panel10, 0, 4);
            tableLayoutPanel1.Controls.Add(panel9, 1, 3);
            tableLayoutPanel1.Controls.Add(panel8, 0, 3);
            tableLayoutPanel1.Controls.Add(panel7, 1, 2);
            tableLayoutPanel1.Controls.Add(panel6, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(1010, 139);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.128545F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.75047255F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5311909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.56143665F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3421555F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1531191F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.640832F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.89225F));
            tableLayoutPanel1.Size = new Size(383, 529);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(tbName);
            panel5.Location = new Point(145, 46);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 35);
            panel5.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(6, 5);
            tbName.Name = "tbName";
            tbName.Size = new Size(220, 27);
            tbName.TabIndex = 1;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnReset);
            panel16.Controls.Add(btnUpdate);
            panel16.Controls.Add(btnDelete);
            panel16.Controls.Add(btnAdd);
            panel16.Location = new Point(145, 358);
            panel16.Name = "panel16";
            panel16.Size = new Size(235, 168);
            panel16.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(65, 95);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 33);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(82, 19);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(67, 39);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(161, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 39);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(label16);
            panel15.Location = new Point(3, 358);
            panel15.Name = "panel15";
            panel15.Size = new Size(136, 168);
            panel15.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(43, 73);
            label16.Name = "label16";
            label16.Size = new Size(52, 20);
            label16.TabIndex = 4;
            label16.Text = "Action";
            // 
            // panel14
            // 
            panel14.Controls.Add(cbActive);
            panel14.Location = new Point(145, 307);
            panel14.Name = "panel14";
            panel14.Size = new Size(235, 45);
            panel14.TabIndex = 5;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(43, 12);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(72, 24);
            cbActive.TabIndex = 0;
            cbActive.Text = "Active";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(label14);
            panel13.Location = new Point(3, 307);
            panel13.Name = "panel13";
            panel13.Size = new Size(136, 45);
            panel13.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 12);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 4;
            label14.Text = "IsActive";
            // 
            // panel12
            // 
            panel12.Controls.Add(numScholarShip);
            panel12.Location = new Point(145, 248);
            panel12.Name = "panel12";
            panel12.Size = new Size(235, 53);
            panel12.TabIndex = 5;
            // 
            // numScholarShip
            // 
            numScholarShip.Location = new Point(6, 14);
            numScholarShip.Name = "numScholarShip";
            numScholarShip.Size = new Size(220, 27);
            numScholarShip.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 53);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Scholarship";
            // 
            // panel11
            // 
            panel11.Controls.Add(cbMajor);
            panel11.Location = new Point(145, 188);
            panel11.Name = "panel11";
            panel11.Size = new Size(235, 54);
            panel11.TabIndex = 5;
            // 
            // cbMajor
            // 
            cbMajor.FormattingEnabled = true;
            cbMajor.Location = new Point(6, 16);
            cbMajor.Name = "cbMajor";
            cbMajor.Size = new Size(220, 28);
            cbMajor.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(label11);
            panel10.Location = new Point(3, 188);
            panel10.Name = "panel10";
            panel10.Size = new Size(136, 54);
            panel10.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 16);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 4;
            label11.Text = "Major";
            // 
            // panel9
            // 
            panel9.Controls.Add(dob);
            panel9.Location = new Point(145, 148);
            panel9.Name = "panel9";
            panel9.Size = new Size(235, 34);
            panel9.TabIndex = 5;
            // 
            // dob
            // 
            dob.CustomFormat = "dd-MM-yyyy";
            dob.Location = new Point(6, 3);
            dob.Margin = new Padding(3, 3, 3, 10);
            dob.Name = "dob";
            dob.Size = new Size(220, 27);
            dob.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(label9);
            panel8.Location = new Point(3, 148);
            panel8.Name = "panel8";
            panel8.Size = new Size(136, 34);
            panel8.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 5);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 4;
            label9.Text = "Date Of";
            // 
            // panel7
            // 
            panel7.Controls.Add(female);
            panel7.Controls.Add(male);
            panel7.Location = new Point(145, 87);
            panel7.Name = "panel7";
            panel7.Size = new Size(235, 55);
            panel7.TabIndex = 5;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(126, 14);
            female.Name = "female";
            female.Size = new Size(78, 24);
            female.TabIndex = 1;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(13, 12);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 0;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Location = new Point(3, 87);
            panel6.Name = "panel6";
            panel6.Size = new Size(136, 55);
            panel6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 14);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 4;
            label7.Text = "Gender";
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Location = new Point(3, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(136, 35);
            panel4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 7);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 37);
            panel3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 7);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 4;
            label4.Text = "ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbId);
            panel2.Location = new Point(145, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 37);
            panel2.TabIndex = 5;
            // 
            // tbId
            // 
            tbId.Location = new Point(6, 4);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(220, 27);
            tbId.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 680);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(cbMajor1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel16.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numScholarShip).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMajor1;
        private Label label1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private TextBox tbName;
        private Panel panel16;
        private Button btnAdd;
        private Panel panel15;
        private Label label16;
        private Panel panel14;
        private Panel panel13;
        private Label label14;
        private Panel panel12;
        private Panel panel1;
        private Label label2;
        private Panel panel11;
        private Panel panel10;
        private Label label11;
        private Panel panel9;
        private Panel panel8;
        private Label label9;
        private Panel panel7;
        private Panel panel6;
        private Label label7;
        private Panel panel4;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private TextBox tbId;
        private RadioButton male;
        private RadioButton female;
        private CheckBox cbActive;
        private NumericUpDown numScholarShip;
        private ComboBox cbMajor;
        private DateTimePicker dob;
        private Button btnReset;
        private Button btnUpdate;
        private Button btnDelete;
    }
}