namespace Assignment1
{
    partial class LoginGUI
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
            btnLogin = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 75);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 173);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(165, 285);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(109, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(260, 75);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(192, 27);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(260, 173);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(192, 27);
            tbPassword.TabIndex = 4;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(397, 285);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // LoginGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginGUI";
            Text = "LoginGUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnCancel;
    }
}