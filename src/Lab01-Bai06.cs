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
            ResultGroup.Hide();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            NumABox.Clear();
            NumBBox.Clear();
            ResultGroup.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
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
                int a = int.Parse(NumABox.Text);
                int b = int.Parse(NumBBox.Text);
                int mode = ModePicker.SelectedIndex;
                if (mode == -1)
                {
                    MessageBox.Show("Vui lòng chọn phương thức tính toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (mode == 0)
                {
                    BangCuuChuong.Controls.Clear();
                    int num = b - a;
                    for (int i = 1; i < 10; i++)
                    {
                        Label label = new Label();
                        label.Text = num.ToString() + " x " + i.ToString();
                        label.Anchor = AnchorStyles.None;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        BangCuuChuong.Controls.Add(label);
                    }
                    for (int i = 1; i < 10; i++)
                    {
                        Label label = new Label();
                        label.Text = (num*i).ToString();
                        label.Anchor = AnchorStyles.None;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        BangCuuChuong.Controls.Add(label);
                    }
                    FirstFormulaBox.Hide();
                    SecondFormulaBox.Hide();
                    FirstFormula.Hide();
                    SecondFormula.Hide();
                    BangCuuChuong.Show();
                    ResultGroup.Show();
                    return;
                }
                else if (mode == 1)
                {
                    FirstFormula.Text = String.Format("{0}! =", a - b);
                    SecondFormula.Text = String.Format("Tổng S với {0}^{1} =", a, b);
                    FirstFormulaBox.Text = ((a-b >= 0) ? tinhGiaiThua(a-b).ToString() : "Số âm không có giai thừa");
                    SecondFormulaBox.Text = ((b>=1)? (tinhTongMu(a, b)).ToString() : "Số b âm không tính từ mũ từ 1 được");
                    BangCuuChuong.Hide();
                    FirstFormulaBox.Show();
                    SecondFormulaBox.Show();
                    FirstFormula.Show();
                    SecondFormula.Show();
                    ResultGroup.Show();
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
