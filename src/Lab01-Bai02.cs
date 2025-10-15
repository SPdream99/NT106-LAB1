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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            FirstText.Clear();
            SecondText.Clear();
            ThirdText.Clear();
            ResultMax.Clear();
            ResultMin.Clear();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            double largest, smallest;
            try
            {
                List<double> numbers = new List<double> { };
                if (FirstText.Text != "") numbers.Add(double.Parse(FirstText.Text));
                if (SecondText.Text != "") numbers.Add(double.Parse(SecondText.Text));
                if (ThirdText.Text != "") numbers.Add(double.Parse(ThirdText.Text));
                largest = numbers.Max();
                smallest = numbers.Min();
                ResultMax.Text = largest.ToString();
                ResultMin.Text = smallest.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Số không hợp lệ!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
