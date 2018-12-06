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

        private void radio_event(object sender, EventArgs e)
        {            
            RadioButton radio = (RadioButton)sender;
            if(radio.Checked)
            {
                if(radio.Name==radioButton_udp.Name)
                {
                    Enable_init();
                    groupBox_local.Enabled = true;
                }
                else if(radio.Name==radioButton_tcp.Name)
                {
                    Enable_init();
                    panel_CorS.Enabled = true;
                }
                else if(radio.Name==radioButton_C.Name
                    ||radio.Name==radioButton_S.Name)
                {
                    groupBox_local.Enabled = true;

                }
            }
            else
            {

            }

        }
        private void Enable_init()
        {
            panel_CorS_empty();//头区清空
            groupBox_local_empty();
            groupBox_send_empty();//发送区清空
            groupBox_recv_empty();//接收区清空

        }

        #region//头区清空
        private void panel_CorS_empty()
        {
            radioButton_C.Checked = false;
            radioButton_S.Checked = false;
            panel_CorS.Enabled = false;
            throw new NotImplementedException();
        }
        private void groupBox_local_empty()
        {
            textBox_local_ip.Text = "";
            textBox_local_port.Text = "";
            groupBox_local.Enabled = false;
            throw new NotImplementedException();
        }
        #endregion

        #region//发送区清空
        private void groupBox_send_empty()
        {
            groupBox_s_t_empty();
            groupBox_s_contain_empty();
            groupBox_s_to_where_empty();

            throw new NotImplementedException();
        }
        private void groupBox_s_t_empty()
        {
            radioButton_s_t_bin.Checked = false;
            radioButton_s_t_file.Checked = false;
            radioButton_s_t_hex.Checked = false;
            radioButton_s_t_text.Checked = false;
            throw new NotImplementedException();
        }
        private void groupBox_s_contain_empty()
        {
            textBox_s_contain.Text = "";
            groupBox_s_contain.Enabled = false;
            throw new NotImplementedException();
        }
        private void groupBox_s_to_where_empty()
        {
            textBox_s_t_ip.Text = "";
            textBox_s_t_port.Text = "";
            groupBox_s_to_where.Enabled = false;
            throw new NotImplementedException();
        }

        #endregion

        #region//接收区清空
        private void groupBox_recv_empty()
        {
            groupBox_r_t_empty();
            groupBox_r_dis_empty();
            panel_back_empty();//自动回复区清空
            throw new NotImplementedException();
        }
        private void groupBox_r_t_empty()
        {
            radioButton_r_t_bin.Checked = false;
            radioButton_r_t_file.Checked = false;
            radioButton_r_t_hex.Checked = false;
            radioButton_r_t_text.Checked = false;
            throw new NotImplementedException();
        }
        private void groupBox_r_dis_empty()
        {
            textBox_r_dis.Text = "";
            groupBox_r_dis.Enabled = false;
            throw new NotImplementedException();
        }
        #region//自动回复区清空
        private void panel_back_empty()
        {

            throw new NotImplementedException();
        }
        #endregion
        #endregion
        
        private void mainform_Load(object sender, EventArgs e)
        {
           
        }

      

        private void button_open_Click(object sender, EventArgs e)
        {
            groupBox_send.Enabled = true;
        }

        

        private void groupBox_s_t_Enter(object sender, EventArgs e)
        {
            groupBox_s_contain.Enabled = true;
        }
    }
}
