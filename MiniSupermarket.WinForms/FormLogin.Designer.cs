namespace MiniSupermarket.WinForms
{
    partial class FormLogin
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 50);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(239, 44);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(210, 31);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(239, 90);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(210, 31);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(135, 144);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(314, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập hệ thống";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 244);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Dang nhap he thong - FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
    }
}