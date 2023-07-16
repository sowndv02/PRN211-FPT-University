namespace Q2_Sample_By_Son
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
            tbCourseCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbSubject = new ComboBox();
            cbInstructor = new ComboBox();
            cbTerm = new ComboBox();
            cbCampus = new ComboBox();
            tbCourseDescription = new TextBox();
            btnCourse = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // tbCourseCode
            // 
            tbCourseCode.Location = new Point(232, 63);
            tbCourseCode.Name = "tbCourseCode";
            tbCourseCode.Size = new Size(218, 27);
            tbCourseCode.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 63);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "CourseCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 131);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "CourseDescription";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 205);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 283);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "Instructor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 352);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 5;
            label5.Text = "Term";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 439);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 6;
            label6.Text = "Campus";
            // 
            // cbSubject
            // 
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(232, 202);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(218, 28);
            cbSubject.TabIndex = 7;
            // 
            // cbInstructor
            // 
            cbInstructor.FormattingEnabled = true;
            cbInstructor.Location = new Point(232, 275);
            cbInstructor.Name = "cbInstructor";
            cbInstructor.Size = new Size(218, 28);
            cbInstructor.TabIndex = 8;
            // 
            // cbTerm
            // 
            cbTerm.FormattingEnabled = true;
            cbTerm.Location = new Point(232, 352);
            cbTerm.Name = "cbTerm";
            cbTerm.Size = new Size(218, 28);
            cbTerm.TabIndex = 9;
            // 
            // cbCampus
            // 
            cbCampus.FormattingEnabled = true;
            cbCampus.Location = new Point(232, 436);
            cbCampus.Name = "cbCampus";
            cbCampus.Size = new Size(218, 28);
            cbCampus.TabIndex = 10;
            // 
            // tbCourseDescription
            // 
            tbCourseDescription.Location = new Point(232, 131);
            tbCourseDescription.Name = "tbCourseDescription";
            tbCourseDescription.Size = new Size(218, 27);
            tbCourseDescription.TabIndex = 11;
            // 
            // btnCourse
            // 
            btnCourse.Location = new Point(461, 553);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(111, 47);
            btnCourse.TabIndex = 13;
            btnCourse.Text = "Add Course";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(744, 63);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(428, 404);
            listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 636);
            Controls.Add(listBox1);
            Controls.Add(btnCourse);
            Controls.Add(tbCourseDescription);
            Controls.Add(cbCampus);
            Controls.Add(cbTerm);
            Controls.Add(cbInstructor);
            Controls.Add(cbSubject);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCourseCode);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCourseCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbSubject;
        private ComboBox cbInstructor;
        private ComboBox cbTerm;
        private ComboBox cbCampus;
        private TextBox tbCourseDescription;
        private Button btnCourse;
        private ListBox listBox1;
    }
}