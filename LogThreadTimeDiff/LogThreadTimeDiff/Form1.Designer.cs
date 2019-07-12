namespace LogThreadTimeDiff
{
    partial class TimeDiffLocator
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
            this.OpenBtn = new System.Windows.Forms.Button();
            this.FileDirectoryTxtBox = new System.Windows.Forms.TextBox();
            this.FileNamelbl = new System.Windows.Forms.Label();
            this.ResultTxtBox = new System.Windows.Forms.TextBox();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.TimeSpanTxtBox = new System.Windows.Forms.TextBox();
            this.TimeSpanlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(172, 58);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(126, 40);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // FileDirectoryTxtBox
            // 
            this.FileDirectoryTxtBox.Location = new System.Drawing.Point(13, 32);
            this.FileDirectoryTxtBox.Name = "FileDirectoryTxtBox";
            this.FileDirectoryTxtBox.Size = new System.Drawing.Size(435, 20);
            this.FileDirectoryTxtBox.TabIndex = 1;
            // 
            // FileNamelbl
            // 
            this.FileNamelbl.AutoSize = true;
            this.FileNamelbl.Location = new System.Drawing.Point(13, 13);
            this.FileNamelbl.Name = "FileNamelbl";
            this.FileNamelbl.Size = new System.Drawing.Size(70, 13);
            this.FileNamelbl.TabIndex = 2;
            this.FileNamelbl.Text = "File Location:";
            // 
            // ResultTxtBox
            // 
            this.ResultTxtBox.Location = new System.Drawing.Point(13, 104);
            this.ResultTxtBox.Multiline = true;
            this.ResultTxtBox.Name = "ResultTxtBox";
            this.ResultTxtBox.Size = new System.Drawing.Size(435, 248);
            this.ResultTxtBox.TabIndex = 3;
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Location = new System.Drawing.Point(13, 90);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(40, 13);
            this.Resultlbl.TabIndex = 4;
            this.Resultlbl.Text = "Result:";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(304, 58);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(144, 40);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start Analysis";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // TimeSpanTxtBox
            // 
            this.TimeSpanTxtBox.Location = new System.Drawing.Point(496, 32);
            this.TimeSpanTxtBox.Name = "TimeSpanTxtBox";
            this.TimeSpanTxtBox.Size = new System.Drawing.Size(86, 20);
            this.TimeSpanTxtBox.TabIndex = 6;
            this.TimeSpanTxtBox.Text = " ";
            // 
            // TimeSpanlbl
            // 
            this.TimeSpanlbl.AutoSize = true;
            this.TimeSpanlbl.Location = new System.Drawing.Point(493, 16);
            this.TimeSpanlbl.Name = "TimeSpanlbl";
            this.TimeSpanlbl.Size = new System.Drawing.Size(61, 13);
            this.TimeSpanlbl.TabIndex = 7;
            this.TimeSpanlbl.Text = "Time Span:";
            // 
            // TimeDiffLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 364);
            this.Controls.Add(this.TimeSpanlbl);
            this.Controls.Add(this.TimeSpanTxtBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.ResultTxtBox);
            this.Controls.Add(this.FileNamelbl);
            this.Controls.Add(this.FileDirectoryTxtBox);
            this.Controls.Add(this.OpenBtn);
            this.Name = "TimeDiffLocator";
            this.Text = "Log Thead Time Diff Locator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.TextBox FileDirectoryTxtBox;
        private System.Windows.Forms.Label FileNamelbl;
        private System.Windows.Forms.TextBox ResultTxtBox;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox TimeSpanTxtBox;
        private System.Windows.Forms.Label TimeSpanlbl;
    }
}

