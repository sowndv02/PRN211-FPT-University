namespace FirstWindowsForm
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
            add = new Button();
            numberBtn = new TextBox();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(12, 12);
            add.Name = "add";
            add.Size = new Size(130, 29);
            add.TabIndex = 0;
            add.Text = "Add Button";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // numberBtn
            // 
            numberBtn.Location = new Point(214, 14);
            numberBtn.Name = "numberBtn";
            numberBtn.Size = new Size(385, 27);
            numberBtn.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 389);
            Controls.Add(numberBtn);
            Controls.Add(add);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private TextBox numberBtn;
    }
}