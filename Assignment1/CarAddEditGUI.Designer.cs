namespace Assignment1
{
    partial class CarAddEditGUI
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbCarId = new TextBox();
            tbMake = new TextBox();
            tbPetName = new TextBox();
            tbColor = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            tbHexColor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 64);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "CarID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 156);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 64);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Color";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 156);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "PetName";
            // 
            // tbCarId
            // 
            tbCarId.Location = new Point(150, 57);
            tbCarId.Name = "tbCarId";
            tbCarId.ReadOnly = true;
            tbCarId.Size = new Size(154, 27);
            tbCarId.TabIndex = 4;
            // 
            // tbMake
            // 
            tbMake.Location = new Point(150, 149);
            tbMake.Name = "tbMake";
            tbMake.Size = new Size(154, 27);
            tbMake.TabIndex = 5;
            // 
            // tbPetName
            // 
            tbPetName.Location = new Point(528, 149);
            tbPetName.Name = "tbPetName";
            tbPetName.Size = new Size(183, 27);
            tbPetName.TabIndex = 6;
            // 
            // tbColor
            // 
            tbColor.Location = new Point(528, 57);
            tbColor.Name = "tbColor";
            tbColor.Size = new Size(183, 27);
            tbColor.TabIndex = 7;
            tbColor.TextChanged += tbColor_TextChanged;
            tbColor.Leave += tbColor_Leave;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(181, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(433, 277);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 43);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbHexColor
            // 
            tbHexColor.Location = new Point(730, 57);
            tbHexColor.Name = "tbHexColor";
            tbHexColor.ReadOnly = true;
            tbHexColor.Size = new Size(58, 27);
            tbHexColor.TabIndex = 10;
            // 
            // CarAddEditGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbHexColor);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbColor);
            Controls.Add(tbPetName);
            Controls.Add(tbMake);
            Controls.Add(tbCarId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarAddEditGUI";
            Text = "CarAddEditGUI";
            Load += CarAddEditGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbCarId;
        private TextBox tbMake;
        private TextBox tbPetName;
        private TextBox tbColor;
        private Button btnSave;
        private Button btnCancel;
        private TextBox tbHexColor;
    }
}