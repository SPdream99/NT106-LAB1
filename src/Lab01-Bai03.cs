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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
            ResultBox.Clear();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Int16.Parse(InputBox.Text);
                string t = "";
                switch (i)
                {
                    case 0:
                        t = "Không";
                        break;
                    case 1:
                        t = "Một";
                        break;
                    case 2:
                        t = "Hai";
                        break;
                    case 3:
                        t = "Ba";
                        break;
                    case 4:
                        t = "Bốn";
                        break;
                    case 5:
                        t = "Năm";
                        break;
                    case 6:
                        t = "Sáu";
                        break;
                    case 7:
                        t = "Bảy";
                        break;
                    case 8:
                        t = "Tám";
                        break;
                    case 9:
                        t = "Chín";
                        break;
                    default:
                        throw new FormatException();
                }
                ResultBox.Text = t;
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
