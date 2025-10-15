namespace Lab1
{
    partial class Lab01_Bai06
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
            this.NumABox = new System.Windows.Forms.TextBox();
            this.NumA = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NumB = new System.Windows.Forms.Label();
            this.NumBBox = new System.Windows.Forms.TextBox();
            this.ModePicker = new System.Windows.Forms.ComboBox();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.SecondFormula = new System.Windows.Forms.Label();
            this.SecondFormulaBox = new System.Windows.Forms.TextBox();
            this.FirstFormula = new System.Windows.Forms.Label();
            this.FirstFormulaBox = new System.Windows.Forms.TextBox();
            this.BangCuuChuong = new System.Windows.Forms.TableLayoutPanel();
            this.ResultGroup.SuspendLayout();
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
            this.Title.Location = new System.Drawing.Point(336, 38);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(149, 36);
            this.Title.TabIndex = 1;
            this.Title.Text = "Tính toán";
            // 
            // NumABox
            // 
            this.NumABox.Location = new System.Drawing.Point(141, 143);
            this.NumABox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumABox.Name = "NumABox";
            this.NumABox.Size = new System.Drawing.Size(172, 22);
            this.NumABox.TabIndex = 2;
            // 
            // NumA
            // 
            this.NumA.AutoSize = true;
            this.NumA.Location = new System.Drawing.Point(47, 149);
            this.NumA.Name = "NumA";
            this.NumA.Size = new System.Drawing.Size(36, 16);
            this.NumA.TabIndex = 3;
            this.NumA.Text = "Số A";
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
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Gray;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CalculateButton.Location = new System.Drawing.Point(165, 263);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(103, 49);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Tính";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NumB
            // 
            this.NumB.AutoSize = true;
            this.NumB.Location = new System.Drawing.Point(495, 149);
            this.NumB.Name = "NumB";
            this.NumB.Size = new System.Drawing.Size(36, 16);
            this.NumB.TabIndex = 11;
            this.NumB.Text = "Số B";
            // 
            // NumBBox
            // 
            this.NumBBox.Location = new System.Drawing.Point(589, 143);
            this.NumBBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumBBox.Name = "NumBBox";
            this.NumBBox.Size = new System.Drawing.Size(172, 22);
            this.NumBBox.TabIndex = 10;
            // 
            // ModePicker
            // 
            this.ModePicker.FormattingEnabled = true;
            this.ModePicker.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.ModePicker.Location = new System.Drawing.Point(310, 202);
            this.ModePicker.Name = "ModePicker";
            this.ModePicker.Size = new System.Drawing.Size(170, 24);
            this.ModePicker.TabIndex = 14;
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.SecondFormula);
            this.ResultGroup.Controls.Add(this.SecondFormulaBox);
            this.ResultGroup.Controls.Add(this.FirstFormula);
            this.ResultGroup.Controls.Add(this.FirstFormulaBox);
            this.ResultGroup.Controls.Add(this.BangCuuChuong);
            this.ResultGroup.Location = new System.Drawing.Point(30, 338);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(739, 253);
            this.ResultGroup.TabIndex = 15;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "KẾT QUẢ";
            // 
            // SecondFormula
            // 
            this.SecondFormula.AutoSize = true;
            this.SecondFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondFormula.Location = new System.Drawing.Point(337, 47);
            this.SecondFormula.Name = "SecondFormula";
            this.SecondFormula.Size = new System.Drawing.Size(69, 20);
            this.SecondFormula.TabIndex = 20;
            this.SecondFormula.Text = "PHEP 2";
            // 
            // SecondFormulaBox
            // 
            this.SecondFormulaBox.Location = new System.Drawing.Point(301, 70);
            this.SecondFormulaBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondFormulaBox.Name = "SecondFormulaBox";
            this.SecondFormulaBox.ReadOnly = true;
            this.SecondFormulaBox.Size = new System.Drawing.Size(410, 22);
            this.SecondFormulaBox.TabIndex = 19;
            // 
            // FirstFormula
            // 
            this.FirstFormula.AutoSize = true;
            this.FirstFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstFormula.Location = new System.Drawing.Point(17, 42);
            this.FirstFormula.Name = "FirstFormula";
            this.FirstFormula.Size = new System.Drawing.Size(81, 25);
            this.FirstFormula.TabIndex = 17;
            this.FirstFormula.Text = "PHEP 1";
            // 
            // FirstFormulaBox
            // 
            this.FirstFormulaBox.Location = new System.Drawing.Point(111, 36);
            this.FirstFormulaBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstFormulaBox.Name = "FirstFormulaBox";
            this.FirstFormulaBox.ReadOnly = true;
            this.FirstFormulaBox.Size = new System.Drawing.Size(172, 22);
            this.FirstFormulaBox.TabIndex = 16;
            // 
            // BangCuuChuong
            // 
            this.BangCuuChuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BangCuuChuong.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.BangCuuChuong.ColumnCount = 9;
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BangCuuChuong.Location = new System.Drawing.Point(7, 21);
            this.BangCuuChuong.Name = "BangCuuChuong";
            this.BangCuuChuong.RowCount = 2;
            this.BangCuuChuong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.BangCuuChuong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.BangCuuChuong.Size = new System.Drawing.Size(724, 169);
            this.BangCuuChuong.TabIndex = 18;
            // 
            // Lab01_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.ModePicker);
            this.Controls.Add(this.NumB);
            this.Controls.Add(this.NumBBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NumA);
            this.Controls.Add(this.NumABox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RemoveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab01_Bai06";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox NumABox;
        private System.Windows.Forms.Label NumA;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label NumB;
        private System.Windows.Forms.TextBox NumBBox;
        private System.Windows.Forms.ComboBox ModePicker;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.Label FirstFormula;
        private System.Windows.Forms.TextBox FirstFormulaBox;
        private System.Windows.Forms.Label SecondFormula;
        private System.Windows.Forms.TextBox SecondFormulaBox;
        private System.Windows.Forms.TableLayoutPanel BangCuuChuong;
    }
}

