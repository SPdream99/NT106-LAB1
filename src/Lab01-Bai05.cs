using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Lab01_Bai05 : Form
    {
        int dayGhe = 3;
        int soGhe = 5;
        int currentPhim = -1;
        double thanhTien = 0;
        CheckedListBox seatBox;
        enum loaiGhe
        {
            normal,
            vip,
            leftover
        }
        struct seat
        {
            public loaiGhe loai;
            public seat(loaiGhe l)
            {
                this.loai = l;
            }
        }
        List<List<seat>> seatList = new List<List<seat>>();

        struct phim
        {
            public string tenPhim;
            public List<int> phongPhim;
            public int giaCoBan;
        }

        List<phim> phimList = new List<phim>();

        private void updateTien(object sender, ItemCheckEventArgs e)
        {
            int gia = phimList[currentPhim].giaCoBan;
            double giaGhe = 0;
            switch (seatList[e.Index / soGhe][e.Index % soGhe].loai)
            {
                case loaiGhe.vip:
                    giaGhe = 2;
                    break;
                case loaiGhe.leftover:
                    giaGhe = 0.25;
                    break;
                default:
                    giaGhe = 1;
                    break;
            }
            if (e.NewValue == CheckState.Checked) {
                thanhTien += gia * giaGhe;
            }
            else
            {
                thanhTien -= gia * giaGhe;
            }
            textBox5.Text = thanhTien.ToString("C", new CultureInfo("vi-VN"));
        }

        void seatShow()
        {
            seatBox = new CheckedListBox();
            seatBox.ItemCheck += new ItemCheckEventHandler(updateTien);
            seatBox.Anchor = AnchorStyles.None;
            seatBox.Dock = DockStyle.Fill;
            groupBox2.Controls.Clear();
            groupBox2.Controls.Add(seatBox);
            for (int i = 0; i < seatList.Count; i++) 
            {
                for (int j = 0; j < seatList[i].Count; j++)
                {
                    seatBox.Items.Add($"{((char)(65+i))}{j+1}", false);
                }
            }
            groupBox2.Show();
        }

        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phimList.Add(new phim
            {
                tenPhim = "Đào, phở và piano",
                giaCoBan = 45000,
                phongPhim = new List<int> { 1, 2, 3 }
            });

            phimList.Add(new phim
            {
                tenPhim = "Mai",
                giaCoBan = 100000,
                phongPhim = new List<int> { 2, 3 }
            });

            phimList.Add(new phim
            {
                tenPhim = "Gặp lại chị bầu",
                giaCoBan = 70000,
                phongPhim = new List<int> { 1 }
            });

            phimList.Add(new phim
            {
                tenPhim = "Tarot",
                giaCoBan = 90000,
                phongPhim = new List<int> { 3 }
            });
            foreach (phim phim in phimList)
            {
                comboBox1.Items.Add(phim.tenPhim);
            }
            for (int i = 0; i < dayGhe; i++) {
                seatList.Add(new List<seat>());
                for (int j = 0; j < soGhe; j++) {
                    loaiGhe loai = loaiGhe.vip;
                    if (j == 0 || j == soGhe - 1) loai = loaiGhe.leftover;
                    else if (i == 0 || i == dayGhe - 1) loai = loaiGhe.normal;
                    seatList[i].Add(new seat(loai));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox5.Clear();
            textBox1.Clear();
            textBox2.Enabled = false;
            textBox2.Hide();
            comboBox1.SelectedIndex = -1;
            groupBox2.Enabled = false;
            comboBox2.Enabled = false;
            groupBox2.Hide();
            thanhTien = 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPhim = comboBox1.SelectedIndex;
            comboBox2.SelectedIndex = -1;
            comboBox2.Items.Clear();
            if (currentPhim < 0) return;
            foreach (int phong in phimList[currentPhim].phongPhim)
            {
                comboBox2.Items.Add(phong);
            }
            comboBox2.SelectedIndex = 0;
            comboBox2.Enabled = true;
            thanhTien = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentPhim < 0) return;
            textBox3.Text = phimList[currentPhim].giaCoBan.ToString("C", new CultureInfo("vi-VN"));
            seatShow();
            groupBox2.Enabled = true;
            textBox5.Text = 0.ToString("C", new CultureInfo("vi-VN"));
            thanhTien = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPhim < 0) throw new Exception("Vui lòng chọn phim!");
                if (textBox1.Text == "") throw new Exception("Vui lòng nhập tên khách");
                if (seatBox.CheckedItems.Count <= 0) throw new Exception("Vui lòng chọn ghế ngồi!");
                string hoaDon = $"--Hóa đơn--\r\nHọ tên người mua: {textBox1.Text}\r\nTên phim: {phimList[currentPhim].tenPhim}" +
                    $"\r\nPhòng chiếu số {comboBox2.SelectedItem}\r\nVé đã chọn:";
                foreach (string ve in seatBox.CheckedItems)
                {
                    hoaDon += ve + " ";
                }
                hoaDon += $"\r\nTổng tiền: {textBox5.Text}";
                textBox2.Text = hoaDon;
                textBox2.Enabled = true;
                textBox2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
