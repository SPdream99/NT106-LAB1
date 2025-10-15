using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
            MaxBox.Clear();
            AvgBox.Clear();
            MinBox.Clear();
            PassBox.Clear();
            FailBox.Clear();
            EvaluationBox.Clear();
            NameBox.Clear();
            MarkPanel.Hide();
            MarkTable.Controls.Clear();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            void addToTable<T>(TableLayoutPanel table, T s) {
                Label label = new Label();
                label.Text = s.ToString();
                label.Anchor = AnchorStyles.None;
                label.TextAlign = ContentAlignment.MiddleCenter;
                table.Controls.Add(label);
            }
            string xepLoai(double dtb, List<double> l)
            {
                switch (dtb)
                {
                    case var _ when dtb >= 8 && l.Count(n => n < 6.5) == 0:
                        return "Giỏi";
                    case var _ when dtb >= 6.5 && l.Count(n => n < 5) == 0:
                        return "Khá";
                    case var _ when dtb >= 5 && l.Count(n => n < 3.5) == 0:
                        return "Trung bình";
                    case var _ when dtb >= 3.5 && l.Count(n => n < 2) == 0:
                        return "Yếu";
                }
                return "Kém";
            }
            try
            {
                MarkPanel.Hide();
                MarkTable.Controls.Clear();
                string text = InputBox.Text;
                List<string> info = text.Split(',').ToList();
                if (info.Count < 2) throw new Exception("Vui lòng nhập thêm dữ liệu!");
                List<Double> marks = new List<Double>();
                if (info[0] == "") throw new Exception("Tên sinh viên không được để trống!");
                NameBox.Text = info[0];
                info.RemoveAt(0);
                for (int i = 0; i < info.Count; i++)
                {
                    marks.Add(double.Parse(info[i]));
                    if (marks[i] < 0 || marks[i]>10) throw new Exception("Điểm phải trong khoảng 0-10!");
                }
                addToTable(MarkTable, "Môn học");
                addToTable(MarkTable, "Điểm");
                for (int i = 0; i < marks.Count; i++)
                {
                    MarkTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                    addToTable(MarkTable, "Môn " + (i+1).ToString());
                    addToTable(MarkTable, marks[i]);
                }
                MarkPanel.Show();
                AvgBox.Text = marks.Average().ToString();
                MaxBox.Text = marks.Max().ToString();
                MinBox.Text = marks.Min().ToString();
                PassBox.Text = marks.Count(n => n >= 5).ToString();
                FailBox.Text = marks.Count(n => n < 5).ToString();
                EvaluationBox.Text = xepLoai(marks.Average(), marks);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
