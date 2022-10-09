namespace F74116720_practice_4_2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GameAreaTab = new System.Windows.Forms.TabPage();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.HistoryTestBox = new System.Windows.Forms.RichTextBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.GameAreaTab.SuspendLayout();
            this.HistoryPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("微软雅黑", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(13, 16);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(236, 30);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Card Flipping Game";
            // 
            // StartGameButton
            // 
            this.StartGameButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.Location = new System.Drawing.Point(583, 125);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(106, 30);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Enabled = false;
            this.ContinueButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(583, 180);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(106, 30);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // LeaveButton
            // 
            this.LeaveButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveButton.Location = new System.Drawing.Point(583, 354);
            this.LeaveButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(106, 30);
            this.LeaveButton.TabIndex = 5;
            this.LeaveButton.Text = "Leave Game";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GameAreaTab);
            this.tabControl1.Controls.Add(this.HistoryPage);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 473);
            this.tabControl1.TabIndex = 6;
            // 
            // GameAreaTab
            // 
            this.GameAreaTab.Controls.Add(this.RestartButton);
            this.GameAreaTab.Controls.Add(this.UserTextBox);
            this.GameAreaTab.Controls.Add(this.UserLabel);
            this.GameAreaTab.Controls.Add(this.ScoreLabel);
            this.GameAreaTab.Controls.Add(this.LeaveButton);
            this.GameAreaTab.Controls.Add(this.StartGameButton);
            this.GameAreaTab.Controls.Add(this.ContinueButton);
            this.GameAreaTab.Location = new System.Drawing.Point(4, 26);
            this.GameAreaTab.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.GameAreaTab.Name = "GameAreaTab";
            this.GameAreaTab.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.GameAreaTab.Size = new System.Drawing.Size(715, 443);
            this.GameAreaTab.TabIndex = 0;
            this.GameAreaTab.Text = "Game Area";
            this.GameAreaTab.UseVisualStyleBackColor = true;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.Location = new System.Drawing.Point(232, 12);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(184, 29);
            this.UserTextBox.TabIndex = 8;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(128, 16);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(96, 21);
            this.UserLabel.TabIndex = 7;
            this.UserLabel.Text = "Username :";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(11, 16);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(93, 21);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "Score : 100";
            // 
            // HistoryPage
            // 
            this.HistoryPage.Controls.Add(this.HistoryTestBox);
            this.HistoryPage.Location = new System.Drawing.Point(4, 26);
            this.HistoryPage.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.HistoryPage.Size = new System.Drawing.Size(715, 443);
            this.HistoryPage.TabIndex = 1;
            this.HistoryPage.Text = "History";
            this.HistoryPage.UseVisualStyleBackColor = true;
            // 
            // HistoryTestBox
            // 
            this.HistoryTestBox.Location = new System.Drawing.Point(42, 21);
            this.HistoryTestBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.HistoryTestBox.Name = "HistoryTestBox";
            this.HistoryTestBox.Size = new System.Drawing.Size(623, 325);
            this.HistoryTestBox.TabIndex = 0;
            this.HistoryTestBox.Text = "";
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(583, 234);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(106, 30);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Restart Game";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 542);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Card Flipping Game II";
            this.tabControl1.ResumeLayout(false);
            this.GameAreaTab.ResumeLayout(false);
            this.GameAreaTab.PerformLayout();
            this.HistoryPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GameAreaTab;
        private System.Windows.Forms.TabPage HistoryPage;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.RichTextBox HistoryTestBox;
        private System.Windows.Forms.Button RestartButton;
    }
}

