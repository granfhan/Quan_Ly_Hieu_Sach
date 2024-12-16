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
    public partial class TK : Form
    {
        private string connectionString = "Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
        public TK()
        {
            InitializeComponent();
        }

        private void TK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet2.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.qLTVDataSet2.HoaDon);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Truy vấn để lấy tất cả hóa đơn và tổng tiền
                    string query = "SELECT MaHoaDon, MaThanhVien, MaNhanVien, TongTien, NgayLap FROM HoaDon";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Hiển thị dữ liệu lên DataGridView
                        dataGridViewTK.DataSource = dt;

                        // Tính tổng doanh thu từ cột TongTien
                        decimal tongDoanhThu = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            tongDoanhThu += Convert.ToDecimal(row["TongTien"]);
                        }

                        // Hiển thị tổng doanh thu
                        labelTK2.Text = $" {tongDoanhThu:N0} 000 VNĐ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập Mã Hóa Đơn để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Truy vấn SQL tìm kiếm theo Mã Hóa Đơn
                    string query = "SELECT MaHoaDon, MaThanhVien, MaNhanVien, TongTien, NgayLap FROM HoaDon WHERE MaHoaDon = @MaHoaDon";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Hiển thị kết quả tìm kiếm lên DataGridView
                            if (dt.Rows.Count > 0)
                            {
                                dataGridViewTK.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy hóa đơn!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridViewTK.DataSource = null; // Xóa dữ liệu cũ
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void dataGridViewTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TK_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
    }
    

