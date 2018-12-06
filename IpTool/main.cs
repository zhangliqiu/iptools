using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpTool
{
    public partial class main : Form
    {
        string resultFile = "";
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
           
        }

        private void str_ip_udp_sendto_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                (sender as TextBox).SelectAll();
            }
            );
        }

        private void str_file_path_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                (sender as TextBox).SelectAll();
            }
            );
        }

        


        private void Btn_select_file_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_select_file.Enabled)
                Btn_select_file.Text = "选择文件";
            else
                Btn_select_file.Text = "来自文件";
        }

        private void file_yes_or_CheckedChanged(object sender, EventArgs e)
        {
            Btn_select_file.Enabled = udp_send_file_yes_or.Checked;
            str_path.Enabled = udp_send_file_yes_or.Checked;
        }
        
        private void Btn_select_file_Click(object sender, EventArgs e)
        {    
            OpenFileDialog openFileDialog1 = new OpenFileDialog();           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                resultFile = openFileDialog1.FileName;


        }
    }
}
