namespace BankDeposit.Forms
{
    partial class LoginForm
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
            buttonLogin = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonCancel = new Button();
            labelError = new Label();
            label1 = new Label();
            panelLogin = new Panel();
            label3 = new Label();
            label2 = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(3, 147);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(136, 32);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Продовжити";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Enabled = false;
            textBoxUsername.Location = new Point(94, 37);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(124, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(94, 83);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(124, 27);
            textBoxPassword.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(168, 147);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(136, 32);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(94, 113);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 20);
            labelError.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 14);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "Вхід в систему ";
            label1.Click += label1_Click;
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.Top;
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Controls.Add(labelError);
            panelLogin.Controls.Add(textBoxUsername);
            panelLogin.Controls.Add(buttonCancel);
            panelLogin.Controls.Add(textBoxPassword);
            panelLogin.Location = new Point(60, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(307, 188);
            panelLogin.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 90);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 40);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Логін:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 213);
            Controls.Add(panelLogin);
            MaximumSize = new Size(547, 360);
            MinimumSize = new Size(430, 260);
            Name = "LoginForm";
            Text = "LoginForm";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonCancel;
        private Label labelError;
        private Label label1;
        private Panel panelLogin;
        private Label label3;
        private Label label2;
    }
}