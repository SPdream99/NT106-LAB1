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
            CostBox.Text = thanhTien.ToString("C", new CultureInfo("vi-VN"));
        }

        void seatShow()
        {
            seatBox = new CheckedListBox();
            seatBox.ItemCheck += new ItemCheckEventHandler(updateTien);
            seatBox.Anchor = AnchorStyles.None;
            seatBox.Dock = DockStyle.Fill;
            SeatPicker.Controls.Clear();
            SeatPicker.Controls.Add(seatBox);
            for (int i = 0; i < seatList.Count; i++) 
            {
                for (int j = 0; j < seatList[i].Count; j++)
                {
                    seatBox.Items.Add($"{((char)(65+i))}{j+1}", false);
                }
            }
            SeatPicker.Show();
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
                MovieMenu.Items.Add(phim.tenPhim);
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            BasicCostBox.Clear();
            CostBox.Clear();
            CustomerNameBox.Clear();
            BillBox.Enabled = false;
            BillBox.Hide();
            MovieMenu.SelectedIndex = -1;
            SeatPicker.Enabled = false;
            RoomMenu.Enabled = false;
            SeatPicker.Hide();
            thanhTien = 0;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MovieMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPhim = MovieMenu.SelectedIndex;
            RoomMenu.SelectedIndex = -1;
            RoomMenu.Items.Clear();
            if (currentPhim < 0) return;
            foreach (int phong in phimList[currentPhim].phongPhim)
            {
                RoomMenu.Items.Add(phong);
            }
            RoomMenu.SelectedIndex = 0;
            RoomMenu.Enabled = true;
            thanhTien = 0;
        }

        private void RoomMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentPhim < 0) return;
            BasicCostBox.Text = phimList[currentPhim].giaCoBan.ToString("C", new CultureInfo("vi-VN"));
            seatShow();
            SeatPicker.Enabled = true;
            CostBox.Text = 0.ToString("C", new CultureInfo("vi-VN"));
            thanhTien = 0;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentPhim < 0) throw new Exception("Vui lòng chọn phim!");
                if (CustomerNameBox.Text == "") throw new Exception("Vui lòng nhập tên khách");
                if (seatBox.CheckedItems.Count <= 0) throw new Exception("Vui lòng chọn ghế ngồi!");
                string hoaDon = $"--Hóa đơn--\r\nHọ tên người mua: {CustomerNameBox.Text}\r\nTên phim: {phimList[currentPhim].tenPhim}" +
                    $"\r\nPhòng chiếu số {RoomMenu.SelectedItem}\r\nVé đã chọn:";
                foreach (string ve in seatBox.CheckedItems)
                {
                    hoaDon += ve + " ";
                }
                hoaDon += $"\r\nTổng tiền: {CostBox.Text}";
                BillBox.Text = hoaDon;
                BillBox.Enabled = true;
                BillBox.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
