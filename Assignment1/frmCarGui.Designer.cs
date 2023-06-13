namespace Assignment1
{
    partial class frmCarGUI
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
            numberOfCars = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(872, 379);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // numberOfCars
            // 
            numberOfCars.AutoSize = true;
            numberOfCars.Location = new Point(12, 89);
            numberOfCars.Name = "numberOfCars";
            numberOfCars.Size = new Size(143, 20);
            numberOfCars.TabIndex = 2;
            numberOfCars.Text = "The number of cars: ";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(921, 466);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCarGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 517);
            Controls.Add(btnExit);
            Controls.Add(numberOfCars);
            Controls.Add(dataGridView1);
            Name = "frmCarGUI";
            Text = "frmCarGUI";
            Load += frmCarGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label numberOfCars;
        private Label login;
        private Button btnExit;
    }
}