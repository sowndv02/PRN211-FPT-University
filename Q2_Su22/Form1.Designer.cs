namespace Q2_Su22
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
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dob = new DateTimePicker();
            btnAdd = new Button();
            cbTitle = new ComboBox();
            cbDepartment = new ComboBox();
            dataGridView1 = new DataGridView();
            btnAddDb = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 74);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 178);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(184, 71);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(250, 27);
            tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(184, 171);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(250, 27);
            tbLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 264);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 4;
            label3.Text = "Title Of Courtesy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 364);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 5;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 457);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 6;
            label5.Text = "BirthDate";
            // 
            // dob
            // 
            dob.Location = new Point(184, 450);
            dob.Name = "dob";
            dob.Size = new Size(250, 27);
            dob.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(219, 519);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 36);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbTitle
            // 
            cbTitle.FormattingEnabled = true;
            cbTitle.Location = new Point(184, 264);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new Size(250, 28);
            cbTitle.TabIndex = 7;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(184, 364);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(250, 28);
            cbDepartment.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(490, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(938, 403);
            dataGridView1.TabIndex = 11;
            // 
            // btnAddDb
            // 
            btnAddDb.Location = new Point(1224, 519);
            btnAddDb.Name = "btnAddDb";
            btnAddDb.Size = new Size(204, 36);
            btnAddDb.TabIndex = 12;
            btnAddDb.Text = "Insert all into database";
            btnAddDb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 609);
            Controls.Add(btnAddDb);
            Controls.Add(dataGridView1);
            Controls.Add(cbDepartment);
            Controls.Add(btnAdd);
            Controls.Add(dob);
            Controls.Add(cbTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dob;
        private Button btnAdd;
        private ComboBox cbTitle;
        private ComboBox cbDepartment;
        private DataGridView dataGridView1;
        private Button btnAddDb;
    }
}