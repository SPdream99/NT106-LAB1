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

        private void Bai1Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai01();
            form.ShowDialog();
        }

        private void Bai2Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai02();
            form.ShowDialog();
        }

        private void Bai3Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai03();
            form.ShowDialog();
        }

        private void Bai4Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai04();
            form.ShowDialog();
        }

        private void Bai5Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai05();
            form.ShowDialog();
        }

        private void Bai6Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai06();
            form.ShowDialog();
        }

        private void Bai7Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai07();
            form.ShowDialog();
        }

        private void Bai8Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai08();
            form.ShowDialog();
        }

        private void Bai9Button_Click(object sender, EventArgs e)
        {
            var form = new Lab01_Bai09();
            form.ShowDialog();
        }
    }
}
