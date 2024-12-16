using Login1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{

    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (dgvKhoSach.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvKhoSach.SelectedRows)
                {
                    string tenSach = row.Cells["TenSach"].Value.ToString();
                    string tacGia = row.Cells["TacGia"].Value.ToString();
                    int gia = Convert.ToInt32(row.Cells["Gia"].Value);
                    int soLuong = 1;
                    int thanhTien = soLuong * gia;

                    bool sachDaTonTai = false;

                    foreach (DataGridViewRow existingRow in dgvDanhSachSach.Rows)
                    {
                        if (existingRow.Cells["TenSach"].Value != null && existingRow.Cells["TenSach"].Value.ToString() == tenSach)
                        {
                        
                            int currentQuantity = Convert.ToInt32(existingRow.Cells["SoLuong"].Value);
                            existingRow.Cells["SoLuong"].Value = currentQuantity + soLuong;
                            existingRow.Cells["ThanhTien"].Value = (currentQuantity + soLuong) * gia;
                            sachDaTonTai = true;
                            break;
                        }
                    }

          
                    if (!sachDaTonTai)
                    {
                        dgvDanhSachSach.Rows.Add(tenSach, soLuong, gia, thanhTien);
                    }
                }

                UpdateTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void UpdateTongTien()
        {
            int tongTien = 0;

            foreach (DataGridViewRow row in dgvDanhSachSach.Rows)
            {
                tongTien += Convert.ToInt32(row.Cells["ThanhTien"].Value);
            }

            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString();
            label3.Text = $"Ngày Lập: {DateTime.Now}";
        }
        private void LoadKhoSachFromDatabase()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Sach";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    MessageBox.Show($"Số lượng sách: {dt.Rows.Count}");

                    dgvKhoSach.DataSource = dt;
                    dgvKhoSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKhoSachFromDatabase();
            dgvDanhSachSach.CellValueChanged += dgvDanhSachSach_CellValueChanged;
        }

        private void dgvDanhSachSach_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDanhSachSach.Columns["SoLuong"].Index)
            {
                var row = dgvDanhSachSach.Rows[e.RowIndex];
                int gia = Convert.ToInt32(row.Cells["Gia"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                row.Cells["ThanhTien"].Value = gia * soLuong;

                UpdateTongTien();
            }
        }

        private void dgvDanhSachSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhSachSach.Columns.Add("MaSach", "Mã sách");
            dgvDanhSachSach.Columns.Add("TenSach", "Tên sách");
            dgvDanhSachSach.Columns.Add("SoLuong", "Số lượng");
            dgvDanhSachSach.Columns.Add("DonGia", "Đơn giá");
            dgvDanhSachSach.Columns.Add("ThanhTien", "Thành tiền");

            dgvDanhSachSach.Columns["ThanhTien"].ReadOnly = true;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSach.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDanhSachSach.SelectedRows)
                {
                    dgvDanhSachSach.Rows.Remove(row);
                }

                UpdateTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHoaDon.Text) || string.IsNullOrWhiteSpace(txtMaThanhVien.Text) || string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maHoaDon = txtMaHoaDon.Text.Trim();
                string maThanhVien = txtMaThanhVien.Text.Trim();
                string maNhanVien = txtMaNhanVien.Text.Trim();
                decimal tongTien = CalculateTotalAmount();
                DateTime ngayLap = DateTime.Now;

                string connectionString = @"Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Thêm hóa đơn vào bảng HoaDon
                    string insertHoaDonQuery = "INSERT INTO HoaDon (MaHoaDon, MaThanhVien, MaNhanVien, TongTien, NgayLap) " +
                                               "VALUES (@MaHoaDon, @MaThanhVien, @MaNhanVien, @TongTien, @NgayLap)";
                    using (SqlCommand cmdHoaDon = new SqlCommand(insertHoaDonQuery, connection))
                    {
                        cmdHoaDon.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                        cmdHoaDon.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
                        cmdHoaDon.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        cmdHoaDon.Parameters.AddWithValue("@TongTien", tongTien);
                        cmdHoaDon.Parameters.AddWithValue("@NgayLap", ngayLap);
                        cmdHoaDon.ExecuteNonQuery();
                    }

                    // Xử lý từng sách trong danh sách
                    foreach (DataGridViewRow row in dgvDanhSachSach.Rows)
                    {
                        if (row.Cells["TenSach"].Value != null)
                        {
                            string tenSach = row.Cells["TenSach"].Value.ToString();
                            int soLuongMua = Convert.ToInt32(row.Cells["SoLuong"].Value);
                            decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                            decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);

                            // Kiểm tra số lượng tồn kho trước khi thanh toán
                            string checkStockQuery = "SELECT SoLuong FROM Sach WHERE TenSach = @TenSach";
                            int soLuongTonKho = 0;

                            using (SqlCommand cmdCheckStock = new SqlCommand(checkStockQuery, connection))
                            {
                                cmdCheckStock.Parameters.AddWithValue("@TenSach", tenSach);
                                var result = cmdCheckStock.ExecuteScalar();
                                if (result != null)
                                {
                                    soLuongTonKho = Convert.ToInt32(result);
                                }
                            }

                            if (soLuongTonKho < soLuongMua)
                            {
                                MessageBox.Show($"Sách '{tenSach}' không đủ số lượng trong kho. Số lượng còn: {soLuongTonKho}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Thêm chi tiết hóa đơn vào CTHoaDon
                            string insertChiTietQuery = "INSERT INTO CTHoaDon (MaHoaDon, TenSach, SoLuong, DonGia, ThanhTien) " +
                                                        "VALUES (@MaHoaDon, @TenSach, @SoLuong, @DonGia, @ThanhTien)";
                            using (SqlCommand cmdCTHoaDon = new SqlCommand(insertChiTietQuery, connection))
                            {
                                cmdCTHoaDon.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                                cmdCTHoaDon.Parameters.AddWithValue("@TenSach", tenSach);
                                cmdCTHoaDon.Parameters.AddWithValue("@SoLuong", soLuongMua);
                                cmdCTHoaDon.Parameters.AddWithValue("@DonGia", donGia);
                                cmdCTHoaDon.Parameters.AddWithValue("@ThanhTien", thanhTien);
                                cmdCTHoaDon.ExecuteNonQuery();
                            }

                            // Cập nhật số lượng tồn kho
                            string updateStockQuery = "UPDATE Sach SET SoLuong = SoLuong - @SoLuongMua WHERE TenSach = @TenSach";
                            using (SqlCommand cmdUpdateStock = new SqlCommand(updateStockQuery, connection))
                            {
                                cmdUpdateStock.Parameters.AddWithValue("@SoLuongMua", soLuongMua);
                                cmdUpdateStock.Parameters.AddWithValue("@TenSach", tenSach);
                                cmdUpdateStock.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show($"Thanh toán thành công! Mã hóa đơn: {maHoaDon}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu trên giao diện
                    dgvDanhSachSach.Rows.Clear();
                    txtMaHoaDon.Clear();
                    txtMaThanhVien.Clear();
                    txtMaNhanVien.Clear();
                    lblTongTien.Text = "Tổng tiền: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateTotalAmount()
        {
    decimal totalAmount = 0;
    foreach (DataGridViewRow row in dgvDanhSachSach.Rows)
    {
        if (row.Cells["ThanhTien"].Value != null)
        {
            totalAmount += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
        }
    }
    return totalAmount;
}

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhoSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable khoSachTable = new DataTable();
            khoSachTable.Columns.Add("MaSach", typeof(string));
            khoSachTable.Columns.Add("TenSach", typeof(string));
            khoSachTable.Columns.Add("TacGia", typeof(string));
            khoSachTable.Columns.Add("NhaXuatBan", typeof(string));
            khoSachTable.Columns.Add("NgayXuatBan", typeof(DateTime));
            khoSachTable.Columns.Add("Gia", typeof(int));

            khoSachTable.Rows.Add("S01", "Định Mệnh", "Vũ Đức Huy", "HDC", DateTime.Parse("2004-10-22"), 10);
            khoSachTable.Rows.Add("S02", "Mắt Đen", "Vũ Kim Phúc Dương", "ABC", DateTime.Parse("2010-02-20"), 200);
            khoSachTable.Rows.Add("S03", "Địa Đàng", "Nguyễn Thành Vinh", "HDC", DateTime.Parse("2024-01-11"), 100);
            khoSachTable.Rows.Add("S04", "Núi", "Nguyễn Thị Mai", "ABC", DateTime.Parse("2022-10-10"), 350);
            khoSachTable.Rows.Add("S05", "Biển", "Nguyễn Thị Mai", "ABC", DateTime.Parse("2024-10-10"), 400);
            khoSachTable.Rows.Add("S06", "Mất", "Vũ Đức Huy", "HDC", DateTime.Parse("2000-10-10"), 20);
            khoSachTable.Rows.Add("S07", "Đôi Mắt", "Vũ Kim Phúc Dương", "ABC", DateTime.Parse("2010-10-10"), 22);
            khoSachTable.Rows.Add("S08", "Chiến Thắng", "Hoàng Đức Chiến", "BCD", DateTime.Parse("2004-10-22"), 500);
            khoSachTable.Rows.Add("S09", "Đạt Được", "Minh Hoàng Vũ", "HDC", DateTime.Parse("2002-12-01"), 100);
            khoSachTable.Rows.Add("S10", "Mai", "Nguyễn Thành Vinh", "HDC", DateTime.Parse("2023-10-10"), 100);

            dgvKhoSach.DataSource = khoSachTable;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadKhoSachFromDatabase();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void ThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
    }

    public class DatabaseHelper
    {
        private string connectionString = @"Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
        