namespace Q1_P3
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
            listBoxProvince = new ListBox();
            label1 = new Label();
            label2 = new Label();
            cbMale = new CheckBox();
            cbFmale = new CheckBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBoxProvince
            // 
            listBoxProvince.FormattingEnabled = true;
            listBoxProvince.ItemHeight = 20;
            listBoxProvince.Location = new Point(12, 274);
            listBoxProvince.Name = "listBoxProvince";
            listBoxProvince.SelectionMode = SelectionMode.MultiSimple;
            listBoxProvince.Size = new Size(238, 284);
            listBoxProvince.TabIndex = 0;
            listBoxProvince.SelectedIndexChanged += listBoxProvince_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 222);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Province";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Sex";
            // 
            // cbMale
            // 
            cbMale.AutoSize = true;
            cbMale.Location = new Point(12, 77);
            cbMale.Name = "cbMale";
            cbMale.Size = new Size(64, 24);
            cbMale.TabIndex = 3;
            cbMale.Text = "Male";
            cbMale.UseVisualStyleBackColor = true;
            cbMale.CheckedChanged += cbMale_CheckedChanged;
            // 
            // cbFmale
            // 
            cbFmale.AutoSize = true;
            cbFmale.Location = new Point(12, 126);
            cbFmale.Name = "cbFmale";
            cbFmale.Size = new Size(79, 24);
            cbFmale.TabIndex = 4;
            cbFmale.Text = "Female";
            cbFmale.UseVisualStyleBackColor = true;
            cbFmale.CheckedChanged += cbFmale_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(322, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(935, 577);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 632);
            Controls.Add(dataGridView1);
            Controls.Add(cbFmale);
            Controls.Add(cbMale);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxProvince);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProvince;
        private Label label1;
        private Label label2;
        private CheckBox cbMale;
        private CheckBox cbFmale;
        private DataGridView dataGridView1;
    }
}