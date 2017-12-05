using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyChiTieu
{
    public partial class FrmMain : Form
    {

        private int index = 0, index1 = 0;
        #region Hàm khởi tạo
        public FrmMain()
        {
            InitializeComponent();
            
        }
        #endregion  

        #region LoadForm

        private void LoadChart()
        {
            try
            {
                chartChiTieu.DataSource = Helper.LoaiCongViecs
                                          .Select(p => new
                                          {
                                              Name = p.Name,
                                              Value = Helper.ChiTieus.Where(z => z.LoaiChiTieu == (int) p.ID).Sum(z => z.SoTien)
                                          })
                                          .Where(p=>p.Value>0)
                                          .ToList();
                chartChiTieu.Series[0].XValueMember = "Name";
                chartChiTieu.Series[0].XValueType = ChartValueType.String;
                chartChiTieu.Series[0].YValueMembers = "Value";
                chartChiTieu.Series[0].YValueType = ChartValueType.Int32;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDgvChiTieu()
        {
            int i = 0;
            var listChiTieu = Helper.ChiTieus
                                    .Select(p => new
                                    {
                                        STT = ++i,
                                        LoaiChiTieu = TenLoai(p.LoaiChiTieu),
                                        SoTien = p.SoTien,
                                        NoiDung = p.NoiDung
                                    })
                                    .ToList();
            dgvChiTieu.DataSource = listChiTieu;

            /// Load Do Thi
            LoadChart();

            // LoadIndex
            try
            {
                index = index1;
                dgvChiTieu.Rows[index].Cells["STT"].Selected = true;
                dgvChiTieu.Select();
            }
            catch
            {

            }

            txtTongChiPhi.Text = listChiTieu.Sum(p => p.SoTien).ToString("N0");
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Helper.LoadDanhSach("db.txt");

            ClearControl();
            LoadDgvChiTieu();
            LockControl();
        }
        #endregion

        #region Close Form
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Helper.SaveDanhSach("db.txt");
        }
        #endregion

        #region sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnSua.Enabled = false;
                btnThem.Text = "Lưu";
                btnXoa.Text = "Hủy";

                ClearControl();
                UnlockControl();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {
                    btnThem.Text = "Thêm";
                    btnXoa.Text = "Xóa";
                    LockControl();

                    ChiTieu moi = getChiTieuByForm();
                    Helper.ChiTieus.Add(moi);


                    try
                    {

                        MessageBox.Show("Thêm thông tin chi tiêu thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin chi tiêu thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvChiTieu();
                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckLuaChon()) return;

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnXoa.Text = "Hủy";
                btnThem.Enabled = false;

                UnlockControl();

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";

                    LockControl();

                    ChiTieu cu = getChiTieuByID();
                    ChiTieu moi = getChiTieuByForm();
                    CapNhat(ref cu, moi);

                    try
                    {
                        MessageBox.Show("Sưa thông tin chi tiêu thành công",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin chi tiêu thất bại\n" + ex.Message,
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    LoadDgvChiTieu();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                if (!CheckLuaChon()) return;

                ChiTieu cu = getChiTieuByID();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin chi tiêu này không?",
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

                if (rs == DialogResult.Cancel) return;

                try
                {
                    Helper.ChiTieus.Remove(cu);
                    MessageBox.Show("Xóa thông tin chi tiêu thành công",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin chi tiêu thất bại\n" + ex.Message,
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                LoadDgvChiTieu();

                return;
            }
            if (btnXoa.Text == "Hủy")
            {
                btnSua.Text = "Sửa";
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";

                LockControl();
                UpdateDetail();
                return;
            }
        }
        #endregion

        #region Hàm chức năng
        private string TenLoai(int id)
        {
            if (id == 0) return "Ăn uống";
            if (id == 1) return "Di chuyển";
            if (id == 2) return "Nhà cửa";
            if (id == 3) return "Xe cộ";
            if (id == 4) return "Nhu yếu phẩm";
            if (id == 5) return "Dịch vụ";

            return "";
        }
        private bool Check()
        {
            try
            {
                int z = Int32.Parse(txtSoTien.Text);

            }
            catch
            {
                MessageBox.Show("Số tiền phải là số nguyên",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (txtNoiDung.Text == "")
            {
                MessageBox.Show("Nội dung chi tiêu không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LockControl()
        {
            dgvChiTieu.Enabled = true;
            cbxLoaiChiTieu.Enabled = false;
            txtSoTien.Enabled = false;
            txtNoiDung.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void UnlockControl()
        {
            dgvChiTieu.Enabled = false;
            cbxLoaiChiTieu.Enabled = true;
            txtSoTien.Enabled = true;
            txtNoiDung.Enabled = true;
        }

        private void ClearControl()
        {
            cbxLoaiChiTieu.SelectedIndex = 0;
            txtNoiDung.Text = "";
            txtSoTien.Text = "";
        }

        private void UpdateDetail()
        {
            ChiTieu z = getChiTieuByID();

            try
            {
                cbxLoaiChiTieu.SelectedIndex = z.LoaiChiTieu;
                txtSoTien.Text = z.SoTien.ToString();
                txtNoiDung.Text = z.NoiDung.ToString();

                index1 = index;
                index = dgvChiTieu.SelectedRows[0].Index;
            }
            catch
            {

            }

        }

        private ChiTieu getChiTieuByID()
        {
            try
            {
                int stt = (int) dgvChiTieu.SelectedRows[0].Cells["STT"].Value;
                stt--;

                if (stt >= Helper.ChiTieus.Count) return new ChiTieu();
                return Helper.ChiTieus[stt];
            }
            catch
            {
                return new ChiTieu();
            }
        }

        private ChiTieu getChiTieuByForm()
        {
            ChiTieu ans = new ChiTieu();
            ans.LoaiChiTieu = cbxLoaiChiTieu.SelectedIndex;
            ans.SoTien = Int32.Parse(txtSoTien.Text);
            ans.NoiDung = txtNoiDung.Text;

            return ans;
        }

        private bool CheckLuaChon()
        {
            ChiTieu k = getChiTieuByID();
            if (k.NoiDung == "" && k.SoTien == 0)
            {
                MessageBox.Show("Chưa có thông tin chi tiêu nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void CapNhat(ref ChiTieu cu, ChiTieu moi)
        {
            cu.LoaiChiTieu = moi.LoaiChiTieu;
            cu.SoTien = moi.SoTien;
            cu.NoiDung = moi.NoiDung;
        }
        #endregion

        #region Sự kiện ngầm
        private void dgvChiTieu_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetail();
        }
        #endregion

        
    }
}
