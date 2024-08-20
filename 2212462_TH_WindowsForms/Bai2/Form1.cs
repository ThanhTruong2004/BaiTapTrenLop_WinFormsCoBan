using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // xử lý sự kiện khi người chọn vào giới tính nam
        //click đôi vào control checkbox
        //đây là sự kiện mà nếu thay đổi việc check(check hoặc bỏ check đều xảy ra sự kiện)
        //Nếu muốn kt nút được check rồi mới báo thì sửa như sau:
        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            MessageBox.Show("Bạn chọn giới tính Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
            MessageBox.Show("Bạn chọn giới tính Nữ", "Thông báo");
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdXanh.Checked)
                MessageBox.Show("Bạn chọn màu Xanh", "Thông báo");    
        }

        private void rdTim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTim.Checked)
                MessageBox.Show("Bạn chọn màu Tím", "Thông báo");
        }

        private void txtHopMau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdTim.Checked)
                txtHopMau.BackColor = Color.Purple;
            else
                txtHopMau.BackColor = Color.Blue;
        }
    }
}
