namespace CoinStoreWF
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
            logInBtn = new Button();
            registerBtn = new Button();
            loginAsL = new Label();
            coinPanel = new Panel();
            refreshStoreBtn = new Button();
            balanceL = new Label();
            saveLogsBtn = new Button();
            SuspendLayout();
            // 
            // logInBtn
            // 
            logInBtn.Location = new Point(9, 7);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(75, 23);
            logInBtn.TabIndex = 0;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = true;
            logInBtn.Click += logInBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(90, 7);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 1;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // loginAsL
            // 
            loginAsL.AutoSize = true;
            loginAsL.Location = new Point(580, 11);
            loginAsL.Name = "loginAsL";
            loginAsL.Size = new Size(54, 15);
            loginAsL.TabIndex = 2;
            loginAsL.Text = "Login as:";
            // 
            // coinPanel
            // 
            coinPanel.AutoScroll = true;
            coinPanel.BackColor = Color.Gainsboro;
            coinPanel.Location = new Point(10, 56);
            coinPanel.Name = "coinPanel";
            coinPanel.Size = new Size(778, 382);
            coinPanel.TabIndex = 3;
            // 
            // refreshStoreBtn
            // 
            refreshStoreBtn.Location = new Point(171, 7);
            refreshStoreBtn.Name = "refreshStoreBtn";
            refreshStoreBtn.Size = new Size(92, 23);
            refreshStoreBtn.TabIndex = 4;
            refreshStoreBtn.Text = "Refresh store";
            refreshStoreBtn.UseVisualStyleBackColor = true;
            refreshStoreBtn.Click += refreshStoreBtn_Click;
            // 
            // balanceL
            // 
            balanceL.AutoSize = true;
            balanceL.Location = new Point(434, 11);
            balanceL.Name = "balanceL";
            balanceL.Size = new Size(54, 15);
            balanceL.TabIndex = 5;
            balanceL.Text = "Balance: ";
            // 
            // saveLogsBtn
            // 
            saveLogsBtn.Location = new Point(269, 7);
            saveLogsBtn.Name = "saveLogsBtn";
            saveLogsBtn.Size = new Size(75, 23);
            saveLogsBtn.TabIndex = 6;
            saveLogsBtn.Text = "Save logs";
            saveLogsBtn.UseVisualStyleBackColor = true;
            saveLogsBtn.Click += saveLogsBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveLogsBtn);
            Controls.Add(balanceL);
            Controls.Add(refreshStoreBtn);
            Controls.Add(coinPanel);
            Controls.Add(loginAsL);
            Controls.Add(registerBtn);
            Controls.Add(logInBtn);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logInBtn;
        private Button registerBtn;
        private Label loginAsL;
        private Panel coinPanel;
        private Button refreshStoreBtn;
        private Label balanceL;
        private Button saveLogsBtn;
    }
}