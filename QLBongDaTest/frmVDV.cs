using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBongDaTest.db;
using System.IO;
using QLBongDaTest.Properties;

namespace QLBongDaTest
{
    public partial class frmVDV : Form
    {
        readonly DatabaseConnect db;
        DataTable dataTableVDV;
        int selectedIndex = -1;
        string picVDVpath = Application.StartupPath;
        bool isCreateNew;
        string MaSoCu = "";
        string TenHinh = "";
        string TenTapTin = "";
        string HinhMoi = "";
        string HinhXoa = "";
        public frmVDV()
        {
            dataTableVDV = new DataTable();
            db = new DatabaseConnect();
            InitializeComponent();
        }

        private void CanInputData(bool state)
        {
            txtMaVDV.ReadOnly = !state;
            txtHoTenVDV.ReadOnly = !state;
            dpkNgaySinh.Enabled = state;
            cboDoi.Enabled = state;
            cboViTri.Enabled = state;
            cboGioiTinh.Enabled = state;
            grpHinh.Enabled = state;
            grpLuu.Enabled = state;
            dgrVDV.Enabled = !state;
            grpDuyet.Enabled = !state;
            grpTSX.Enabled = !state;
        }

        private void frmVDV_Load(object sender, EventArgs e)
        {
            if (!db.Connect())
            {
                Close();
                return;
            }
            picVDVpath = picVDVpath.Substring(0,
            picVDVpath.LastIndexOf("Bin", StringComparison.OrdinalIgnoreCase)) + @"\resources\";
            cboDoi.DataSource = db.GetTableData("DOI", "", "TenDoi");
            cboDoi.DisplayMember = "TenDoi";
            cboDoi.ValueMember = "MaDoi";
            cboViTri.SelectedIndex = 0;
            cboGioiTinh.SelectedIndex = 0;
            dataTableVDV = db.GetTableData("VDV");
            dgrVDV.DataSource = dataTableVDV;
            CanInputData(false);
        }

