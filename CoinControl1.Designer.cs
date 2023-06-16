namespace CoinStoreWF
{
    partial class CoinControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameL = new Label();
            descriprionTB = new TextBox();
            costL = new Label();
            ownerL = new Label();
            buyBtn = new Button();
            tradeBtn = new Button();
            SuspendLayout();
            // 
            // nameL
            // 
            nameL.AutoSize = true;
            nameL.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameL.Location = new Point(8, 8);
            nameL.Name = "nameL";
            nameL.Size = new Size(46, 17);
            nameL.TabIndex = 0;
            nameL.Text = "nameL";
            // 
            // descriprionTB
            // 
            descriprionTB.Location = new Point(8, 28);
            descriprionTB.Multiline = true;
            descriprionTB.Name = "descriprionTB";
            descriprionTB.ReadOnly = true;
            descriprionTB.ScrollBars = ScrollBars.Vertical;
            descriprionTB.Size = new Size(388, 40);
            descriprionTB.TabIndex = 1;
            // 
            // costL
            // 
            costL.AutoSize = true;
            costL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            costL.Location = new Point(8, 89);
            costL.Name = "costL";
            costL.Size = new Size(45, 19);
            costL.TabIndex = 2;
            costL.Text = "costL";
            // 
            // ownerL
            // 
            ownerL.AutoSize = true;
            ownerL.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ownerL.Location = new Point(409, 8);
            ownerL.Name = "ownerL";
            ownerL.Size = new Size(63, 18);
            ownerL.TabIndex = 3;
            ownerL.Text = "ownerL";
            // 
            // buyBtn
            // 
            buyBtn.Location = new Point(523, 58);
            buyBtn.Name = "buyBtn";
            buyBtn.Size = new Size(75, 23);
            buyBtn.TabIndex = 4;
            buyBtn.Text = "Buy";
            buyBtn.UseVisualStyleBackColor = true;
            buyBtn.Click += buyBtn_Click;
            // 
            // tradeBtn
            // 
            tradeBtn.Location = new Point(523, 89);
            tradeBtn.Name = "tradeBtn";
            tradeBtn.Size = new Size(75, 23);
            tradeBtn.TabIndex = 5;
            tradeBtn.Text = "Trade";
            tradeBtn.UseVisualStyleBackColor = true;
            tradeBtn.Click += tradeBtn_Click;
            // 
            // CoinControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            Controls.Add(tradeBtn);
            Controls.Add(buyBtn);
            Controls.Add(ownerL);
            Controls.Add(costL);
            Controls.Add(descriprionTB);
            Controls.Add(nameL);
            Name = "CoinControl1";
            Size = new Size(601, 125);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameL;
        private TextBox descriprionTB;
        private Label costL;
        private Label ownerL;
        private Button buyBtn;
        private Button tradeBtn;
    }
}
