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

namespace QuanLyThanhVien
{
    public partial class QLTV : Form
    {
        string connectstring = @"Data Source=DESKTOP-075MA7I;Initial Catalog=QLTV;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        public QLTV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectstring);
        }

        private void ThongKeButton_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                con.Open();
                cmd = new SqlCommand("SELECT * FROM ThanhVien", con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dgvThanhVien.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO ThanhVien (MaThanhVien, TenThanhVien, DienThoai, Email) " +
                               "VALUES (@MaThanhVien, @TenThanhVien, @DienThoai, @Email)";
                cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MaThanhVien", MaThanhVienText.Text);
                cmd.Parameters.AddWithValue("@TenThanhVien", TenThanhVienText.Text);
                cmd.Parameters.AddWithValue("@DienThoai", int.Parse(DienThoaiText.Text));
                cmd.Parameters.AddWithValue("@Email", EmailText.Text);


                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Thêm thành viên thành công!");
                RefreshData();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thành viên: " + ex.Message);
                con.Close();
            }
        }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThanhVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvThanhVien.SelectedRows[0];

                    con.Open();
                    string query = "UPDATE ThanhVien SET MaThanhVien = @MaThanhVien, TenThanhVien = @TenThanhVien, " +
                                   "DienThoai = @DienThoai, Email = @Email WHERE MaThanhVien = @OriginalMaThanhVien";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@OriginalMaThanhVien", selectedRow.Cells["MaThanhVien"].Value);
                    cmd.Parameters.AddWithValue("@MaThanhVien", MaThanhVienText.Text);
                    cmd.Parameters.AddWithValue("@TenThanhVien", TenThanhVienText.Text);
                    cmd.Parameters.AddWithValue("@DienThoai", int.Parse(DienThoaiText.Text));
                    cmd.Parameters.AddWithValue("@Email", EmailText.Text);          
                    

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cập nhật thành viên thành công!");
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
                MessageBox.Show("Lỗi khi cập nhật thành viên: " + ex.Message);
                con.Close();
            }

        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThanhVien.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvThanhVien.SelectedRows[0];
                    con.Open();
                    string query = "DELETE FROM ThanhVien WHERE MaThanhVien = @MaThanhVien";
                    cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MaThanhVien", selectedRow.Cells["MaThanhVien"].Value);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Xóa thành viên thành công!");
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
                MessageBox.Show("Lỗi khi xóa thành viên: " + ex.Message);
                con.Close();
            }

        }

        

        private void RefreshData()
        {
            try
            {
                dt.Clear();
                con.Open();
                string query = "SELECT * FROM ThanhVien";
                cmd = new SqlCommand(query, con);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dgvThanhVien.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lại dữ liệu: " + ex.Message);
                con.Close();
            }
        }

        private void ClearFields()
        {
            MaThanhVienText.Clear();
            TenThanhVienText.Clear();
            DienThoaiText.Clear();
            EmailText.Clear();           
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void QLTV_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
