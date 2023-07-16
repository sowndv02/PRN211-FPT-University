namespace Q2_SamplePE_bySon_Version2
{
    partial class frmEdit
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
            listBox1 = new ListBox();
            tbnSave = new Button();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(953, 45);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(250, 524);
            listBox1.TabIndex = 1;
            // 
            // tbnSave
            // 
            tbnSave.Location = new Point(604, 578);
            tbnSave.Name = "tbnSave";
            tbnSave.Size = new Size(129, 48);
            tbnSave.TabIndex = 2;
            tbnSave.Text = "Save";
            tbnSave.UseVisualStyleBackColor = true;
            tbnSave.Click += tbnSave_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.Visible = false;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(296, 45);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiSimple;
            listBox2.Size = new Size(264, 524);
            listBox2.TabIndex = 4;
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 638);
            Controls.Add(listBox2);
            Controls.Add(textBox1);
            Controls.Add(tbnSave);
            Controls.Add(listBox1);
            Name = "frmEdit";
            Text = "frmEdit";
            Load += frmEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button tbnSave;
        private TextBox textBox1;
        private ListBox listBox2;
    }
}