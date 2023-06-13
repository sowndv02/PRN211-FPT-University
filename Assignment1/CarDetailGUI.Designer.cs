namespace Assignment1
{
    partial class CarDetailGUI
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
            btnBack = new Button();
            tbCarId = new TextBox();
            tbColor = new TextBox();
            tbMake = new TextBox();
            tbPetName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbHexColor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 142);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "CarID:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(375, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 44);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tbCarId
            // 
            tbCarId.Location = new Point(149, 139);
            tbCarId.Name = "tbCarId";
            tbCarId.ReadOnly = true;
            tbCarId.Size = new Size(205, 27);
            tbCarId.TabIndex = 2;
            // 
            // tbColor
            // 
            tbColor.Location = new Point(565, 142);
            tbColor.Name = "tbColor";
            tbColor.ReadOnly = true;
            tbColor.Size = new Size(212, 27);
            tbColor.TabIndex = 3;
            // 
            // tbMake
            // 
            tbMake.Location = new Point(149, 241);
            tbMake.Name = "tbMake";
            tbMake.ReadOnly = true;
            tbMake.Size = new Size(205, 27);
            tbMake.TabIndex = 4;
            // 
            // tbPetName
            // 
            tbPetName.Location = new Point(565, 241);
            tbPetName.Name = "tbPetName";
            tbPetName.ReadOnly = true;
            tbPetName.Size = new Size(212, 27);
            tbPetName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 244);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 6;
            label2.Text = "Make:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 149);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 248);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "PetName:";
            // 
            // tbHexColor
            // 
            tbHexColor.Location = new Point(797, 142);
            tbHexColor.Name = "tbHexColor";
            tbHexColor.ReadOnly = true;
            tbHexColor.Size = new Size(48, 27);
            tbHexColor.TabIndex = 9;
            // 
            // CarDetailGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 551);
            Controls.Add(tbHexColor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPetName);
            Controls.Add(tbMake);
            Controls.Add(tbColor);
            Controls.Add(tbCarId);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "CarDetailGUI";
            Text = "CarDetailGUI";
            Load += CarDetailGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private TextBox tbCarId;
        private TextBox tbColor;
        private TextBox tbMake;
        private TextBox tbPetName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbHexColor;
    }
}