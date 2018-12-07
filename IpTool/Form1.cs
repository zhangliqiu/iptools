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
        bool str_local_ip_check = false;
        bool str_remote_ip_check = false;
        bool bTcp_connected = false;
        bool bStartRecv = false;
        bool bTcpListen = false;
        bool bSendback = false;

        #region//   初始化区
        public mainform()
        {
            InitializeComponent();
        }
        private void mainform_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region//  单选按钮事件
        private void radio_event(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
                switch (radio.Name)
                {
                    /////////
                    /// 协议选择
                    #region
                    //udp
                    case "radioButton_udp":
                        { Enable_init(); groupBox_local.Enabled = true; }
                        break;
                    //tcp
                    case "radioButton_tcp":
                        { Enable_init(); panel_CorS.Enabled = true; }
                        break;
                    //tcp_client
                    case "radioButton_C":
                        { Enable_init(false); groupBox_local.Enabled = true; }
                        break;
                    //tcp_server
                    case "radioButton_S":
                        { Enable_init(false); groupBox_local.Enabled = true; }
                        break;
                    #endregion

                    /////////
                    ///发送格式
                    #region
                    //二进制
                    case "radioButton_s_t_bin":
                        { groupBox_s_contain.Enabled = true; }
                        break;
                    //文件
                    case "radioButton_s_t_file":
                        { groupBox_s_contain.Enabled = true; }
                        break;
                    //十六进制
                    case "radioButton_s_t_hex":
                        { groupBox_s_contain.Enabled = true; }
                        break;
                    //文本
                    case "radioButton_s_t_text":
                        { groupBox_s_contain.Enabled = true; }
                        break;
                    #endregion

                    /////////
                    //显示格式
                    #region
                    //文件
                    case "radioButton_r_t_file":
                        { groupBox_r_dis.Enabled = true; }
                        break;
                    ///文本
                    case "radioButton_r_t_text":
                        { groupBox_r_dis.Enabled = true; }
                        break;
                    ///2进制
                    case "radioButton_r_t_bin":
                        { groupBox_r_dis.Enabled = true; }
                        break;
                    ///16进制
                    case "radioButton_r_t_hex":
                        { groupBox_r_dis.Enabled = true; }
                        break;
                    #endregion

                    /////////
                    ///自动回传
                    #region
                    ///文件
                    case "radioButton_b_t_file":
                        { groupBox_b_contain.Enabled = true; textBox_b_contain.ReadOnly = false; }
                        break;
                    ///2进制
                    case "radioButton_b_t_bin":
                        { groupBox_b_contain.Enabled = true; textBox_b_contain.ReadOnly = false; }
                        break;
                    ///文本
                    case "radioButton_b_t_text":
                        { groupBox_b_contain.Enabled = true; textBox_b_contain.ReadOnly = false; }
                        break;
                    ///16进制
                    case "radioButton_b_t_hex":
                        { groupBox_b_contain.Enabled = true; textBox_b_contain.ReadOnly = false; }
                        break;
                    ///接收的数据
                    case "radioButton_b_t_recv":
                        { groupBox_b_contain.Enabled = true; textBox_b_contain.ReadOnly = true; }
                        break;
                    #endregion
                    default:
                        break;
                }

        }
        #endregion


        #region//  复选框 - 自动回传按钮事件
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            switch (checkBox.Name)
            {
                case "checkBox_back":
                    {
                        if (checkBox.Checked) Enable_send_back();
                        else Close_send_back();
                    }
                    break;
                case "":
                    { }
                    break;
                default:
                    break;
            }
        }

        private void Close_send_back()
        {
            groupBox_b_t.Enabled = false;
            groupBox_b_contain.Enabled = false;
            bSendback = false;
        }

        private void Enable_send_back()
        {
            groupBox_b_t.Enabled = true;
        }
        #endregion

        #region//   程序清空重来区
        private void Enable_init(bool i = true)
        {
            /////用户在不退出程序的情况下进行模式
            ///切换时要进行程序运行的状态检查
            /// tcp 是否已经连接到远程
            /// udp 是否已经绑定
            /// 切换前要进行短线操作
            if (bTcp_connected)
                // 关闭tcp连接
                Tcp_down();
            if (bTcpListen)
                // 关闭监听
                TcpListen_down();
            if (i) panel_CorS_empty();//头区清空
            groupBox_local_empty();
            groupBox_send_empty();//发送区清空
            groupBox_recv_empty();//接收区清空

        }

        // 关闭监听
        private void TcpListen_down()
        {
            //

            bTcpListen = false;

        }
        // 关闭tcp连接
        private void Tcp_down()
        {
            //

            bTcp_connected = false;
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
            textBox_local_ip.Enabled = true;
            textBox_local_port.Enabled = true;
            button_bind.Text = "绑定";
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
            textBox_s_t_ip.Enabled = true;
            textBox_s_t_port.Enabled = true;
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
            groupBox_recv.Enabled = false;
            checkBox_back.Checked = false;
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
        private void button_event(object sender, EventArgs e)
        {

            Button button = sender as Button;
            switch (button.Text)
            {
                case "绑定":
                    local_socket_bind();
                    break;
                case "释放":
                    local_socket_unbind();
                    break;
                case "连接":
                    connect_remote();
                    break;
                case "断开":
                    un_connect_remote();
                    break;
                default:
                    break;
            }


        }

        private void un_connect_remote()
        {
            //

            button_s_t_con.Text = "连接";
            bTcp_connected = false;
            button_s_t_send.Enabled = false;
            textBox_s_t_ip.Enabled = false;
            textBox_s_t_port.Enabled = false;

        }

        private void connect_remote()
        {
            //连接前先检查目的point
            if (str_remote_ip_check)
            {
                button_s_t_con.Text = "断开";
                bTcp_connected = true;
                button_s_t_send.Enabled = true;

            }
        }

        private void local_socket_unbind()
        {
            //

            if (bTcp_connected) un_connect_remote();
            button_bind.Text = "绑定";
            groupBox_send_empty();
            groupBox_recv_empty();
            textBox_local_ip.Enabled = true;
            textBox_local_port.Enabled = true;
        }

        private void local_socket_bind()
        {
            //

            // 工作模式检查
            if (radioButton_udp.Checked)
            {
                // udp模式,绑定成功就能开始接收数据
                if (str_local_ip_check && Local_udp_bind()) 
                {
                    bStartRecv = true;
                    groupBox_recv.Enabled = true;
                    groupBox_send.Enabled = true;
                    button_bind.Text = "释放";
                    textBox_local_ip.Enabled = false;
                    textBox_local_port.Enabled = false;
                }
            }
            //如果时tcp则情况较为复杂
            else
            {
                // Client模式
                if(radioButton_C.Checked&&Local_tcp_bind())
                {
                    
                }
                // Listen模式
                else if(Local_tcp_listen())
                {
                    ///成功监听
                    ///开始接收数据
                    groupBox_recv.Enabled=true;
                }
            }
            

        }

        private bool Local_tcp_listen()
        {
            return true;
        }

        private bool Local_tcp_bind()
        {
            return true;
        }

        // 绑定本地udp 采用异常机制
        private bool Local_udp_bind()
        {
            //

            return true;
        }





        #endregion

        #region//   textBox修改事件
        private void textBoxText_Change(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // 本地端口地址文本规范检查
            if (textBox.Name == textBox_local_ip.Name
                || textBox.Name == textBox_local_port.Name)
            {
                str_local_ip_check = check_point(textBox_local_ip.Text, textBox_local_port.Text);
                button_bind.Enabled = str_local_ip_check;
            }
            // 目的地址端口规范检查
            else if (textBox.Name == textBox_s_t_ip.Name
                || textBox.Name == textBox_s_t_port.Name)
            {

                if (check_point(textBox_s_t_ip.Text, textBox_s_t_port.Text))
                {
                    str_remote_ip_check = true;

                    //  激活发送按钮的条件判断 1.udp协议 或者 已经连接的 tcp
                    if (radioButton_udp.Checked
                        || bTcp_connected)
                    {
                        button_s_t_send.Enabled = true;
                    }
                    //  激活连接按钮的条件   1.tcp协议 并且 client模式
                    else if (radioButton_tcp.Checked
                        && radioButton_C.Checked)
                    {
                        button_s_t_con.Enabled = true;
                    }

                }
            }
        }

        private bool check_point(string s_ip, string s_port)  //检查 ip port 规范
        {
            if (s_ip != "" && s_port != "")
                return true;
            return false;
        }

        #endregion


    }
}
