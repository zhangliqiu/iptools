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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void radioButton_udp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {
            panel_CorS.Enabled = false;
            groupBox_local.Enabled = false;
            groupBox_recv.Enabled = false;
            groupBox_send.Enabled = false;

        }

        private void radioButton_udp_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton_udp.Checked)
            {
                panel_CorS.Enabled = false;
                groupBox_local.Enabled = true;
            } 
            else
            {

            }
            
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            groupBox_send.Enabled = true;
        }
    }
}
