namespace Q1_Su22B5
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
            studentId = new Label();
            label2 = new Label();
            tbNumberChars = new TextBox();
            label3 = new Label();
            btnGet = new Button();
            SuspendLayout();
            // 
            // studentId
            // 
            studentId.AutoSize = true;
            studentId.Location = new Point(504, 100);
            studentId.Name = "studentId";
            studentId.Size = new Size(149, 20);
            studentId.TabIndex = 0;
            studentId.Text = "StudentID: HE164023";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 204);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Get";
            // 
            // tbNumberChars
            // 
            tbNumberChars.Location = new Point(204, 201);
            tbNumberChars.Name = "tbNumberChars";
            tbNumberChars.Size = new Size(200, 27);
            tbNumberChars.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 204);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Characters";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(504, 320);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 29);
            btnGet.TabIndex = 4;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 571);
            Controls.Add(btnGet);
            Controls.Add(label3);
            Controls.Add(tbNumberChars);
            Controls.Add(label2);
            Controls.Add(studentId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentId;
        private Label label2;
        private TextBox tbNumberChars;
        private Label label3;
        private Button btnGet;
    }
}