        public int FindIndex(DataTable dataTable, string field, string id)
        {
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row[field].ToString() == id) 
                    return i;
                i++;       
            }
            return -1;
        }

        private void ShowMessage(string message, string title = "Info")
        {
            MessageBox.Show(message, title);
        }

        private void ClearInput()
        {
            txtMaVDV.Clear();
            txtHoTenVDV.Clear();
            dpkNgaySinh.ResetText();
            dpkNgaySinh.Value = DateTime.Today.AddYears(-18);
            TenHinh = "";
            picVDV.Image = Resources.None;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isCreateNew = true;
            ClearInput();
            CanInputData(true);
            txtMaVDV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgrVDV.CurrentRow != null)
            {
                CanInputData(true);
                MaSoCu = txtMaVDV.Text;
                txtMaVDV.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgrVDV.CurrentRow != null)
            {
                DialogResult warningDialog = MessageBox.Show(
                    "Bạn có thật sự muốn xoá vận động viên này không?",
                    "Cảnh báo", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );
                if (!(warningDialog == DialogResult.Yes))
                {
                    return;
                }
                int selectedIndexOld = selectedIndex;
                dataTableVDV.Rows[selectedIndex].Delete();
                db.Save(dataTableVDV, "VDV");
                dataTableVDV = db.GetTableData("VDV", "", "MaVDV");
                dgrVDV.DataSource = dataTableVDV;
                if (selectedIndexOld == dataTableVDV.Rows.Count)
                {
                    selectedIndexOld--;
                }
                dgrVDV.CurrentCell = dgrVDV[0, selectedIndexOld];
                HinhXoa = picVDVpath + TenHinh;
                ClearInput();
                if (HinhXoa != "" && File.Exists(HinhXoa))
                {
                    DeleteAsync(HinhXoa);
                }
            }

        }

        private bool ValidateFields()
        {
            string alertTitle = "Kiểm tra thông tin";
            if(txtMaVDV.Text.Trim().Length == 0)
            {
                ShowMessage("Xin vui lòng cho biết mã số", alertTitle);
                txtMaVDV.SelectAll();
                txtMaVDV.Focus();
                return false;
            }
            if (txtHoTenVDV.Text.Trim().Length == 0)
            {
                ShowMessage("Xin cho biết họ tên", alertTitle);
                txtHoTenVDV.SelectAll();
                txtHoTenVDV.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateId()
        {
            if (!db.IsIdExist("VDV", $"MaVDV='{txtMaVDV.Text.Trim()}'"))
            {
                ShowMessage(
                    "Mã vận động viên đã tồn tại!", 
                    "Kiểm tra mã số"
                );
                txtMaVDV.Focus();
                txtMaVDV.SelectAll();
                return false;
            }
            return true;
        }

        private async void DeleteAsync(string filePath)
        {
            await Task.Delay(5000);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            File.Delete(filePath);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(!ValidateFields())
            {
                return;
            }

            string id = txtMaVDV.Text;

            if(isCreateNew)
            {
                if(!ValidateId())
                    return;
                InsertRow(dataTableVDV);
            }
            else
            {
                if (txtMaVDV.Text.Trim() != MaSoCu)
                {
                    if (!ValidateId()) 
                        return;
                }
                UpdateRow(dataTableVDV, selectedIndex);
            }

            if (HinhMoi != "" && !File.Exists(HinhMoi))
            {
                File.Copy(TenTapTin, HinhMoi, true);
            }

            if (HinhXoa != "" && File.Exists(HinhXoa))
            {
                DeleteAsync(HinhXoa);
            }

            CanInputData(false);
            isCreateNew = false;
            db.Save(dataTableVDV, "VDV");
            dataTableVDV = db.GetTableData("VDV");
            dgrVDV.DataSource = dataTableVDV;
            int index = FindIndex(dataTableVDV, "MaVDV", id);
            dgrVDV.CurrentCell = dgrVDV[0, index];
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            CanInputData(false);
            dgrVDV.Focus();
            isCreateNew = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgrVDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgrVDV.CurrentRow;
            if (row.Index != -1)
            {
                txtMaVDV.Text = row.Cells["MaVDV"].Value.ToString();
                txtHoTenVDV.Text = row.Cells["HoTenVDV"].Value.ToString();
                cboViTri.Text = row.Cells["ViTri"].Value.ToString();
                cboGioiTinh.Text = (bool)row.Cells["Nam"].Value == true ? "Nam" : "Nữ";
                dpkNgaySinh.Value = (DateTime)row.Cells["NgaySinh"].Value;
                cboDoi.SelectedValue = row.Cells["MaDoi"].Value.ToString();
                TenHinh = row.Cells["Hinh"].Value.ToString();
                if (TenHinh != "")
                {
                    try
                    {
                        picVDV.Image = new Bitmap(picVDVpath + TenHinh);
                    }
                    catch
                    {
                        ShowMessage("Tên hình không hợp lệ!", "Cảnh báo");
                        picVDV.Image = Resources.None;
                    }
                }
                else
                {
                    picVDV.Image = Resources.None;
                }
                selectedIndex = e.RowIndex;
                lblMauTin.Text = (selectedIndex + 1) + "/" + dataTableVDV.Rows.Count;
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            picFileDialog.InitialDirectory = picVDVpath;
            if (picFileDialog.ShowDialog() == DialogResult.OK)
            {
                TenTapTin = picFileDialog.FileName;
                TenHinh = TenTapTin.Substring(TenTapTin.LastIndexOf(@"\") + 1);
                HinhMoi = picVDVpath + TenHinh;
                picVDV.Image = new Bitmap(TenTapTin);
            }
        }

        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            if (picVDV.Image == null)
            {
                return;
            }
            bool confirm = (MessageBox.Show("Bạn có muốn bỏ ảnh của vận động viên này không?",
                    "Xóa ảnh", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes);
            if (confirm)
            {
                picVDV.Image = Resources.None;
                HinhXoa = picVDVpath + TenHinh;
                TenHinh = "";
                
            } 
        }

        private void InsertRow(DataTable dataTable)
        {
            DataRow row = dataTable.NewRow();
            row["MaVDV"] = txtMaVDV.Text;
            row["HoTenVDV"] = txtHoTenVDV.Text;
            row["Nam"] = true;
            row["NgaySinh"] = dpkNgaySinh.Value;
            row["MaDoi"] = cboDoi.SelectedValue.ToString();
            row["ViTri"] = cboViTri.Text;
            row["Nam"] = cboGioiTinh.Text == "Nam";
            row["Hinh"] = TenHinh;
            dataTable.Rows.Add(row);
        }

        private void UpdateRow(DataTable dataTable, int index = -1)
        {
            if (index == -1)
            {
                return;
            }
            DataRow row = dataTable.Rows[index];
            row["MaVDV"] = txtMaVDV.Text;
            row["HoTenVDV"] = txtHoTenVDV.Text;
            row["Nam"] = true;
            row["NgaySinh"] = dpkNgaySinh.Value;
            row["MaDoi"] = cboDoi.SelectedValue.ToString();
            row["ViTri"] = cboViTri.Text;
            row["Nam"] = cboGioiTinh.Text == "Nam";
            row["Hinh"] = TenHinh;
        }
    }

}
