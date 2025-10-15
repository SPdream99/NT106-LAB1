using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai09 : Form
    {
        List<string> monAn = new List<string>();
        public Lab01_Bai09()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monAn.Add("Phở");
            monAn.Add("Bún chả");
            monAn.Add("Gỏi cuốn");
            FoodMenu.Text = string.Join("\r\n", monAn);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
            FoodMenu.Clear();
            ResultBox.Clear();
            monAn.Clear();
            monAn.Add("Phở");
            monAn.Add("Bún chả");
            monAn.Add("Gỏi cuốn");
            FoodMenu.Text = string.Join("\r\n", monAn);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!monAn.Contains(InputBox.Text)) monAn.Add(InputBox.Text);
            else MessageBox.Show("Món ăn đã tồn tại!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FoodMenu.Text = string.Join("\r\n", monAn);
            InputBox.Focus();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = monAn[new Random().Next(0, monAn.Count)];
        }
    }
}
