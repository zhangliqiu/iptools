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
        //  全局变量


        #region//   初始化区
        public mainform()
        {
            InitializeComponent();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
           
        }
        #endregion

        //  单选按钮事件
        private void radio_event(object sender, EventArgs e)
        {            
            RadioButton radio = (RadioButton)sender;
            if(radio.Checked)
            {
                if(radio.Name==radioButton_udp.Name)//  选择udp
                {
                    Enable_init();
                    groupBox_local.Enabled = true;
                }
                else if(radio.Name==radioButton_tcp.Name)// 选择tcp
                {
                    Enable_init();
                    panel_CorS.Enabled = true;
                }
                else if(radio.Name==radioButton_C.Name)//   选择tcp_client
                {
                    groupBox_local.Enabled = true;
                }
                else if(radio.Name==radioButton_S.Name)//   选择tcp_server
                {
                    groupBox_local.Enabled = true;
                }
                else if(radio.Name==radioButton_s_t_bin.Name)//   发送类型选择 二进制
                {
                    groupBox_s_contain.Enabled = true;
                }
                else if(radio.Name==radioButton_s_t_file.Name)//   发送类型选择 文件
                {
                    groupBox_s_contain.Enabled = true;
                }
                else if(radio.Name==radioButton_s_t_hex.Name)//   发送类型选择 十六进制
                {
                    groupBox_s_contain.Enabled = true;
                }
                else if(radio.Name==radioButton_s_t_text.Name)//   发送类型选择 文本
                {
                    groupBox_s_contain.Enabled = true;
                }
                
            }
            else
            {

            }

        }

        #region//   程序清空重来区
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
        }
        private void groupBox_local_empty()
        {
            textBox_local_ip.Text = "";
            textBox_local_port.Text = "";
            button_bind.Enabled = false;
            groupBox_local.Enabled = false;
        }
        #endregion

        #region//发送区清空
        private void groupBox_send_empty()
        {
            groupBox_s_t_empty();
            groupBox_s_contain_empty();
            groupBox_s_to_where_empty();
            groupBox_send.Enabled = false;
        }
        private void groupBox_s_t_empty()
        {
            radioButton_s_t_bin.Checked = false;
            radioButton_s_t_file.Checked = false;
            radioButton_s_t_hex.Checked = false;
            radioButton_s_t_text.Checked = false;
        }
        private void groupBox_s_contain_empty()
        {
            textBox_s_contain.Text = "";
            groupBox_s_contain.Enabled = false;
        }
        private void groupBox_s_to_where_empty()
        {
            textBox_s_t_ip.Text = "";
            textBox_s_t_port.Text = "";
            button_s_t_send.Enabled = false;
            button_s_t_con.Enabled = false;
        }

        #endregion

        #region//接收区清空
        private void groupBox_recv_empty()
        {
            groupBox_r_t_empty();
            groupBox_r_dis_empty();
            panel_back_empty();//自动回复区清空
        }
        private void groupBox_r_t_empty()
        {
            radioButton_r_t_bin.Checked = false;
            radioButton_r_t_file.Checked = false;
            radioButton_r_t_hex.Checked = false;
            radioButton_r_t_text.Checked = false;
        }
        private void groupBox_r_dis_empty()
        {
            textBox_r_dis.Text = "";
            groupBox_r_dis.Enabled = false;
        }

        #region//自动回复区清空
        private void panel_back_empty()
        {
            groupBox_b_t_empty();
            groupBox_b_contain_empty();
        }

        private void groupBox_b_contain_empty()
        {
            textBox_b_contain.Text = "";
            groupBox_b_contain.Enabled = false;
        }

        private void groupBox_b_t_empty()
        {
            radioButton_b_t_bin.Checked = false;
            radioButton_b_t_file.Checked = false;
            radioButton_b_t_hex.Checked = false;
            radioButton_b_t_recv.Checked = false;
            radioButton_b_t_text.Checked = false;
        }
        #endregion
        #endregion


        #endregion

        #region//   button事件区
        private void button_event(object sender,EventArgs e)
        {

            Button button = sender as Button;
            if(button.Name==button_bind.Name)
            {
                if(button_bind.Text=="绑定")
                {
                    if(socketbind())
                    {
                        button_bind.Text = "释放";
                        groupBox_s_t_empty();
                        groupBox_send.Enabled = true;

                    }

                }
                else
                {
                    if(unsocket())
                    {
                        button_bind.Text = "绑定";
                        groupBox_s_t_empty();
                    }
                }
            }
        }

        private bool unsocket()
        {
            return true;
        }
        private bool socketbind()
        {

            return true;
        }


        #endregion

        #region//   textBox修改事件
        private void textBoxText_Change(object sender,EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if(textBox.Name==textBox_local_ip.Name
                ||textBox.Name==textBox_local_port.Name)
            {
                button_bind.Enabled = check_local_point();
            }
        }

        private bool check_local_point()
        {
            if (textBox_local_ip.Text != "" && textBox_local_port.Text != "")
                return true;
            return false;
        }
        #endregion


    }
}
