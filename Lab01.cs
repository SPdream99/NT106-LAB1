using System;
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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai01();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai02();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai03();
            form.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var form = new Lab01_Bai04();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai05();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai06();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai07();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai08();
            form.ShowDialog();
        }
    }
}
