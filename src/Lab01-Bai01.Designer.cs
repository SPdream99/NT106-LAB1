namespace Lab1
{
    partial class Lab01_Bai01
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.FirstText = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.SecondText = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Gray;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CalculateButton.Location = new System.Drawing.Point(343, 263);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(109, 43);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Tính";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(123, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(506, 36);
            this.Title.TabIndex = 1;
            this.Title.Text = "Phần mềm tính tổng hai số nguyên";
            // 
            // FirstText
            // 
            this.FirstText.Location = new System.Drawing.Point(263, 142);
            this.FirstText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstText.Name = "FirstText";
            this.FirstText.Size = new System.Drawing.Size(172, 22);
            this.FirstText.TabIndex = 2;
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Location = new System.Drawing.Point(169, 149);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(72, 16);
            this.FirstLabel.TabIndex = 3;
            this.FirstLabel.Text = "Số thứ nhất";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(169, 206);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(65, 16);
            this.SecondLabel.TabIndex = 5;
            this.SecondLabel.Text = "Số thứ hai";
            // 
            // SecondText
            // 
            this.SecondText.Location = new System.Drawing.Point(263, 199);
            this.SecondText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondText.Name = "SecondText";
            this.SecondText.Size = new System.Drawing.Size(172, 22);
            this.SecondText.TabIndex = 4;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(169, 346);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(62, 25);
            this.Sum.TabIndex = 7;
            this.Sum.Text = "Tổng";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(245, 340);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(228, 22);
            this.ResultBox.TabIndex = 6;
            // 
            // Lab01_Bai01
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.SecondText);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.FirstText);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CalculateButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab01_Bai01";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox FirstText;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.TextBox SecondText;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.TextBox ResultBox;
    }
}

