using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace IpTool
{
    public partial class mainform : Form
    {
        #region//  全局变量
        //  状态变量
        bool str_local_point_check = false;    //本地端口检查
        bool str_remote_point_check = false;   //远程端口检查
        bool bTcp_connected = false;        //tcp连接状态
        bool bStartRecv = false;            //接收线程状态
        bool bTcpListen = false;            //tcp监听状态
        bool bSendback = false;             //是否自动回传
        bool bUdp = false;                  //协议选择       
        bool bBind = false;                 //绑定状态
        bool bTcpClient = false;            //Client or Server选择

        string str_local_ip;
        string str_local_port;
        string str_remote_ip;
        string str_remote_port;

        const bool Empty_C_S = true;         //Empty panel_c_s区
                                             //  储存控件
        string s_send_contain;              //发送区类容
        //  数据类型
        Datetype sendtype, recvtype, backtype;

        //  套接字引用
        TcpClient tcpclient;
        TcpListener tcplistener;
        UdpClient udpclient;

        enum Datetype { Text, Bin, File, Hex, Recved };
        #endregion

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
                        { Select_udp(); }
                        break;
                    //tcp
                    case "radioButton_tcp":
                        { Select_tcp(); }
                        break;
                    //tcp_client
                    case "radioButton_C":
                        { Select_tcp_client(); }
                        break;
                    //tcp_server
                    case "radioButton_S":
                        { Select_tcp_listen(); }
                        break;
                    #endregion

                    /////////
                    ///发送格式
                    #region
                    //二进制
                    case "radioButton_s_t_bin":
                        { sendtype = Datetype.Bin; Send_button_contain(); groupBox_s_contain.Text = "类容"; }
                        break;
                    //文件
                    case "radioButton_s_t_file":
                        { sendtype = Datetype.File; Send_button_contain(); groupBox_s_contain.Text = "路径"; }
                        break;
                    //十六进制
                    case "radioButton_s_t_hex":
                        { sendtype = Datetype.Hex; Send_button_contain(); groupBox_s_contain.Text = "类容"; }
                        break;
                    //文本
                    case "radioButton_s_t_text":
                        { sendtype = Datetype.Text; Send_button_contain(); groupBox_s_contain.Text = "类容"; }
                        break;
                    #endregion

                    /////////
                    //显示格式
                    #region
                    //文件
                    case "radioButton_r_t_file":
                        { groupBox_r_dis.Enabled = true; groupBox_r_dis.Text = "路径"; }
                        break;
                    ///文本
                    case "radioButton_r_t_text":
                        { groupBox_r_dis.Enabled = true; groupBox_r_dis.Text = "类容"; }
                        break;
                    ///2进制
                    case "radioButton_r_t_bin":
                        { groupBox_r_dis.Enabled = true; groupBox_r_dis.Text = "类容"; }
                        break;
                    ///16进制
                    case "radioButton_r_t_hex":
                        { groupBox_r_dis.Enabled = true; groupBox_r_dis.Text = "类容"; }
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
        #region//工作模式选择区
        //  选择 udp
        private void Select_udp()
        {
            Close_all_doing();
            Empty_all();
            bUdp = true;
            groupBox_local.Enabled = true;
        }
        //  选择 tcp
        private void Select_tcp()
        {
            Close_all_doing();
            Empty_all();
            bUdp = false;
            panel_CorS.Enabled = true;
        }
        //  选择 tcp_client
        private void Select_tcp_client()
        {
            Close_all_doing();
            Empty_all(!Empty_C_S);
            bTcpClient = true;
            groupBox_local.Enabled = true;
        }
        //  选择 tcp_listen
        private void Select_tcp_listen()
        {
            Close_all_doing();
            Empty_all(!Empty_C_S);
            bTcpClient = false;
            //  修改“绑定”为“监听”
            button_bind.Text = "监听";
            groupBox_local.Enabled = true;

        }

        //  本地资源释放
        private void Close_all_doing()
        {
            if (bTcp_connected)
                Free_tcp_connect();
            if (bTcpListen)
                Free_tcp_listen();
            else
                Free_udp();
        }

        private void Free_tcp_connect()
        {
            //
        }
        private void Free_tcp_listen()
        {
            //
        }

        private void Free_udp()
        {
            //
            if (udpclient != null) udpclient.Close();
        }

        #endregion



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
                        if (
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
        private void Empty_all(bool bInit_c_s = true)
        {
            bUdp = false;
            if (bInit_c_s) panel_CorS_empty();
            groupBox_local_empty();
            groupBox_send_empty();//发送区清空
            groupBox_recv_empty();//接收区清空
            str_local_ip = textBox_local_ip.Text;
            str_local_port = textBox_local_port.Text;
            str_remote_ip = textBox_s_t_ip.Text;
            str_remote_port = textBox_s_t_port.Text;

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
            bTcpClient = false;
            bTcpListen = false;
            radioButton_C.Checked = false;
            radioButton_S.Checked = false;
            panel_CorS.Enabled = false;
        }
        private void groupBox_local_empty()
        {
            textBox_local_ip.Text = "127.0.0.1";
            textBox_local_port.Text = "0";
            button_bind.Enabled = true;
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
            groupBox_s_contain.Text = "类容";
            textBox_s_contain.Text = "";
            groupBox_s_contain.Enabled = false;
        }
        private void groupBox_s_to_where_empty()
        {
            bTcp_connected = false;
            textBox_s_t_ip.Text = "127.0.0.1";
            textBox_s_t_ip.Enabled = true;
            textBox_s_t_port.Enabled = true;
            textBox_s_t_port.Text = "0";
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
            radioButton_r_t_text.Checked = true;
        }
        private void groupBox_r_dis_empty()
        {
            textBox_r_dis.Text = "";
            groupBox_r_dis.Enabled = true;
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
        #region//   按钮实现函数
        //  监听操作
        private void My_Listen()
        {
            //
            groupBox_recv.Enabled = true;
            bTcpListen = true;
            button_bind.Text = "释放";
        }

        //  发送操作
        private void My_send()
        {


        }
        #region//   绑定操作
        private void local_socket_bind()
        {
            //
            int port = int.Parse(str_local_port);
            IPEndPoint lip = new IPEndPoint(IPAddress.Parse(str_local_ip), port);


            /// udp本地绑定
            /// 
            /// 
            if (bUdp)
            {
                //

                Status_label.Text = "udp绑定成功";
                bBind = true;
                button_bind.Text = "释放";
                groupBox_send.Enabled = true;
                groupBox_recv.Enabled = true;
                textBox_local_ip.Enabled = false;
                textBox_local_port.Enabled = false;
                Start_recv();
            }
            /// tcp本地绑定
            /// 
            /// 
            else
            {
                //

                
                Status_label.Text = "tcp绑定成功";
                bBind = true;
                button_bind.Text = "释放";
                groupBox_send.Enabled = true;
                button_s_t_con.Enabled = true;
                textBox_local_ip.Enabled = false;
                textBox_local_port.Enabled = false;

            }


        }

        private void Start_recv()
        {
            
        }

        private void local_socket_unbind()
        {
            /// 像 TcpListen 这种少数情况要优先考虑
            /// 最好在if判断的最前面

            if (bTcpListen)
            {
                My_free();
                Group_local_control(false, true);
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

       
        #endregion
        //  tcp 断开操作
        private void un_connect_remote()
        {
            //断开的动作只会来自 TcpClient

            button_s_t_con.Text = "连接";
            bTcp_connected = false;
            button_s_t_send.Enabled = false;
            textBox_s_t_ip.Enabled = true;
            textBox_s_t_port.Enabled = true;
            groupBox_recv.Enabled = false;

        }

        private void connect_remote()
        {
            //只有tcpclient才会连接，所以不必再检查工作模式
            //连接前先检查目的point
            if (str_remote_point_check)
            {
                if (bTcp_connected = connect_ditail())
                { After_tcp_connected(); }
            }
        }
        //tcp连接成功后的后续工作
        private void After_tcp_connected()
        {
            button_s_t_con.Text = "断开";
            if (groupBox_s_contain.Enabled) button_s_t_send.Enabled = true;
            textBox_s_t_ip.Enabled = false;
            textBox_s_t_port.Enabled = false;

            bStartRecv = true;
            groupBox_recv.Enabled = true;
        }

        private bool connect_ditail()
        {

            return true;
        }

        #endregion

        //  控件使能
        private void Group_local_control(bool bl, bool bListen = false)
        {
            if (bListen)
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

        
        #endregion

        #region//   textBox修改事件主要只检查ip port合法性
        private void textBoxText_Change(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            // 文本规范检查
            switch (textBox.Name)
            {
                //本地point
                case "textBox_local_ip":
                    str_local_ip = textBox.Text;
                    if (!check_ip(str_local_ip))
                    {
                        Status_label.Text = "请检查本地ip地址";
                        str_local_point_check = false;
                    }
                    else
                    {
                        Status_label.Text = "";
                        str_local_point_check = check_port(str_local_port);
                    }
                    break;

                case "textBox_local_port":
                    str_local_port = textBox.Text;
                    if (!check_port(str_local_port))
                    {
                        Status_label.Text = "请检查本地端口,正确范围 0-65535";
                        str_local_point_check = false;
                    }
                    else
                    {
                        Status_label.Text = "";
                        str_local_point_check = check_ip(str_local_ip);
                    }
                    break;
                //远程point
                case "textBox_s_t_ip":
                    str_remote_ip = textBox.Text;
                    if (!check_ip(str_remote_ip))
                    {
                        Status_label.Text = "请检查目标ip地址";
                        str_remote_point_check = false;
                        Btn_con_enable();
                        Btn_send_enable();
                    }
                    else
                    {
                        Status_label.Text = "";
                        str_remote_point_check = check_port(str_remote_port);
                        Btn_con_enable();
                        Btn_send_enable();
                    }

                    break;

                case "textBox_s_t_port":
                    str_remote_port = textBox.Text;
                    if (!check_port(str_remote_port))
                    {
                        Status_label.Text = "请检查目标端口,正确范围 0-65535";
                        str_remote_point_check = false;
                        Btn_con_enable();
                        Btn_send_enable();
                    }
                    else
                    {
                        Status_label.Text = "";
                        str_remote_point_check = check_ip(str_remote_ip);
                        Btn_con_enable();
                        Btn_send_enable();
                    }

                    break;
                case "":

                    break;
                default:
                    break;
            }
            button_bind.Enabled = str_local_point_check;

            button_s_t_con.Enabled = (str_remote_point_check && bBind && bTcpClient);




        }


        #region//检查 ip port 书写规范
        //  检查ip
        private bool check_point(string s_ip, string s_port)
        {
            if (check_ip(s_ip))
                if (check_port(s_port))
                    return true;
            return false;
        }
        //  检查ip
        private bool check_ip(string s_ip)
        {
            int i = 0;
            IPAddress addr;
            foreach (var ch in s_ip)
            {
                if (ch == '.') i++;
            }
            if (i == 3)
                if (IPAddress.TryParse(s_ip, out addr))
                { return true; }

            return false;
        }
        //  检查port
        private bool check_port(string s_port)
        {
            int i;
            if (!int.TryParse(s_port, out i)) { return false; }
            if (i < 0 || i > 65535) { return false; }
            return true;
        }
        #endregion

        #endregion

        //  单机TextBox事件
        private void Click_TextBox(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;
            BeginInvoke((Action)delegate
            {
                textBox.SelectAll();
            });
        }

        #region//   绑定 连接 发送按钮 使能 enable
        private void Btn_con_enable()
        {
            if (!bUdp)//tcp协议
                if (bBind)//绑定
                    if (str_remote_point_check)//远程地址无误
                        button_s_t_con.Enabled = true;

            button_s_t_con.Enabled = false;
        }
        private void Btn_send_enable()
        {
            if (bUdp)//udp协议
                if (groupBox_s_contain.Enabled)//确定类容
                    if (str_remote_point_check)//远程地址无误
                        button_s_t_send.Enabled = true;
            else
                button_s_t_send.Enabled = false;
        }
        #endregion
    }
}
