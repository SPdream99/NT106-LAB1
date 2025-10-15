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

        private void button1_Click(object sender, EventArgs e)
        {
            FirstText.Clear();
            SecondText.Clear();
            ThirdText.Clear();
            ResultMax.Clear();
            ResultMin.Clear();
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
