using QuanLyChiTieuWithChatGPT.Models;

namespace QuanLyChiTieuWithChatGPT
{
    public partial class btnSubmit : Form
    {
        public btnSubmit()
        {
            InitializeComponent();
        }

       public static TaiKhoan account = null;
        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new QuanLyChiTieuDemoContext())
            {
                var taiKhoan = context.TaiKhoans.SingleOrDefault(x => x.TenTaiKhoan.ToLower() == txtTk.Text.ToLower());

                if (taiKhoan != null)
                {
                    account = taiKhoan;
                    Hide();
                    using (var form2 = new Form2())
                    {
                        form2.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên TK");
                }
            }

        }
    }
}