namespace F74116720_practice_3_1
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.RiskyAccountButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchResultLabel = new System.Windows.Forms.Label();
            this.AddOrDeleteButton = new System.Windows.Forms.Button();
            this.SearchResultTextBox = new System.Windows.Forms.RichTextBox();
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(956, 59);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(149, 52);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Clicked);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(340, 73);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(475, 36);
            this.SearchTextBox.TabIndex = 1;
            // 
            // RiskyAccountButton
            // 
            this.RiskyAccountButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiskyAccountButton.Location = new System.Drawing.Point(187, 181);
            this.RiskyAccountButton.Name = "RiskyAccountButton";
            this.RiskyAccountButton.Size = new System.Drawing.Size(807, 57);
            this.RiskyAccountButton.TabIndex = 2;
            this.RiskyAccountButton.Text = "Risky Account";
            this.RiskyAccountButton.UseVisualStyleBackColor = true;
            this.RiskyAccountButton.Click += new System.EventHandler(this.RiskyAccountButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(87, 73);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(135, 31);
            this.SearchLabel.TabIndex = 3;
            this.SearchLabel.Text = "Search Bar";
            // 
            // SearchResultLabel
            // 
            this.SearchResultLabel.AutoSize = true;
            this.SearchResultLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResultLabel.Location = new System.Drawing.Point(87, 303);
            this.SearchResultLabel.Name = "SearchResultLabel";
            this.SearchResultLabel.Size = new System.Drawing.Size(169, 31);
            this.SearchResultLabel.TabIndex = 4;
            this.SearchResultLabel.Text = "Search Result";
            // 
            // AddOrDeleteButton
            // 
            this.AddOrDeleteButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrDeleteButton.Location = new System.Drawing.Point(854, 288);
            this.AddOrDeleteButton.Name = "AddOrDeleteButton";
            this.AddOrDeleteButton.Size = new System.Drawing.Size(251, 46);
            this.AddOrDeleteButton.TabIndex = 5;
            this.AddOrDeleteButton.Text = "Add or Delete";
            this.AddOrDeleteButton.UseVisualStyleBackColor = true;
            this.AddOrDeleteButton.Click += new System.EventHandler(this.SwitchMode);
            // 
            // SearchResultTextBox
            // 
            this.SearchResultTextBox.Location = new System.Drawing.Point(187, 363);
            this.SearchResultTextBox.Name = "SearchResultTextBox";
            this.SearchResultTextBox.Size = new System.Drawing.Size(807, 330);
            this.SearchResultTextBox.TabIndex = 6;
            this.SearchResultTextBox.Text = "";
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Location = new System.Drawing.Point(354, 431);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(585, 36);
            this.LinkTextBox.TabIndex = 7;
            this.LinkTextBox.Visible = false;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(354, 500);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(585, 36);
            this.UserTextBox.TabIndex = 8;
            this.UserTextBox.Visible = false;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(354, 568);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(585, 36);
            this.PassTextBox.TabIndex = 9;
            this.PassTextBox.Visible = false;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.Location = new System.Drawing.Point(152, 436);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(60, 31);
            this.LinkLabel.TabIndex = 10;
            this.LinkLabel.Text = "Link";
            this.LinkLabel.Visible = false;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(152, 505);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(66, 31);
            this.UserLabel.TabIndex = 11;
            this.UserLabel.Text = "User";
            this.UserLabel.Visible = false;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(152, 568);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(122, 31);
            this.PassLabel.TabIndex = 12;
            this.PassLabel.Text = "Password";
            this.PassLabel.Visible = false;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(649, 638);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 55);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(819, 638);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 55);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusBar.Location = new System.Drawing.Point(158, 363);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(781, 36);
            this.StatusBar.TabIndex = 15;
            this.StatusBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 741);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.LinkTextBox);
            this.Controls.Add(this.SearchResultTextBox);
            this.Controls.Add(this.AddOrDeleteButton);
            this.Controls.Add(this.SearchResultLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.RiskyAccountButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button RiskyAccountButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label SearchResultLabel;
        private System.Windows.Forms.Button AddOrDeleteButton;
        private System.Windows.Forms.RichTextBox SearchResultTextBox;
        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox StatusBar;
    }
}

