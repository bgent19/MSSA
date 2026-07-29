namespace Assignment4._2
{
    partial class LoginForm
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
            textBoxUserId = new TextBox();
            textBoxPassword = new TextBox();
            labeluserId = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new Point(100, 30);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.Size = new Size(125, 27);
            textBoxUserId.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(100, 60);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // labeluserId
            // 
            labeluserId.AutoSize = true;
            labeluserId.Location = new Point(43, 30);
            labeluserId.Name = "labeluserId";
            labeluserId.Size = new Size(57, 20);
            labeluserId.TabIndex = 2;
            labeluserId.Text = "User ID";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(30, 60);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(100, 93);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += this.buttonLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 143);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labeluserId);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserId);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUserId;
        private TextBox textBoxPassword;
        private Label labeluserId;
        private Label labelPassword;
        private Button buttonLogin;
    }
}
