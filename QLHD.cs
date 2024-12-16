using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1
{
    public partial class QLHD : Form
    {
        public QLHD()
        {
            InitializeComponent();
        }

        private void QLHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet1.CTHoaDon' table. You can move, or remove it, as needed.
            this.cTHoaDonTableAdapter.Fill(this.qLTVDataSet1.CTHoaDon);
            // TODO: This line of code loads data into the 'qLTVDataSet.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qLTVDataSet.HoaDon);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ các cột vào TextBox
                textMHD.Text = row.Cells[0].Value?.ToString();
                textMTV.Text = row.Cells[1].Value?.ToString();
                textMNV.Text = row.Cells[2].Value?.ToString();
                textTT.Text = row.Cells[3].Value?.ToString();
                textNL.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
            Main mainForm = new Main();
            mainForm.Show();
        }

        private void Rf_Click(object sender, EventArgs e)
        {
            textMHD.Text = "";
            textMTV.Text = "";
            textMNV.Text = "";
            textTT.Text = "";
            textNL.Text = "";
            if (dataGridView2.DataSource != null)
            {
                
                DataTable dt = (DataTable)dataGridView2.DataSource;
                dt.Clear();
            }
            else
            {
                
                dataGridView2.Rows.Clear();
            }
            MessageBox.Show("Đã làm mới dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteHoaDon(textMHD.Text);

                LoadHoaDon();

                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DeleteHoaDon(string maHoaDon)
        {
            string connectionString = "Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
            string query = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void LoadHoaDon()
        {
            
            string connectionString = "Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
            string query = "SELECT * FROM HoaDon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void LoadChiTietHoaDon(string maHoaDon)
        {
            // Giả sử bạn dùng DataTable để tải chi tiết hóa đơn từ cơ sở dữ liệu
            string connectionString = "Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
            string query = "SELECT * FROM CTHoaDon WHERE MaHoaDon = @MaHoaDon";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt; // Hiển thị chi tiết hóa đơn ở bảng dưới
            }
        }

        private void CTHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMHD.Text))
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị dữ liệu chi tiết hóa đơn trong DataGridView phía dưới
            LoadChiTietHoaDon(textMHD.Text);
        }

        private void QLHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
