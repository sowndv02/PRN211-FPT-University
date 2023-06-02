namespace DemoADOModels
{
    partial class frmAddStudent
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
            btnAdd = new Button();
            tbRoll = new TextBox();
            tbFirstName = new TextBox();
            tbMidName = new TextBox();
            tbLastName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 47);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Roll#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 104);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 169);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "MidName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 225);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "LastName";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(200, 309);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbRoll
            // 
            tbRoll.Location = new Point(200, 47);
            tbRoll.Name = "tbRoll";
            tbRoll.Size = new Size(223, 27);
            tbRoll.TabIndex = 5;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(200, 104);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(223, 27);
            tbFirstName.TabIndex = 6;
            // 
            // tbMidName
            // 
            tbMidName.Location = new Point(200, 169);
            tbMidName.Name = "tbMidName";
            tbMidName.Size = new Size(223, 27);
            tbMidName.TabIndex = 7;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(200, 222);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(223, 27);
            tbLastName.TabIndex = 8;
            // 
            // frmAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 452);
            Controls.Add(tbLastName);
            Controls.Add(tbMidName);
            Controls.Add(tbFirstName);
            Controls.Add(tbRoll);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddStudent";
            Text = "frmAddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private TextBox tbRoll;
        private TextBox tbFirstName;
        private TextBox tbMidName;
        private TextBox tbLastName;
    }
}