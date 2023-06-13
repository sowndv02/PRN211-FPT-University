namespace Assignment2
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
            cbCourse = new ComboBox();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            cbSchedule = new ComboBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 33);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Schedule";
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(83, 30);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(192, 28);
            cbCourse.TabIndex = 3;
            cbCourse.SelectedIndexChanged += cbCourse_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(953, 415);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1022, 26);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbSchedule
            // 
            cbSchedule.FormattingEnabled = true;
            cbSchedule.Location = new Point(642, 30);
            cbSchedule.Name = "cbSchedule";
            cbSchedule.Size = new Size(192, 28);
            cbSchedule.TabIndex = 6;
            cbSchedule.SelectedIndexChanged += cbSchedule_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1022, 508);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 37);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 558);
            Controls.Add(btnExit);
            Controls.Add(cbSchedule);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(cbCourse);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbCourse;
        private DataGridView dataGridView1;
        private Button btnSave;
        private ComboBox cbSchedule;
        private Button btnExit;
    }
}