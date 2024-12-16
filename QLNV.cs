using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using Login1;

namespace QuanLyNhanVien
{
    public partial class QLNV : Form
    {
        string connectstring = @"Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public QLNV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet4.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLTVDataSet4.NhanVien);
            con = new SqlConnection(connectstring);
        }

        private void ThongKeButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * From NhanVien", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dgvNhanVien.DataSource = dt;
                con.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshData()
        {
            try
            {
                dt.Clear();
                con.Open();
                string query = "SELECT * FROM NhanVien";
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dgvNhanVien.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại dữ liệu: " + ex.Message);
                con.Close();
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, ChucVu, DiaChi, DienThoai, Email) " +
                               "VALUES (@MaNhanVien, @TenNhanVien, @ChucVu, @DiaChi, @DienThoai, @Email)";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVienText.Text);
                cmd.Parameters.AddWithValue("@TenNhanVien", TenNhanVienText.Text);
                cmd.Parameters.AddWithValue("@ChucVu", ChucVuText.Text);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChiText.Text);                
                cmd.Parameters.AddWithValue("@DienThoai", int.Parse(DienThoaiText.Text));
                cmd.Parameters.AddWithValue("@Email", EmailText.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Thêm nhân viên thành công!");
                RefreshData();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
                con.Close();
            }
        }


        private void ClearFields()
        {
            MaNhanVienText.Clear();
            TenNhanVienText.Clear();
            ChucVuText.Clear();
            DiaChiText.Clear();
            DienThoaiText.Clear();
            EmailText.Clear();
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];
                    con.Open();
                    string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MaNhanVien", selectedRow.Cells["MaNhanVien"].Value);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Xóa nhân viên thành công!");
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
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                con.Close();
            }
        }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvNhanVien.SelectedRows[0];

                    con.Open();
                    string query = "UPDATE NhanVien SET MaNhanVien = @MaNhanVien, TenNhanVien = @TenNhanVien, ChucVu = @ChucVu, DiaChi = @DiaChi, " +
                                   "DienThoai = @DienThoai, Email = @Email WHERE MaNhanVien = @OriginalMaNhanVien";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@OriginalMaNhanVien", selectedRow.Cells["MaNhanVien"].Value);
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVienText.Text);
                    cmd.Parameters.AddWithValue("@TenNhanVien", TenNhanVienText.Text);
                    cmd.Parameters.AddWithValue("@ChucVu", ChucVuText.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChiText.Text);                
                    cmd.Parameters.AddWithValue("@DienThoai", int.Parse(DienThoaiText.Text));
                    cmd.Parameters.AddWithValue("@Email", EmailText.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cập nhật nhân viên thành công!");
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
                MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message);
                con.Close();
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void QLNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
