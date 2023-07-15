using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frm_dsTheThao : Form
    {
        public frm_dsTheThao()
        {
            InitializeComponent();
        }

        private void frm_dsTheThao_Load(object sender, EventArgs e)
        {
            List<string> dsName = new List<string>()
            {
                "Hoàng Quốc Tuấn",
                "Nông Văn Sơn",
                "Trần Văn Vũ"
            };
            foreach (string s in dsName)
            {
                cbo_name.Items.Add(s);
            }
            cbo_name.SelectedItem = "Hoàng Quốc Tuấn";
            tmr_time.Start();
            set_lst();
        }
        private void set_lst()
        {
            List<string> dsCacMon = new List<string>()
            {
                "Bóng đá",
                "Bóng bàn",
                "Nhảy dù",
                "Cầu lông",
                "Bóng chuyền",
                "Chạy nhanh"
            };
            foreach (string s in dsCacMon)
            {
                lst_left.Items.Add(s);
            }
        }

        private void tmr_time_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txt_time.Text = dt.ToString("dd/MM/yyyy");
            txt_time2.Text = dt.ToString("HH:mm:ss");
        }

        private void btn_chuyenPhai1_Click(object sender, EventArgs e)
        {
            if(lst_left.SelectedItem != null)
            {
                lst_right.Items.Add(lst_left.SelectedItem);
                lst_left.Items.Remove(lst_left.SelectedItem);
            }
        }

        private void btn_chuyentrai_Click(object sender, EventArgs e)
        {
            if(lst_right.SelectedItem != null)
            {
                lst_left.Items.Add(lst_right.SelectedItem);
                lst_right.Items.Remove(lst_right.SelectedItem);
            }
        }

        private void btn_chuyenTaiCaPhai_Click(object sender, EventArgs e)
        {
            lst_right.Items.Clear();
            
            foreach(var item in lst_left.Items)
            {
                lst_right.Items.Add(item);
            }
            lst_left.Items.Clear();
        }

        private void btn_chuenTatCaTrai_Click(object sender, EventArgs e)
        {
            lst_left.Items.Clear();

            foreach (var item in lst_right.Items)
            {
                lst_left.Items.Add(item);
            }
            lst_right.Items.Clear();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            lbl_line1.Text = cbo_name.Text;
            lbl_line2.Text = txt_time.Text + " " + txt_time2.Text;
            lbl_line3.Text = "**Môn đã chọn: ";
            string dsSum = "";
            foreach (var item in lst_right.Items)
            {
                dsSum += item.ToString() + ", ";
            }
            if(dsSum.Length > 0)
            {
                lbl_line4.Text = dsSum.Remove(dsSum.Length - 2);
            }
            else
            {
                lbl_line4.Text = "Không có môn nào được chọn!";
            }
            
        }

        private void lbl_line3_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnl_tt.Controls)
            {
                if (control is Label)
                {
                    control.Text = "";
                }
            }
            lst_left.Items.Clear();
            lst_right.Items.Clear();
            set_lst();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
