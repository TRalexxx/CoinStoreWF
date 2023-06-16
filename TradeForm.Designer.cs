namespace CoinStoreWF
{
    partial class TradeForm
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
            coinsCB = new ComboBox();
            chooseCoinL = new Label();
            okBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // coinsCB
            // 
            coinsCB.FormattingEnabled = true;
            coinsCB.ImeMode = ImeMode.Disable;
            coinsCB.Location = new Point(12, 29);
            coinsCB.Name = "coinsCB";
            coinsCB.Size = new Size(242, 23);
            coinsCB.TabIndex = 0;
            // 
            // chooseCoinL
            // 
            chooseCoinL.AutoSize = true;
            chooseCoinL.Location = new Point(12, 9);
            chooseCoinL.Name = "chooseCoinL";
            chooseCoinL.Size = new Size(73, 15);
            chooseCoinL.TabIndex = 1;
            chooseCoinL.Text = "Choose coin";
            // 
            // okBtn
            // 
            okBtn.Location = new Point(12, 59);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 2;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(179, 59);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // TradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 94);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(chooseCoinL);
            Controls.Add(coinsCB);
            Name = "TradeForm";
            Text = "TradeForm";
            Load += TradeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox coinsCB;
        private Label chooseCoinL;
        private Button okBtn;
        private Button cancelBtn;
    }
}