using baitap;
using QuanLyKhoSach;
using QuanLyNhanVien;
using QuanLyTacGia;
using QuanLyThanhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLHD qLHD = new QLHD();
            qLHD.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TK tK = new TK();
            tK.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QLTV qLTV = new QLTV();
            qLTV.Show();   
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QLTG qLTG = new QLTG();
            qLTG.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QLS qLS = new QLS();
            qLS.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QLNV qLNV = new QLNV();
            qLNV.Show();
            this.Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
