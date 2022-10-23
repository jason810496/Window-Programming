namespace F74116720_practice_6_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BPMLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Label60 = new System.Windows.Forms.Label();
            this.Label180 = new System.Windows.Forms.Label();
            this.Radio1 = new System.Windows.Forms.RadioButton();
            this.Radio2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BeatLabel = new System.Windows.Forms.Label();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.BtnImage1 = new System.Windows.Forms.Button();
            this.BtnImage2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // BPMLabel
            // 
            this.BPMLabel.AutoSize = true;
            this.BPMLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BPMLabel.Location = new System.Drawing.Point(353, 20);
            this.BPMLabel.Name = "BPMLabel";
            this.BPMLabel.Size = new System.Drawing.Size(116, 31);
            this.BPMLabel.TabIndex = 0;
            this.BPMLabel.Text = "120 BPM";
            this.BPMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(191, 81);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(476, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.Bar_ValueChanged);
            // 
            // Label60
            // 
            this.Label60.AutoSize = true;
            this.Label60.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label60.Location = new System.Drawing.Point(134, 81);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(30, 21);
            this.Label60.TabIndex = 2;
            this.Label60.Text = "60";
            this.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label180
            // 
            this.Label180.AutoSize = true;
            this.Label180.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label180.Location = new System.Drawing.Point(674, 81);
            this.Label180.Name = "Label180";
            this.Label180.Size = new System.Drawing.Size(40, 21);
            this.Label180.TabIndex = 3;
            this.Label180.Text = "180";
            this.Label180.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.Radio1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Radio1.Location = new System.Drawing.Point(271, 349);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(14, 13);
            this.Radio1.TabIndex = 4;
            this.Radio1.TabStop = true;
            this.Radio1.UseVisualStyleBackColor = true;
            this.Radio1.CheckedChanged += new System.EventHandler(this.Radio1_CheckedChanged);
            // 
            // Radio2
            // 
            this.Radio2.AutoSize = true;
            this.Radio2.Location = new System.Drawing.Point(556, 349);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(14, 13);
            this.Radio2.TabIndex = 5;
            this.Radio2.TabStop = true;
            this.Radio2.UseVisualStyleBackColor = true;
            this.Radio2.CheckedChanged += new System.EventHandler(this.Radio2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(452, 389);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "4";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // BeatLabel
            // 
            this.BeatLabel.AutoSize = true;
            this.BeatLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BeatLabel.Location = new System.Drawing.Point(266, 387);
            this.BeatLabel.Name = "BeatLabel";
            this.BeatLabel.Size = new System.Drawing.Size(121, 21);
            this.BeatLabel.TabIndex = 7;
            this.BeatLabel.Text = "Beat Emphasis";
            this.BeatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SwitchButton
            // 
            this.SwitchButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SwitchButton.Location = new System.Drawing.Point(382, 423);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(87, 25);
            this.SwitchButton.TabIndex = 8;
            this.SwitchButton.Text = "Start";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "quarternote.png");
            this.ImageList.Images.SetKeyName(1, "quavers.png");
            // 
            // BtnImage1
            // 
            this.BtnImage1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnImage1.Enabled = false;
            this.BtnImage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImage1.Image = ((System.Drawing.Image)(resources.GetObject("BtnImage1.Image")));
            this.BtnImage1.Location = new System.Drawing.Point(181, 222);
            this.BtnImage1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnImage1.Name = "BtnImage1";
            this.BtnImage1.Size = new System.Drawing.Size(206, 124);
            this.BtnImage1.TabIndex = 9;
            this.BtnImage1.UseVisualStyleBackColor = false;
            // 
            // BtnImage2
            // 
            this.BtnImage2.BackColor = System.Drawing.SystemColors.Control;
            this.BtnImage2.Enabled = false;
            this.BtnImage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImage2.Image = ((System.Drawing.Image)(resources.GetObject("BtnImage2.Image")));
            this.BtnImage2.Location = new System.Drawing.Point(452, 222);
            this.BtnImage2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnImage2.Name = "BtnImage2";
            this.BtnImage2.Size = new System.Drawing.Size(206, 124);
            this.BtnImage2.TabIndex = 10;
            this.BtnImage2.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 488);
            this.Controls.Add(this.BtnImage2);
            this.Controls.Add(this.BtnImage1);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.BeatLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Radio2);
            this.Controls.Add(this.Radio1);
            this.Controls.Add(this.Label180);
            this.Controls.Add(this.Label60);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BPMLabel);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "Form1";
            this.Text = "%%%";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BPMLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label Label60;
        private System.Windows.Forms.Label Label180;
        private System.Windows.Forms.RadioButton Radio1;
        private System.Windows.Forms.RadioButton Radio2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label BeatLabel;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button BtnImage1;
        private System.Windows.Forms.Button BtnImage2;
        private System.Windows.Forms.Timer timer1;
    }
}

