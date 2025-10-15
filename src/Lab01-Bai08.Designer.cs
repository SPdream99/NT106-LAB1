namespace Lab1
{
    partial class Lab01_Bai08
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
            this.AvgBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AvgLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MaxBox = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MinBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.FailLabel = new System.Windows.Forms.Label();
            this.FailBox = new System.Windows.Forms.TextBox();
            this.EvaluationLabel = new System.Windows.Forms.Label();
            this.EvaluationBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MarkTable = new System.Windows.Forms.TableLayoutPanel();
            this.MarkPanel = new System.Windows.Forms.Panel();
            this.MarkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Gray;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Location = new System.Drawing.Point(97, 196);
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
            this.Title.Location = new System.Drawing.Point(342, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(231, 36);
            this.Title.TabIndex = 1;
            this.Title.Text = "Mảng sinh viên";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(141, 143);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(740, 22);
            this.InputBox.TabIndex = 2;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(47, 149);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(77, 16);
            this.InputLabel.TabIndex = 3;
            this.InputLabel.Text = "Nhập mảng";
            // 
            // AvgBox
            // 
            this.AvgBox.Location = new System.Drawing.Point(230, 605);
            this.AvgBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvgBox.Name = "AvgBox";
            this.AvgBox.ReadOnly = true;
            this.AvgBox.Size = new System.Drawing.Size(202, 22);
            this.AvgBox.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Location = new System.Drawing.Point(709, 196);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 49);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gray;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddButton.Location = new System.Drawing.Point(406, 196);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 49);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AvgLabel
            // 
            this.AvgLabel.AutoSize = true;
            this.AvgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgLabel.Location = new System.Drawing.Point(35, 601);
            this.AvgLabel.Name = "AvgLabel";
            this.AvgLabel.Size = new System.Drawing.Size(163, 25);
            this.AvgLabel.TabIndex = 7;
            this.AvgLabel.Text = "Điểm trung bình";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLabel.Location = new System.Drawing.Point(35, 647);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(195, 25);
            this.MaxLabel.TabIndex = 11;
            this.MaxLabel.Text = "Môn điểm cao nhất";
            // 
            // MaxBox
            // 
            this.MaxBox.Location = new System.Drawing.Point(251, 651);
            this.MaxBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.ReadOnly = true;
            this.MaxBox.Size = new System.Drawing.Size(181, 22);
            this.MaxBox.TabIndex = 10;
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLabel.Location = new System.Drawing.Point(35, 692);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(202, 25);
            this.MinLabel.TabIndex = 13;
            this.MinLabel.Text = "Môn điểm thấp nhất";
            // 
            // MinBox
            // 
            this.MinBox.Location = new System.Drawing.Point(268, 696);
            this.MinBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinBox.Name = "MinBox";
            this.MinBox.ReadOnly = true;
            this.MinBox.Size = new System.Drawing.Size(164, 22);
            this.MinBox.TabIndex = 12;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(462, 601);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(128, 25);
            this.PassLabel.TabIndex = 15;
            this.PassLabel.Text = "Số môn đậu";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(661, 605);
            this.PassBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassBox.Name = "PassBox";
            this.PassBox.ReadOnly = true;
            this.PassBox.Size = new System.Drawing.Size(198, 22);
            this.PassBox.TabIndex = 14;
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailLabel.Location = new System.Drawing.Point(462, 651);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(193, 25);
            this.FailLabel.TabIndex = 17;
            this.FailLabel.Text = "Số môn không đậu";
            // 
            // FailBox
            // 
            this.FailBox.Location = new System.Drawing.Point(688, 655);
            this.FailBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FailBox.Name = "FailBox";
            this.FailBox.ReadOnly = true;
            this.FailBox.Size = new System.Drawing.Size(171, 22);
            this.FailBox.TabIndex = 16;
            // 
            // EvaluationLabel
            // 
            this.EvaluationLabel.AutoSize = true;
            this.EvaluationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationLabel.Location = new System.Drawing.Point(462, 696);
            this.EvaluationLabel.Name = "EvaluationLabel";
            this.EvaluationLabel.Size = new System.Drawing.Size(91, 25);
            this.EvaluationLabel.TabIndex = 19;
            this.EvaluationLabel.Text = "Xếp loại";
            // 
            // EvaluationBox
            // 
            this.EvaluationBox.Location = new System.Drawing.Point(631, 700);
            this.EvaluationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EvaluationBox.Name = "EvaluationBox";
            this.EvaluationBox.ReadOnly = true;
            this.EvaluationBox.Size = new System.Drawing.Size(228, 22);
            this.EvaluationBox.TabIndex = 18;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(35, 261);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(104, 25);
            this.NameLabel.TabIndex = 21;
            this.NameLabel.Text = "Họ và tên";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(204, 265);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(228, 22);
            this.NameBox.TabIndex = 20;
            // 
            // MarkTable
            // 
            this.MarkTable.AutoSize = true;
            this.MarkTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.MarkTable.ColumnCount = 2;
            this.MarkTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.13692F));
            this.MarkTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.86308F));
            this.MarkTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarkTable.Location = new System.Drawing.Point(0, 0);
            this.MarkTable.Margin = new System.Windows.Forms.Padding(0);
            this.MarkTable.Name = "MarkTable";
            this.MarkTable.Padding = new System.Windows.Forms.Padding(3);
            this.MarkTable.RowCount = 1;
            this.MarkTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.MarkTable.Size = new System.Drawing.Size(852, 29);
            this.MarkTable.TabIndex = 22;
            // 
            // MarkPanel
            // 
            this.MarkPanel.AutoScroll = true;
            this.MarkPanel.Controls.Add(this.MarkTable);
            this.MarkPanel.Location = new System.Drawing.Point(28, 301);
            this.MarkPanel.Name = "MarkPanel";
            this.MarkPanel.Size = new System.Drawing.Size(852, 286);
            this.MarkPanel.TabIndex = 23;
            // 
            // Lab01_Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(907, 749);
            this.Controls.Add(this.MarkPanel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EvaluationLabel);
            this.Controls.Add(this.EvaluationBox);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.FailBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AvgLabel);
            this.Controls.Add(this.AvgBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RemoveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab01_Bai08";
            this.Text = "Bai8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MarkPanel.ResumeLayout(false);
            this.MarkPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox AvgBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AvgLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.TextBox MaxBox;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.TextBox MinBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.TextBox FailBox;
        private System.Windows.Forms.Label EvaluationLabel;
        private System.Windows.Forms.TextBox EvaluationBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TableLayoutPanel MarkTable;
        private System.Windows.Forms.Panel MarkPanel;
    }
}

