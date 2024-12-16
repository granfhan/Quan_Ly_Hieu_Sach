using Login1;
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
using System.Xml.Linq;

namespace QuanLyKhoSach
{
    public partial class QLS : Form
    {
        string connectstring = @"Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public QLS()
        {
            InitializeComponent();
        }

        private void ThongKeButton_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                con.Open();
                cmd = new SqlCommand("SELECT * FROM Sach", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dgvSach.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshData()
        {
            try
            {
                dt.Clear();
                con.Open();
                string query = "SELECT * FROM Sach";
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dgvSach.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại dữ liệu: " + ex.Message);
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Sach (MaSach, TenSach, TacGia, NhaXuatBan, NgayXuatBan, Gia, SoLuong) " +
                               "VALUES (@MaSach, @TenSach, @TacGia, @NhaXuatBan, @NgayXuatBan, @Gia, @SoLuong)";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MaSach", MaSachText.Text);
                cmd.Parameters.AddWithValue("@TenSach", TenSachText.Text);
                cmd.Parameters.AddWithValue("@TacGia", TacGiaText.Text);
                cmd.Parameters.AddWithValue("@NhaXuatBan", NXBText.Text);
                cmd.Parameters.AddWithValue("@NgayXuatBan", DateTime.Parse(NgayXBText.Text));
                cmd.Parameters.AddWithValue("@Gia", int.Parse(GiaBanText.Text));
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(SoLuongText.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Thêm sách thành công!");
                RefreshData();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message);
                con.Close();
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSach.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvSach.SelectedRows[0];
                    con.Open();
                    string query = "DELETE FROM Sach WHERE MaSach = @MaSach";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MaSach", selectedRow.Cells["MaSach"].Value);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Xóa sách thành công!");
                    RefreshData();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message);
                con.Close();
            }
        }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSach.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvSach.SelectedRows[0];

                    con.Open();
                    string query = "UPDATE Sach SET MaSach = @MaSach, TenSach = @TenSach, TacGia = @TacGia, NhaXuatBan = @NhaXuatBan, " +
                                   "NgayXuatBan = @NgayXuatBan, Gia = @Gia, SoLuong = @SoLuong WHERE MaSach = @OriginalMaSach";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@OriginalMaSach", selectedRow.Cells["MaSach"].Value);
                    cmd.Parameters.AddWithValue("@MaSach", MaSachText.Text);
                    cmd.Parameters.AddWithValue("@TenSach", TenSachText.Text);
                    cmd.Parameters.AddWithValue("@TacGia", TacGiaText.Text);
                    cmd.Parameters.AddWithValue("@NhaXuatBan", NXBText.Text);
                    cmd.Parameters.AddWithValue("@NgayXuatBan", DateTime.Parse(NgayXBText.Text));
                    cmd.Parameters.AddWithValue("@Gia", int.Parse(GiaBanText.Text));
                    cmd.Parameters.AddWithValue("@SoLuong", int.Parse(SoLuongText.Text));

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cập nhật sách thành công!");
                    RefreshData();

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sách: " + ex.Message);
                con.Close();
            }
        }

        private void ClearFields()
        {
            MaSachText.Clear();
            TenSachText.Clear();
            TacGiaText.Clear();
            NXBText.Clear();
            NgayXBText.Clear();
            GiaBanText.Clear();
            SoLuongText.Clear();
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void QLS_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
