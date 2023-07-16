namespace Q2_Spring23
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
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnRefresh = new Button();
            Female = new RadioButton();
            Male = new RadioButton();
            dob = new DateTimePicker();
            tbEmail = new TextBox();
            tbName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(699, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(Female);
            groupBox1.Controls.Add(Male);
            groupBox1.Controls.Add(dob);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbId);
            groupBox1.Location = new Point(768, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 600);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student's Detail";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(313, 458);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 40);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(173, 458);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 40);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(34, 458);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 40);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(285, 217);
            Female.Name = "Female";
            Female.Size = new Size(78, 24);
            Female.TabIndex = 10;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(158, 217);
            Male.Name = "Male";
            Male.Size = new Size(63, 24);
            Male.TabIndex = 9;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            dob.Location = new Point(157, 283);
            dob.Name = "dob";
            dob.Size = new Size(250, 27);
            dob.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(189, 368);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(218, 27);
            tbEmail.TabIndex = 7;
            // 
            // tbName
            // 
            tbName.Location = new Point(189, 142);
            tbName.Name = "tbName";
            tbName.Size = new Size(218, 27);
            tbName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 371);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 288);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 4;
            label4.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 217);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 145);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "FullName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 65);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Student Id";
            // 
            // tbId
            // 
            tbId.Location = new Point(189, 62);
            tbId.Name = "tbId";
            tbId.Size = new Size(218, 27);
            tbId.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 642);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbEmail;
        private TextBox tbName;
        private RadioButton Female;
        private RadioButton Male;
        private DateTimePicker dob;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnRefresh;
    }
}