using QuanLyChiTieuWithChatGPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieuWithChatGPT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = btnSubmit.account;
            // lbInfo.Text = $"Xin chao : {taiKhoan.TenTaiKhoan}" ;
            LoadData();
        }

        public void LoadData()
        {
            using (QuanLyChiTieuDemoContext context = new QuanLyChiTieuDemoContext())
            {
                var loaiChiTieu = context.LoaiChiTieus.ToArray();
                cboLoaiChiTieu.DataSource = loaiChiTieu;
                cboLoaiChiTieu.DisplayMember = "TenLoai";
                cboLoaiChiTieu.ValueMember = "MaLoai";
                dgView.DataSource = context.ChiTieus.ToArray() ;    
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new QuanLyChiTieuDemoContext())
            {
                var message = new StringBuilder();
                if (numSoTIen.Value <= 0)
                {
                    message.AppendLine("\nSố Tiền phải lớn hơn 0");
                }
                if (String.IsNullOrWhiteSpace(txtMoTa.Text))
                {
                    message.AppendLine("\nMô tả không được để trống");
                }

                // Kiểm tra đủ điều kiện chưa
                if (message.Length > 0)
                {
                    MessageBox.Show(message.ToString());
                }
                else
                {
                    if (int.TryParse(cboLoaiChiTieu.SelectedValue?.ToString(), out int maLoai))
                    {
                        var chiTieu = new ChiTieu
                        {
                            MoTa = txtMoTa.Text,
                            MaLoai = maLoai,
                            NgayChi = dtNgayCHi.Value,
                            SoTien = numSoTIen.Value
                        };
                        context.ChiTieus.Add(chiTieu);
                        context.SaveChanges();
                    }
                }
                LoadData();
            }

        }
    }
}
