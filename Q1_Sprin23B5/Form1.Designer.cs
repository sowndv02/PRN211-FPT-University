namespace Q1_Sprin23B5
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
            btnFile = new Button();
            urlPath = new TextBox();
            dataGridView1 = new DataGridView();
            btnRemove = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnFile
            // 
            btnFile.Location = new Point(40, 24);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(125, 36);
            btnFile.TabIndex = 0;
            btnFile.Text = "ChooseFile";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // urlPath
            // 
            urlPath.Location = new Point(220, 29);
            urlPath.Name = "urlPath";
            urlPath.ReadOnly = true;
            urlPath.Size = new Size(521, 27);
            urlPath.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(701, 247);
            dataGridView1.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(40, 380);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(100, 44);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(232, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 44);
            btnSave.TabIndex = 4;
            btnSave.Text = "SaveToFile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(dataGridView1);
            Controls.Add(urlPath);
            Controls.Add(btnFile);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFile;
        private TextBox urlPath;
        private DataGridView dataGridView1;
        private Button btnRemove;
        private Button btnSave;
    }
}