using QLNS.Helper;
using QLNS.TinhLuong.ChildForm;
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

namespace QLNS.ChamCongg
{
    public partial class ThemCongNV : Form
    {
        QLNhanSu_CNPMEntities1 db = new QLNhanSu_CNPMEntities1();
        public ThemCongNV()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string maNV = txt_mnv.Text.Trim();

            // Kiểm tra mã nhân viên hợp lệ bằng SQL
            var checkMaNVQuery = "SELECT COUNT(1) FROM NhanVien WHERE MaNV = @MaNV";
            var result = db.Database.SqlQuery<int>(checkMaNVQuery, new SqlParameter("@MaNV", maNV)).FirstOrDefault();

            if (result == 0)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin từ giao diện
            DateTime ngayChamCong;
            TimeSpan gioVaoLam = TimeSpan.Parse(masktxt_gvl.Text);
            TimeSpan gioTanLam = TimeSpan.Parse(masktxt_gtl.Text);

            // Kiểm tra dữ liệu nhập vào
            if (!DateTime.TryParse(dtP_ncc.Text, out ngayChamCong) ||
                !TimeSpan.TryParse(masktxt_gvl.Text, out gioVaoLam) ||
                !TimeSpan.TryParse(masktxt_gtl.Text, out gioTanLam))
            {
                MessageBox.Show("Dữ liệu không hợp lệ! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra giá trị GioVaoLam hợp lệ theo ràng buộc CHECK (ví dụ, phải là một thời gian hợp lệ)
            if (gioVaoLam < TimeSpan.FromHours(0) || gioVaoLam >= TimeSpan.FromHours(24))
            {
                MessageBox.Show("Giờ vào làm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Insert dữ liệu vào bảng ChamConggg
            string insertQuery = @"
        INSERT INTO ChamCong (MaNV, NgayCC, GioVaoLam, GioTanLam)
        VALUES (@MaNV, @NgayCC, @GioVaoLam, @GioTanLam)";

            // Thực thi câu lệnh SQL
            db.Database.ExecuteSqlCommand(insertQuery,
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@NgayCC", ngayChamCong),
                new SqlParameter("@GioVaoLam", gioVaoLam.ToString()),
                new SqlParameter("@GioTanLam", gioTanLam.ToString())
            );

            MessageBox.Show("Lưu thông tin chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa các trường nhập liệu
            txt_mnv.Clear();
            masktxt_gvl.Clear();
            masktxt_gtl.Clear();
        }

        private void txt_mnv_TextChanged(object sender, EventArgs e)
        {
            string maNV = txt_mnv.Text.Trim();

            // Chuỗi kết nối đến cơ sở dữ liệu
            

            // Câu truy vấn SQL
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";

            using (SqlConnection conn = new SqlConnection(KetNoi.kn))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm tham số vào truy vấn
                        cmd.Parameters.AddWithValue("@MaNV", maNV);

                        // Thực thi truy vấn và kiểm tra kết quả
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            txt_mnv.ForeColor = Color.Blue;
                        }
                        else
                        {
                            txt_mnv.ForeColor = Color.Red;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
