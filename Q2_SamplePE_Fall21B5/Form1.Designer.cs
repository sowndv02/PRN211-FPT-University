namespace Q2_SamplePE_Fall21B5
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
            groupBox1 = new GroupBox();
            btnEdit = new Button();
            btnAdd = new Button();
            Female = new RadioButton();
            cbPosition = new ComboBox();
            dob = new DateTimePicker();
            tbName = new TextBox();
            tbId = new TextBox();
            Male = new RadioButton();
            btnRefresh = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1066, 600);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(Female);
            groupBox1.Controls.Add(cbPosition);
            groupBox1.Controls.Add(dob);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbId);
            groupBox1.Controls.Add(Male);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1155, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 600);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "CurrentEmployee";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(324, 471);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 40);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(175, 471);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 40);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(245, 217);
            Female.Name = "Female";
            Female.Size = new Size(78, 24);
            Female.TabIndex = 11;
            Female.TabStop = true;
            Female.Text = "Female";
            Female.UseVisualStyleBackColor = true;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(107, 357);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(275, 28);
            cbPosition.TabIndex = 10;
            // 
            // dob
            // 
            dob.Location = new Point(107, 286);
            dob.Name = "dob";
            dob.Size = new Size(275, 27);
            dob.TabIndex = 9;
            // 
            // tbName
            // 
            tbName.Location = new Point(107, 133);
            tbName.Name = "tbName";
            tbName.Size = new Size(275, 27);
            tbName.TabIndex = 8;
            // 
            // tbId
            // 
            tbId.Location = new Point(107, 65);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(125, 27);
            tbId.TabIndex = 7;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(107, 217);
            Male.Name = "Male";
            Male.Size = new Size(63, 24);
            Male.TabIndex = 6;
            Male.TabStop = true;
            Male.Text = "Male";
            Male.UseVisualStyleBackColor = true;
            Male.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(22, 471);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(98, 40);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 357);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 4;
            label6.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 291);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 3;
            label5.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 217);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 133);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 72);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1595, 710);
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
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dob;
        private TextBox tbName;
        private TextBox tbId;
        private RadioButton Male;
        private Button btnRefresh;
        private ComboBox cbPosition;
        private RadioButton Female;
        private Button btnEdit;
        private Button btnAdd;
    }
}