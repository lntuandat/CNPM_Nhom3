using QLNS.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLNS.Login
{
    public partial class TaiKhoan : Form
    {
        SqlConnection connection;

        public TaiKhoan()
        {
            InitializeComponent();
            connection = new SqlConnection(KetNoi.kn); // Kết nối với cơ sở dữ liệu
        }

        // Hàm LoadData để lấy dữ liệu từ cơ sở dữ liệu và hiển thị lên DataGridView
        private void LoadData()
        {
            try
            {
                string query = "SELECT UserID, Username, Pass, UserRole FROM dbo.TaiKhoan"; // Truy vấn lấy tất cả các cột cần thiết

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); // Điền dữ liệu vào DataTable

                dgv_TK.DataSource = dataTable; // Gán DataTable vào DataGridView

                // Đảm bảo các cột tự động điều chỉnh kích thước vừa khung
                dgv_TK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgv_TK.Rows.Count > 0)
                {
                    dgv_TK.Rows[0].Selected = true; // Chọn dòng đầu tiên
                    dgv_TK.CurrentCell = dgv_TK.Rows[0].Cells[0]; // Đặt ô đầu tiên là ô hiện tại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Sự kiện khi người dùng chọn một dòng trong DataGridView
        private void dgv_TK_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgv_TK.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_TK.SelectedRows[0];

                // Lấy giá trị từ các cột và hiển thị lên TextBox
                txt_MaTK.Text = selectedRow.Cells["UserID"].Value.ToString();
                txt_TenTK.Text = selectedRow.Cells["Username"].Value.ToString();
                txtQuyen.Text = selectedRow.Cells["UserRole"].Value.ToString();
                txtPassWord.Text = selectedRow.Cells["Pass"].Value.ToString();
            }
        }

        // Sự kiện khi người dùng nhấp chuột vào ô trong DataGridView
        private void dgv_TK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ mục dòng
            {

                DataGridViewRow selectedRow = dgv_TK.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong cột và gán vào các TextBox
                txt_MaTK.Text = selectedRow.Cells["UserID"].Value.ToString();
                txt_TenTK.Text = selectedRow.Cells["Username"].Value.ToString();
                txtQuyen.Text = selectedRow.Cells["UserRole"].Value.ToString();
                txtPassWord.Text = selectedRow.Cells["Pass"].Value.ToString();
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox
                string userID = txt_MaTK.Text.Trim();
                string username = txt_TenTK.Text.Trim();
                string password = txtPassWord.Text.Trim();
                string userRole = txtQuyen.Text.Trim();

                // Kiểm tra các trường dữ liệu không được để trống
                if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userRole))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giá trị của txtQuyen, chỉ cho phép "NhanVien" hoặc "Admin"
                if (userRole != "NhanVien" && userRole != "Admin")
                {
                    MessageBox.Show("Vui lòng nhập quyền hợp lệ: 'NhanVien' hoặc 'Admin'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Câu lệnh SQL để thêm tài khoản mới vào cơ sở dữ liệu
                string query = "INSERT INTO dbo.TaiKhoan (UserID, Username, Pass, UserRole) VALUES (@UserID, @Username, @Pass, @UserRole)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Pass", password);
                    cmd.Parameters.AddWithValue("@UserRole", userRole);

                    // Mở kết nối và thực thi câu lệnh SQL
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Tài khoản đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Tải lại dữ liệu vào DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm tài khoản. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Sự kiện khi Form được tải

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox
                string userID = txt_MaTK.Text.Trim();
                string username = txt_TenTK.Text.Trim();
                string password = txtPassWord.Text.Trim();
                string userRole = txtQuyen.Text.Trim();

                // Kiểm tra các trường dữ liệu không được để trống
                if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userRole))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giá trị của txtQuyen, chỉ cho phép "NhanVien" hoặc "Admin"
                if (userRole != "NhanVien" && userRole != "Admin")
                {
                    MessageBox.Show("Vui lòng nhập quyền hợp lệ: 'NhanVien' hoặc 'Admin'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Câu lệnh SQL để cập nhật tài khoản
                string query = "UPDATE dbo.TaiKhoan SET Username = @Username, Pass = @Pass, UserRole = @UserRole WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Pass", password);
                    cmd.Parameters.AddWithValue("@UserRole", userRole);

                    // Mở kết nối và thực thi câu lệnh SQL
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Tài khoản đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Tải lại dữ liệu vào DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật tài khoản. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy UserID từ TextBox
                string userID = txt_MaTK.Text.Trim();

                // Kiểm tra UserID không được để trống
                if (string.IsNullOrEmpty(userID))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hộp thoại xác nhận xóa
                DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản với mã {userID} không?",
                                                       "Xác nhận xóa",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Câu lệnh SQL để xóa tài khoản
                    string query = "DELETE FROM dbo.TaiKhoan WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho câu lệnh SQL
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        // Mở kết nối và thực thi câu lệnh SQL
                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Tài khoản đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Tải lại dữ liệu vào DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa tài khoản. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
