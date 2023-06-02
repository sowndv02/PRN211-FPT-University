namespace DemoADOModels
{
    partial class frmOtherType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbSearch = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            tbLastName = new TextBox();
            tbMidName = new TextBox();
            tbFirstName = new TextBox();
            tbRoll = new TextBox();
            tbStudentId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "SearchStudent";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(189, 31);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(419, 27);
            tbSearch.TabIndex = 1;
            tbSearch.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(890, 591);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(tbLastName);
            panel1.Controls.Add(tbMidName);
            panel1.Controls.Add(tbFirstName);
            panel1.Controls.Add(tbRoll);
            panel1.Controls.Add(tbStudentId);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(965, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 591);
            panel1.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(230, 432);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 34);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(18, 432);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(207, 337);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 37);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 337);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 37);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(138, 250);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(194, 27);
            tbLastName.TabIndex = 9;
            // 
            // tbMidName
            // 
            tbMidName.Location = new Point(138, 196);
            tbMidName.Name = "tbMidName";
            tbMidName.Size = new Size(194, 27);
            tbMidName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(138, 144);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(194, 27);
            tbFirstName.TabIndex = 7;
            // 
            // tbRoll
            // 
            tbRoll.Location = new Point(138, 93);
            tbRoll.Name = "tbRoll";
            tbRoll.Size = new Size(194, 27);
            tbRoll.TabIndex = 6;
            // 
            // tbStudentId
            // 
            tbStudentId.Location = new Point(138, 39);
            tbStudentId.Name = "tbStudentId";
            tbStudentId.ReadOnly = true;
            tbStudentId.Size = new Size(194, 27);
            tbStudentId.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 250);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 4;
            label6.Text = "LastName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 196);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 3;
            label5.Text = "MidName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 144);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 2;
            label4.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 93);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 1;
            label3.Text = "Roll#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 39);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "studentId";
            // 
            // frmOtherType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 699);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(tbSearch);
            Controls.Add(label1);
            Name = "frmOtherType";
            Text = "frmOtherType";
            Load += frmOtherType_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbSearch;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox tbLastName;
        private TextBox tbMidName;
        private TextBox tbFirstName;
        private TextBox tbRoll;
        private TextBox tbStudentId;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
    }
}