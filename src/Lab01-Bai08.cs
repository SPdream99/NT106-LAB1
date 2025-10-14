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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            panel1.Hide();
            tableLayoutPanel1.Controls.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
                panel1.Hide();
                tableLayoutPanel1.Controls.Clear();
                string text = textBox1.Text;
                List<string> info = text.Split(',').ToList();
                if (info.Count < 2) throw new Exception("Vui lòng nhập thêm dữ liệu!");
                List<Double> marks = new List<Double>();
                if (info[0] == "") throw new Exception("Tên sinh viên không được để trống!");
                textBox8.Text = info[0];
                info.RemoveAt(0);
                for (int i = 0; i < info.Count; i++)
                {
                    marks.Add(double.Parse(info[i]));
                    if (marks[i] < 0 || marks[i]>10) throw new Exception("Điểm phải trong khoảng 0-10!");
                }
                addToTable(tableLayoutPanel1, "Môn học");
                addToTable(tableLayoutPanel1, "Điểm");
                for (int i = 0; i < marks.Count; i++)
                {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                    addToTable(tableLayoutPanel1, "Môn " + (i+1).ToString());
                    addToTable(tableLayoutPanel1, marks[i]);
                }
                panel1.Show();
                textBox3.Text = marks.Average().ToString();
                textBox2.Text = marks.Max().ToString();
                textBox4.Text = marks.Min().ToString();
                textBox5.Text = marks.Count(n => n >= 5).ToString();
                textBox6.Text = marks.Count(n => n < 5).ToString();
                textBox7.Text = xepLoai(marks.Average(), marks);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
