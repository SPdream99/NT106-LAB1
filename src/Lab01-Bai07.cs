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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ResultBox.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            DateTime date = DatePicker.Value;
            string text = "cung ";
            switch (date)
            {
                case var _ when (date.Month == 3 && date.Day >= 21) || (date.Month == 4 && date.Day <= 20):
                    text += "Bạch Dương";
                    break;
                case var _ when (date.Month == 4 && date.Day >= 21) || (date.Month == 5 && date.Day <= 21):
                    text += "Kim Ngưu";
                    break;
                case var _ when (date.Month == 5 && date.Day >= 22) || (date.Month == 6 && date.Day <= 21):
                    text += "Song Tử";
                    break;
                case var _ when (date.Month == 6 && date.Day >= 22) || (date.Month == 7 && date.Day <= 22):
                    text += "Cự Giải";
                    break;
                case var _ when (date.Month == 7 && date.Day >= 23) || (date.Month == 8 && date.Day <= 22):
                    text += "Sử Tử";
                    break;
                case var _ when (date.Month == 8 && date.Day >= 23) || (date.Month == 9 && date.Day <= 23):
                    text += "Xử Nữ";
                    break;
                case var _ when (date.Month == 9 && date.Day >= 24) || (date.Month == 10 && date.Day <= 23):
                    text += "Thiên Bình";
                    break;
                case var _ when (date.Month == 10 && date.Day >= 24) || (date.Month == 11 && date.Day <= 22):
                    text += "Thần Nông";
                    break;
                case var _ when (date.Month == 11 && date.Day >= 23) || (date.Month == 12 && date.Day <= 21):
                    text += "Nhân Mã";
                    break;
                case var _ when (date.Month == 12 && date.Day >= 22) || (date.Month == 1 && date.Day <= 20):
                    text += "Ma Kết";
                    break;
                case var _ when (date.Month == 1 && date.Day >= 21) || (date.Month == 2 && date.Day <= 19):
                    text += "Bảo Bình";
                    break;
                case var _ when (date.Month == 2 && date.Day >= 20) || (date.Month == 3 && date.Day <= 20):
                    text += "Song Ngư";
                    break;
            }
            ResultBox.Text = text;
        }
    }
}