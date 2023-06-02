namespace DemoADOModels
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
            dtg1 = new DataGridView();
            tbSearch = new TextBox();
            label1 = new Label();
            btnAddStudent = new Button();
            btnOther = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg1).BeginInit();
            SuspendLayout();
            // 
            // dtg1
            // 
            dtg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtg1.BackgroundColor = SystemColors.ControlLightLight;
            dtg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg1.Location = new Point(12, 87);
            dtg1.Name = "dtg1";
            dtg1.RowHeadersWidth = 51;
            dtg1.RowTemplate.Height = 29;
            dtg1.Size = new Size(971, 490);
            dtg1.TabIndex = 0;
            dtg1.CellContentClick += dtg1_CellContentClick;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(135, 31);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(438, 27);
            tbSearch.TabIndex = 1;
            tbSearch.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "SearchStudent";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(806, 34);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(177, 35);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "New Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnOther
            // 
            btnOther.Location = new Point(639, 34);
            btnOther.Name = "btnOther";
            btnOther.Size = new Size(143, 35);
            btnOther.TabIndex = 4;
            btnOther.Text = "OtherType";
            btnOther.UseVisualStyleBackColor = true;
            btnOther.Click += btnOther_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 589);
            Controls.Add(btnOther);
            Controls.Add(btnAddStudent);
            Controls.Add(label1);
            Controls.Add(tbSearch);
            Controls.Add(dtg1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtg1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg1;
        private TextBox tbSearch;
        private Label label1;
        private Button btnAddStudent;
        private Button btnOther;
    }
}