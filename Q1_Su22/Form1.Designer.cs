namespace Q1_Su22
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
            label1 = new Label();
            numberBtns = new NumericUpDown();
            button1 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numberBtns).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 78);
            label1.Name = "label1";
            label1.Size = new Size(275, 20);
            label1.TabIndex = 0;
            label1.Text = "How many buttons do you want to add?";
            // 
            // numberBtns
            // 
            numberBtns.Location = new Point(541, 76);
            numberBtns.Name = "numberBtns";
            numberBtns.Size = new Size(200, 27);
            numberBtns.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(831, 78);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(145, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 337);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 594);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(numberBtns);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numberBtns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numberBtns;
        private Button button1;
        private GroupBox groupBox1;
    }
}