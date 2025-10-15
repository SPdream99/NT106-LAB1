namespace Lab1
{
    partial class Lab01_Bai05
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
            this.MovieLabel = new System.Windows.Forms.Label();
            this.BasicCostBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.BasicCostLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.SeatPickerGroup = new System.Windows.Forms.GroupBox();
            this.ScreenText = new System.Windows.Forms.Label();
            this.SeatPicker = new System.Windows.Forms.GroupBox();
            this.MovieMenu = new System.Windows.Forms.ComboBox();
            this.RoomMenu = new System.Windows.Forms.ComboBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameBox = new System.Windows.Forms.TextBox();
            this.BillBox = new System.Windows.Forms.TextBox();
            this.SeatPickerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Gray;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Location = new System.Drawing.Point(175, 685);
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
            this.Title.Location = new System.Drawing.Point(358, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(73, 36);
            this.Title.TabIndex = 1;
            this.Title.Text = "Rạp";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(55, 65);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(37, 16);
            this.MovieLabel.TabIndex = 3;
            this.MovieLabel.Text = "Phim";
            // 
            // BasicCostBox
            // 
            this.BasicCostBox.Location = new System.Drawing.Point(223, 115);
            this.BasicCostBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BasicCostBox.Name = "BasicCostBox";
            this.BasicCostBox.ReadOnly = true;
            this.BasicCostBox.Size = new System.Drawing.Size(97, 22);
            this.BasicCostBox.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Location = new System.Drawing.Point(309, 685);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 49);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.Gray;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExportButton.Location = new System.Drawing.Point(31, 685);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(103, 49);
            this.ExportButton.TabIndex = 9;
            this.ExportButton.Text = "Xuất";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(381, 71);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(46, 16);
            this.RoomLabel.TabIndex = 11;
            this.RoomLabel.Text = "Phòng";
            // 
            // BasicCostLabel
            // 
            this.BasicCostLabel.AutoSize = true;
            this.BasicCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicCostLabel.Location = new System.Drawing.Point(53, 116);
            this.BasicCostLabel.Name = "BasicCostLabel";
            this.BasicCostLabel.Size = new System.Drawing.Size(145, 25);
            this.BasicCostLabel.TabIndex = 7;
            this.BasicCostLabel.Text = "Giá vé cơ bản";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(420, 714);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(122, 25);
            this.CostLabel.TabIndex = 13;
            this.CostLabel.Text = "Thanh toán";
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(563, 712);
            this.CostBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CostBox.Name = "CostBox";
            this.CostBox.ReadOnly = true;
            this.CostBox.Size = new System.Drawing.Size(208, 22);
            this.CostBox.TabIndex = 12;
            // 
            // SeatPickerGroup
            // 
            this.SeatPickerGroup.Controls.Add(this.ScreenText);
            this.SeatPickerGroup.Controls.Add(this.SeatPicker);
            this.SeatPickerGroup.Location = new System.Drawing.Point(25, 156);
            this.SeatPickerGroup.Name = "SeatPickerGroup";
            this.SeatPickerGroup.Size = new System.Drawing.Size(746, 510);
            this.SeatPickerGroup.TabIndex = 14;
            this.SeatPickerGroup.TabStop = false;
            // 
            // ScreenText
            // 
            this.ScreenText.AutoSize = true;
            this.ScreenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenText.Location = new System.Drawing.Point(349, 18);
            this.ScreenText.Name = "ScreenText";
            this.ScreenText.Size = new System.Drawing.Size(75, 25);
            this.ScreenText.TabIndex = 1;
            this.ScreenText.Text = "Screen";
            // 
            // SeatPicker
            // 
            this.SeatPicker.Enabled = false;
            this.SeatPicker.Location = new System.Drawing.Point(3, 56);
            this.SeatPicker.Name = "SeatPicker";
            this.SeatPicker.Size = new System.Drawing.Size(745, 453);
            this.SeatPicker.TabIndex = 0;
            this.SeatPicker.TabStop = false;
            this.SeatPicker.Visible = false;
            // 
            // MovieMenu
            // 
            this.MovieMenu.FormattingEnabled = true;
            this.MovieMenu.Location = new System.Drawing.Point(105, 60);
            this.MovieMenu.Name = "MovieMenu";
            this.MovieMenu.Size = new System.Drawing.Size(204, 24);
            this.MovieMenu.TabIndex = 15;
            this.MovieMenu.SelectedIndexChanged += new System.EventHandler(this.MovieMenu_SelectedIndexChanged);
            // 
            // RoomMenu
            // 
            this.RoomMenu.Enabled = false;
            this.RoomMenu.FormattingEnabled = true;
            this.RoomMenu.Location = new System.Drawing.Point(428, 63);
            this.RoomMenu.Name = "RoomMenu";
            this.RoomMenu.Size = new System.Drawing.Size(204, 24);
            this.RoomMenu.TabIndex = 16;
            this.RoomMenu.SelectedIndexChanged += new System.EventHandler(this.RoomMenu_SelectedIndexChanged);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(359, 117);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(168, 25);
            this.CustomerNameLabel.TabIndex = 18;
            this.CustomerNameLabel.Text = "Tên khách hàng";
            // 
            // CustomerNameBox
            // 
            this.CustomerNameBox.Location = new System.Drawing.Point(543, 114);
            this.CustomerNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerNameBox.Name = "CustomerNameBox";
            this.CustomerNameBox.Size = new System.Drawing.Size(228, 22);
            this.CustomerNameBox.TabIndex = 17;
            // 
            // BillBox
            // 
            this.BillBox.Enabled = false;
            this.BillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillBox.Location = new System.Drawing.Point(146, 766);
            this.BillBox.Multiline = true;
            this.BillBox.Name = "BillBox";
            this.BillBox.ReadOnly = true;
            this.BillBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BillBox.Size = new System.Drawing.Size(503, 153);
            this.BillBox.TabIndex = 19;
            this.BillBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillBox.Visible = false;
            // 
            // Lab01_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(803, 953);
            this.Controls.Add(this.BillBox);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameBox);
            this.Controls.Add(this.RoomMenu);
            this.Controls.Add(this.MovieMenu);
            this.Controls.Add(this.SeatPickerGroup);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.RoomLabel);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BasicCostLabel);
            this.Controls.Add(this.BasicCostBox);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RemoveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab01_Bai05";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Bai5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SeatPickerGroup.ResumeLayout(false);
            this.SeatPickerGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.TextBox BasicCostBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.GroupBox SeatPickerGroup;
        private System.Windows.Forms.ComboBox MovieMenu;
        private System.Windows.Forms.ComboBox RoomMenu;
        private System.Windows.Forms.GroupBox SeatPicker;
        private System.Windows.Forms.Label ScreenText;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox CustomerNameBox;
        private System.Windows.Forms.Label BasicCostLabel;
        private System.Windows.Forms.TextBox BillBox;
    }
}

