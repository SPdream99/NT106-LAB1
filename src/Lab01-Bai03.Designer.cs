namespace Lab1
{
    partial class Lab01_Bai03
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Gray;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Location = new System.Drawing.Point(646, 197);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(101, 49);
            this.RemoveButton.TabIndex = 0;
            this.RemoveButton.Text = "Xóa";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(318, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(114, 36);
            this.Title.TabIndex = 1;
            this.Title.Text = "Đọc số";            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(398, 143);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.MaxLength = 1;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(172, 22);
            this.InputBox.TabIndex = 2;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(62, 136);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(302, 29);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Nhập vào số nguyên từ 0-9:";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(67, 296);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(228, 22);
            this.ResultBox.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Location = new System.Drawing.Point(646, 269);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 49);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.Gray;
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FindButton.Location = new System.Drawing.Point(646, 128);
            this.FindButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(103, 49);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Tìm";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(62, 237);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(93, 25);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Kết quả ";
            // 
            // Lab01_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RemoveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab01_Bai03";
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

