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
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            groupBox1.Hide();
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
            int tinhGiaiThua(int n)
            {
                if (n == 0 || n == 1) return 1;
                return n * tinhGiaiThua(n - 1);
            }
            int tinhTongMu(int a, int b)
            {
                int sum = 0;
                for (int i = 1; i <= b; i++)
                {
                    sum += (int)Math.Pow(a, i);
                }
                return sum;
            }
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox4.Text);
                int mode = comboBox1.SelectedIndex;
                if (mode == -1)
                {
                    MessageBox.Show("Vui lòng chọn phương thức tính toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (mode == 0)
                {
                    tableLayoutPanel1.Controls.Clear();
                    int num = b - a;
                    for (int i = 1; i < 10; i++)
                    {
                        Label label = new Label();
                        label.Text = num.ToString() + " x " + i.ToString();
                        label.Anchor = AnchorStyles.None;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(label);
                    }
                    for (int i = 1; i < 10; i++)
                    {
                        Label label = new Label();
                        label.Text = (num*i).ToString();
                        label.Anchor = AnchorStyles.None;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        tableLayoutPanel1.Controls.Add(label);
                    }
                    //tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                    textBox2.Hide();
                    textBox3.Hide();
                    label3.Hide();
                    label4.Hide();
                    tableLayoutPanel1.Show();
                    groupBox1.Show();
                    return;
                }
                else if (mode == 1)
                {
                    label3.Text = String.Format("{0}! =", a - b);
                    label4.Text = String.Format("Tổng S với {0}^{1} =", a, b);
                    textBox2.Text = ((a-b >= 0) ? tinhGiaiThua(a-b).ToString() : "Số âm không có giai thừa");
                    textBox3.Text = ((b>=1)? (tinhTongMu(a, b)).ToString() : "Số b âm không tính từ mũ từ 1 được");
                    tableLayoutPanel1.Hide();
                    textBox2.Show();
                    textBox3.Show();
                    label3.Show();
                    label4.Show();
                    groupBox1.Show();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
