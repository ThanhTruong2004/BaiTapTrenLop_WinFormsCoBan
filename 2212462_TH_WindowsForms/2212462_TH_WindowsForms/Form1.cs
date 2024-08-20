namespace _2212462_TH_WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // click đôi vào nút chương trình sẽ tự động tạo hàm sự này:
        // khi ta click vào nút, chương trình sẽ làm gì
        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;

            MessageBox.Show($"Xin chao ban {tenDaNhap}. rat vui duoc gap ban.");
        }
        //bên trên nhập gì bên dưới sao chép lại
        //Hộp thoại sao chép không cho phép gỗ, chỉ cho sao chép bên trên thì xử lý vào mục ReadOnly bật True.
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text=txtTen.Text;

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;

        }
        //Bây giờ muốn xuwrlys sự kiện, trong ô tên gõ gì thì oke sao chép nội dung y chang vậy:
        //Xử lý như sau:
        //click đôi vào textbox, sự kiện Texchanged đượ tạo
    }
}
