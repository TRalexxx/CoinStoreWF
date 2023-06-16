namespace CoinStoreWF
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
            LoginL = new Label();
            loginTB = new TextBox();
            passwordTB = new TextBox();
            label1 = new Label();
            enterBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // LoginL
            // 
            LoginL.AutoSize = true;
            LoginL.Location = new Point(26, 17);
            LoginL.Name = "LoginL";
            LoginL.Size = new Size(67, 15);
            LoginL.TabIndex = 0;
            LoginL.Text = "Enter Login";
            // 
            // loginTB
            // 
            loginTB.Location = new Point(26, 35);
            loginTB.Name = "loginTB";
            loginTB.Size = new Size(201, 23);
            loginTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(26, 79);
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.Size = new Size(201, 23);
            passwordTB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 61);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Password";
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(26, 116);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(75, 23);
            enterBtn.TabIndex = 4;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(152, 116);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 171);
            Controls.Add(cancelBtn);
            Controls.Add(enterBtn);
            Controls.Add(passwordTB);
            Controls.Add(label1);
            Controls.Add(loginTB);
            Controls.Add(LoginL);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginL;
        private TextBox loginTB;
        private TextBox passwordTB;
        private Label label1;
        private Button enterBtn;
        private Button cancelBtn;
    }
}