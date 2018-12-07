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
        bool bUdp = false;
        bool bBind = false;
        bool bTcpClient = false;
        

        Datetype sendtype, recvtype, backtype;
        enum Datetype { Text, Bin, File, Hex, Recved };
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
                        { bUdp = true; Enable_init(); groupBox_local.Enabled = true; }
                        break;
                    //tcp
                    case "radioButton_tcp":
                        { bUdp = false; Enable_init(); panel_CorS.Enabled = true; }
                        break;
                    //tcp_client
                    case "radioButton_C":
                        { bTcpClient = true; Enable_init(false); groupBox_local.Enabled = true; }
                        break;
                    //tcp_server
                    case "radioButton_S":
                        Select_tcp_server();                        
                        break;
                    #endregion

                    /////////
                    ///发送格式
                    #region
                    //二进制
                    case "radioButton_s_t_bin":
                        { sendtype = Datetype.Bin; Send_button_contain(); }
                        break;
                    //文件
                    case "radioButton_s_t_file":
                        { sendtype = Datetype.File; Send_button_contain(); }
                        break;
                    //十六进制
                    case "radioButton_s_t_hex":
                        { sendtype = Datetype.Hex; Send_button_contain(); }
                        break;
                    //文本
                    case "radioButton_s_t_text":
                        { sendtype = Datetype.Text; Send_button_contain(); }
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
        //  选择tcp监听模式
        private void Select_tcp_server()
        {
            bTcpClient = false;
            Enable_init(false);
            groupBox_local.Enabled = true;
            button_bind.Text = "监听";
        }

        private void Send_button_contain()
        {
            groupBox_s_contain.Enabled = true;
            button_s_t_send.Enabled = Send_check();
        }
        //  来自与单选按钮
        //  判断激活发送功能的条件
        private bool Send_check()
        {
            if (bBind)
                if (check_point(textBox_s_t_ip.Text, textBox_s_t_port.Text))
                    if (groupBox_s_contain.Enabled)
                        if(
                            bUdp
                            || bTcp_connected
                            )
                        return true;
            return false;
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
                case "发送":
                    My_send();
                    break;
                case "监听":
                    My_Listen();
                    break;
                default:
                    break;
            }


        }

        private void My_Listen()
        {
            //
            groupBox_recv.Enabled = true;
            bTcpListen = true;
            button_bind.Text = "释放";
        }

        private void My_send()
        {


        }
        #region//   绑定操作
        private void local_socket_bind()
        {
            //

            /// udp本地绑定
            /// 
            /// 
            if (bUdp)
            {
                //绑定成功
                if (bBind = My_bind())
                {
                    Group_local_control(true);
                    groupBox_send.Enabled = true;
                    groupBox_recv.Enabled = true;
                }
            }
            /// tcp本地绑定
            /// 
            /// 
            else
            {
                //绑定成功
                if (bBind = My_bind())
                {
                    Group_local_control(true);
                    if (bTcpClient) groupBox_send.Enabled = true;
                }
            }


        }

        private void local_socket_unbind()
        {
            /// 像 TcpListen 这种少数情况要优先考虑
            /// 最好在if判断的最前面
            
            if(bTcpListen)
            {
                My_free();
                Group_local_control(false,true);
            }
            /// udp释放
            /// 
            /// 
            else if (bUdp)
            {
                My_free();
                Group_local_control(false);

            }
            /// tcp释放
            /// 
            /// 
            else
            {
                My_free();
                Group_local_control(false);

            }
        }

        private void Group_local_control(bool bl,bool bListen=false)
        {
            if(bListen)
            {
                //  Listen_server
                //  监听绑定
                if (bl)
                {
                    button_bind.Text = "释放";
                    textBox_local_ip.Enabled = false;
                    textBox_local_port.Enabled = false;
                }
                //  监听的释放
                else
                {
                    button_bind.Text = "监听";
                    textBox_local_port.Enabled = true;
                    textBox_local_ip.Enabled = true;
                    groupBox_send_empty();
                    groupBox_recv_empty();
                }

            }
            else if (bl)
            {
                button_bind.Text = "释放";
                textBox_local_ip.Enabled = false;
                textBox_local_port.Enabled = false;
            }
            else
            {
                button_bind.Text = "绑定";
                textBox_local_port.Enabled = true;
                textBox_local_ip.Enabled = true;
                groupBox_send_empty();
                groupBox_recv_empty();
            }
        }


        #endregion

        private void un_connect_remote()
        {
            //断开的动作只会来自与 TcpClient

            button_s_t_con.Text = "连接";
            bTcp_connected = false;
            button_s_t_send.Enabled = false;
            textBox_s_t_ip.Enabled = true;
            textBox_s_t_port.Enabled = true;
            groupBox_recv.Enabled = false;

        }

        private void connect_remote()
        {
            //连接前先检查目的point
            if (str_remote_ip_check)
            {
                if(bTcp_connected = connect_ditail())
                {
                    button_s_t_con.Text = "断开";
                    if(groupBox_s_contain.Enabled) button_s_t_send.Enabled = true;
                    textBox_s_t_ip.Enabled = false;
                    textBox_s_t_port.Enabled = false;

                    bStartRecv = true;
                    groupBox_recv.Enabled = true;

                }

            }
        }

        private bool connect_ditail()
        {

            return true;
        }


        private void My_free()
        {
            ///关于udp的释放相对容易
            ///tcp则相对复杂
            ///尤其是已经连接的tcp
            ///和作为监听的tcp
            ///
            if (bTcpListen)
            {
                
            }

        }

        private bool My_bind()
        {
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
                    if (bUdp
                        || bTcp_connected)
                    {
                        if (groupBox_s_contain.Enabled) button_s_t_send.Enabled = true;
                    }
                    //  激活连接按钮的条件   1.tcp协议 并且 client模式
                    else if (radioButton_C.Checked)
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
