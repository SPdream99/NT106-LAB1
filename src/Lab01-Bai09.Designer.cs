namespace Lab1
{
    partial class Lab01_Bai09
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
            this.AddButton = new System.Windows.Forms.Button();
            this.FoodMenu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Gray;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Location = new System.Drawing.Point(379, 263);
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
            this.Title.Location = new System.Drawing.Point(295, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(236, 36);
            this.Title.TabIndex = 1;
            this.Title.Text = "Hôm nay ăn gì?";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(141, 143);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(172, 22);
            this.InputBox.TabIndex = 2;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(47, 149);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(87, 16);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Nhập món ăn";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(268, 405);
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
            this.ExitButton.Location = new System.Drawing.Point(589, 263);
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
            this.FindButton.Location = new System.Drawing.Point(157, 263);
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
            this.ResultLabel.Location = new System.Drawing.Point(316, 343);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(127, 25);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Hôm nay ăn";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gray;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddButton.Location = new System.Drawing.Point(181, 191);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 49);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FoodMenu
            // 
            this.FoodMenu.AcceptsReturn = true;
            this.FoodMenu.Location = new System.Drawing.Point(379, 104);
            this.FoodMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FoodMenu.Multiline = true;
            this.FoodMenu.Name = "FoodMenu";
            this.FoodMenu.ReadOnly = true;
            this.FoodMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FoodMenu.Size = new System.Drawing.Size(358, 136);
            this.FoodMenu.TabIndex = 15;
            // 
            // Lab01_Bai09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FoodMenu);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RemoveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab01_Bai09";
            this.Text = "Bai8";
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
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox FoodMenu;
    }
}

