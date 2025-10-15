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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            try
            {
                num1 = Int32.Parse(FirstText.Text);
                num2 = Int32.Parse(SecondText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sum = num1 + num2;
            ResultBox.Text = sum.ToString();
        }
    }
}
