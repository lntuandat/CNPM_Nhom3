using QLNS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLNS.Login
{
    public partial class NhanVien : Form
    {

        SqlConnection connection;
        public NhanVien()
        {
            InitializeComponent();
            connection = new SqlConnection(KetNoi.kn);
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            string userName = SessionManager.Username;
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Không tìm thấy UserID trong session.");
                return;
            }

            string query = @"SELECT DISTINCT
                        N.MaNV, N.HoTenNV, N.NgaySinh, N.GioiTinh, N.DiaChi, N.CCCD, 
                        N.SoDienThoai, N.Email, N.HocVan, N.ChungChiNN, 
                        L.TenLoai, N.NgayVaoLam, B.SoBHXH, H.MaHD, 
                        H.NgayBatDau, H.NgayKetThuc
                    FROM 
                        NhanVien N
                    LEFT JOIN 
                        MaLoaiNV L ON N.MaLoai = L.MaLoai
                    LEFT JOIN 
                        BaoHiemXaHoi B ON N.MaNV = B.MaNV
                    LEFT JOIN 
                        HopDongNhanVien H ON N.MaNV = H.MaNV
                    WHERE 
                        N.MaNV = @MaNV";

            using (SqlConnection conn = new SqlConnection(KetNoi.kn))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", userName);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txt_MaNV.Text = reader["MaNV"]?.ToString() ?? string.Empty;
                        txt_HoTen.Text = reader["HoTenNV"]?.ToString() ?? string.Empty;
                        txt_NgaySinh.Text = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy") : string.Empty;
                        txt_GioiTinh.Text = reader["GioiTinh"]?.ToString() ?? string.Empty;
                        txt_DiaChi.Text = reader["DiaChi"]?.ToString() ?? string.Empty;
                        txt_CCCD.Text = reader["CCCD"]?.ToString() ?? string.Empty;
                        txt_SoDienThoai.Text = reader["SoDienThoai"]?.ToString() ?? string.Empty;
                        txt_Email.Text = reader["Email"]?.ToString() ?? string.Empty;
                        txt_TDHocVan.Text = reader["HocVan"]?.ToString() ?? string.Empty;
                        txt_CCNN.Text = reader["ChungChiNN"]?.ToString() ?? string.Empty;
                        txt_LoaiNV.Text = reader["TenLoai"]?.ToString() ?? string.Empty;
                        txt_NgayVaoLam.Text = reader["NgayVaoLam"] != DBNull.Value ? Convert.ToDateTime(reader["NgayVaoLam"]).ToString("dd/MM/yyyy") : string.Empty;
                        txt_SoBHXH.Text = reader["SoBHXH"]?.ToString() ?? string.Empty;
                        txt_MaHD.Text = reader["MaHD"]?.ToString() ?? string.Empty;
                        txt_BatDauHD.Text = reader["NgayBatDau"] != DBNull.Value ? Convert.ToDateTime(reader["NgayBatDau"]).ToString("dd/MM/yyyy") : string.Empty;
                        txt_KetThucHD.Text = reader["NgayKetThuc"] != DBNull.Value ? Convert.ToDateTime(reader["NgayKetThuc"]).ToString("dd/MM/yyyy") : string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu cho nhân viên.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.UserID = null;
            SessionManager.Username = null;
            SessionManager.UserRole = null;
        }

        private void btn_ChamCong_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn đăng xuất không?",
            "Xác nhận đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Bạn đã đăng xuất thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                formDangNhap frmDangNhap = new formDangNhap();
                frmDangNhap.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã hủy thao tác đăng xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
