namespace F74116720_practice_5_1
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MissLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartButton.Location = new System.Drawing.Point(555, 548);
            this.StartButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(271, 108);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartLabel.Location = new System.Drawing.Point(277, 174);
            this.StartLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(753, 48);
            this.StartLabel.TabIndex = 1;
            this.StartLabel.Text = "Enter the word you want to be guessed.";
            // 
            // StartTextBox
            // 
            this.StartTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StartTextBox.Location = new System.Drawing.Point(490, 338);
            this.StartTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(375, 50);
            this.StartTextBox.TabIndex = 2;
            this.StartTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTextBox_KeyPress);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeLabel.Location = new System.Drawing.Point(1109, 500);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(130, 48);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Time :";
            this.TimeLabel.Visible = false;
            // 
            // MissLabel
            // 
            this.MissLabel.AutoSize = true;
            this.MissLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MissLabel.Location = new System.Drawing.Point(1109, 559);
            this.MissLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.MissLabel.Name = "MissLabel";
            this.MissLabel.Size = new System.Drawing.Size(124, 48);
            this.MissLabel.TabIndex = 4;
            this.MissLabel.Text = "Miss :";
            this.MissLabel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 872);
            this.Controls.Add(this.MissLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.StartTextBox);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.StartButton);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label MissLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

