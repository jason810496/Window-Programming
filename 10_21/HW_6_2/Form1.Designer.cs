namespace F74116720_practice_6_2
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.TelePage = new System.Windows.Forms.TabPage();
            this.TeleLabel = new System.Windows.Forms.Label();
            this.LogPage = new System.Windows.Forms.TabPage();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Tab.SuspendLayout();
            this.TelePage.SuspendLayout();
            this.LogPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.TelePage);
            this.Tab.Controls.Add(this.LogPage);
            this.Tab.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(516, 452);
            this.Tab.TabIndex = 0;
            this.Tab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyUp);
            // 
            // TelePage
            // 
            this.TelePage.Controls.Add(this.TeleLabel);
            this.TelePage.Location = new System.Drawing.Point(4, 26);
            this.TelePage.Name = "TelePage";
            this.TelePage.Padding = new System.Windows.Forms.Padding(3);
            this.TelePage.Size = new System.Drawing.Size(508, 422);
            this.TelePage.TabIndex = 0;
            this.TelePage.Text = "Telephone";
            this.TelePage.UseVisualStyleBackColor = true;
            // 
            // TeleLabel
            // 
            this.TeleLabel.AutoSize = true;
            this.TeleLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TeleLabel.Location = new System.Drawing.Point(8, 15);
            this.TeleLabel.Name = "TeleLabel";
            this.TeleLabel.Size = new System.Drawing.Size(107, 24);
            this.TeleLabel.TabIndex = 1;
            this.TeleLabel.Text = "Telephone";
            // 
            // LogPage
            // 
            this.LogPage.Controls.Add(this.SaveBtn);
            this.LogPage.Controls.Add(this.PathTextBox);
            this.LogPage.Controls.Add(this.label1);
            this.LogPage.Controls.Add(this.richTextBox1);
            this.LogPage.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LogPage.Location = new System.Drawing.Point(4, 26);
            this.LogPage.Name = "LogPage";
            this.LogPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogPage.Size = new System.Drawing.Size(508, 422);
            this.LogPage.TabIndex = 1;
            this.LogPage.Text = "Log";
            this.LogPage.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(423, 22);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(109, 19);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(290, 25);
            this.PathTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(452, 325);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "TT";
            this.Tab.ResumeLayout(false);
            this.TelePage.ResumeLayout(false);
            this.TelePage.PerformLayout();
            this.LogPage.ResumeLayout(false);
            this.LogPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage TelePage;
        private System.Windows.Forms.Label TeleLabel;
        private System.Windows.Forms.TabPage LogPage;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

