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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            InputButton.Clear();
            ResultBox.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string numToText(Int16 i)
            {
                switch (i)
                {
                    case 0:
                        return "Không";
                    case 1:
                        return "Một";
                    case 2:
                        return "Hai";
                    case 3:
                        return "Ba";
                    case 4:
                        return "Bốn";
                    case 5:
                        return "Năm";
                    case 6:
                        return "Sáu";
                    case 7:
                        return "Bảy";
                    case 8:
                        return "Tám";
                    case 9:
                        return "Chín";
                    default:
                        return "";
                }
            }
            try
            {
                string input = InputButton.Text;
                while (input.Length > 1)
                {
                    if (input[0] == '0') input = input.Substring(1);
                    else break;
                }
                string t = "";
                bool firstZero = true;
                for (int idx = input.Length - 1; idx >= 0; idx--)
                {
                    Int16 i = Int16.Parse(input[idx].ToString());
                    string gt = numToText(i);
                    int pos = input.Length - 1 - idx;
                    switch (pos)
                    {
                        case 3:
                            if ((input.Length <= 6 && firstZero) || !firstZero) t = "Nghìn " + t;
                            break;
                        case 6:
                            if ((input.Length <= 9 && firstZero) || !firstZero) t = "Triệu " + t;
                            break;
                        case 9:
                            t = "Tỷ " + t;
                            break;
                    }
                    if (idx > 0 && i == 0 && firstZero == true) continue;
                    else firstZero = false;
                    switch (pos%3)
                    {
                        case 2:
                            t = gt + " Trăm " + t;
                            break;
                        case 1:
                            if (i == 0)
                                t = "Lẻ " + t;
                            else if (i == 1)
                                t = "Mười " + t;
                            else
                                t = gt + " Mươi " + t;
                            break;
                        case 0:
                            t = gt + ((pos != 0) ? " " : "") + t;
                            break;
                    }
                }
                t = t.Replace("Mươi Năm", "Mươi Lăm").Replace("Mười Năm", "Mười Lăm");
                ResultBox.Text = t;
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
