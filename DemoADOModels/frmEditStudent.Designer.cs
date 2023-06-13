namespace DemoADOModels
{
    partial class frmEditStudent
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
            label5 = new Label();
            tbStudentId = new TextBox();
            tbRoll = new TextBox();
            tbFirstName = new TextBox();
            tbMidName = new TextBox();
            tbLastName = new TextBox();
            btnUpdate = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "StudentId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 92);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Roll#";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 146);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "FirstName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 206);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "MidName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 270);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "LastName";
            // 
            // tbStudentId
            // 
            tbStudentId.Location = new Point(225, 39);
            tbStudentId.Name = "tbStudentId";
            tbStudentId.ReadOnly = true;
            tbStudentId.Size = new Size(307, 27);
            tbStudentId.TabIndex = 5;
            // 
            // tbRoll
            // 
            tbRoll.Location = new Point(225, 92);
            tbRoll.Name = "tbRoll";
            tbRoll.Size = new Size(307, 27);
            tbRoll.TabIndex = 6;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(225, 146);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(307, 27);
            tbFirstName.TabIndex = 7;
            // 
            // tbMidName
            // 
            tbMidName.Location = new Point(225, 203);
            tbMidName.Name = "tbMidName";
            tbMidName.Size = new Size(307, 27);
            tbMidName.TabIndex = 8;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(225, 270);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(307, 27);
            tbLastName.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(115, 390);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(181, 40);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Save";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(435, 390);
            button1.Name = "button1";
            button1.Size = new Size(181, 40);
            button1.TabIndex = 11;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmEditStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 594);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(tbLastName);
            Controls.Add(tbMidName);
            Controls.Add(tbFirstName);
            Controls.Add(tbRoll);
            Controls.Add(tbStudentId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditStudent";
            Text = "frmEditStudent";
            Load += frmEditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbStudentId;
        private TextBox tbRoll;
        private TextBox tbFirstName;
        private TextBox tbMidName;
        private TextBox tbLastName;
        private Button btnUpdate;
        private Button button1;
    }
}