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

namespace QuanLyTacGia
{
    public partial class QLTG : Form
    {

        string connectstring = @"Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();

        public QLTG()
        {
            InitializeComponent();
        }

        private void ThongKeButton_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                con.Open();
                cmd = new SqlCommand("SELECT * FROM TacGia", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dgvTacGia.DataSource = dt;
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
                string query = "SELECT * FROM TacGia";
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dgvTacGia.DataSource = dt;
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

        private void ClearFields()
        {
            MaTacGiaText.Clear();
            TenTacGiaText.Clear();
            GioiThieuText.Clear();
            DiaChiText.Clear();
            DienThoaiText.Clear();
            EmailText.Clear();
           
        }

        private void ThemButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO TacGia (MaTacGia, TenTacGia, GioiThieu, DiaChi, DienThoai, Email) " +
                               "VALUES (@MaTacGia, @TenTacGia, @GioiThieu, @DiaChi, @DienThoai, @Email)";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MaTacGia", MaTacGiaText.Text);
                cmd.Parameters.AddWithValue("@TenTacGia", TenTacGiaText.Text);
                cmd.Parameters.AddWithValue("@GioiThieu", GioiThieuText.Text);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChiText.Text);
                cmd.Parameters.AddWithValue("@DienThoai", int.Parse(DienThoaiText.Text));
                cmd.Parameters.AddWithValue("@Email", EmailText.Text);



                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Thêm tác giả thành công!");
                RefreshData();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tác giả: " + ex.Message);
                con.Close();
            }
        }

        private void XoaButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvTacGia.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvTacGia.SelectedRows[0];
                    con.Open();
                    string query = "DELETE FROM TacGia WHERE MaTacGia = @MaTacGia";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MaTacGia", selectedRow.Cells["MaTacGia"].Value);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Xóa tác giả thành công!");
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
                MessageBox.Show("Lỗi khi xóa tác giả: " + ex.Message);
                con.Close();
            }
        }

        private void SuaButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvTacGia.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvTacGia.SelectedRows[0];

                    con.Open();
                    string query = "UPDATE TacGia SET MaTacGia = @MaTacGia, TenTacGia = @TenTacGia, GioiThieu = @GioiThieu, DiaChi = @DiaChi, " +
                                   "DienThoai = @DienThoai, Email = @Email WHERE MaTacGia = @OriginalMaTacGia";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@OriginalMaTacGia", selectedRow.Cells["MaTacGia"].Value);
                    cmd.Parameters.AddWithValue("@MaTacGia", MaTacGiaText.Text);
                    cmd.Parameters.AddWithValue("@TenTacGia", TenTacGiaText.Text);
                    cmd.Parameters.AddWithValue("@GioiThieu", GioiThieuText.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChiText.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", int.Parse(DienThoaiText.Text));
                    cmd.Parameters.AddWithValue("@Email", EmailText.Text);


                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cập nhật tác giả thành công!");
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
                MessageBox.Show("Lỗi khi cập nhật tác giả: " + ex.Message);
                con.Close();
            }
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void QLTG_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}