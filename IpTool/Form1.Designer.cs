namespace IpTool
{
    partial class mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_tcp_or_udp = new System.Windows.Forms.Panel();
            this.radioButton_tcp = new System.Windows.Forms.RadioButton();
            this.radioButton_udp = new System.Windows.Forms.RadioButton();
            this.panel_CorS = new System.Windows.Forms.Panel();
            this.radioButton_S = new System.Windows.Forms.RadioButton();
            this.radioButton_C = new System.Windows.Forms.RadioButton();
            this.textBox_local_ip = new System.Windows.Forms.TextBox();
            this.button_bind = new System.Windows.Forms.Button();
            this.textBox_local_port = new System.Windows.Forms.TextBox();
            this.groupBox_role_select = new System.Windows.Forms.GroupBox();
            this.groupBox_local = new System.Windows.Forms.GroupBox();
            this.label_local_info = new System.Windows.Forms.Label();
            this.groupBox_send = new System.Windows.Forms.GroupBox();
            this.groupBox_s_to_where = new System.Windows.Forms.GroupBox();
            this.textBox_s_t_ip = new System.Windows.Forms.TextBox();
            this.button_s_t_con = new System.Windows.Forms.Button();
            this.textBox_s_t_port = new System.Windows.Forms.TextBox();
            this.button_s_t_send = new System.Windows.Forms.Button();
            this.groupBox_s_contain = new System.Windows.Forms.GroupBox();
            this.textBox_s_contain = new System.Windows.Forms.TextBox();
            this.groupBox_s_t = new System.Windows.Forms.GroupBox();
            this.radioButton_s_t_hex = new System.Windows.Forms.RadioButton();
            this.radioButton_s_t_bin = new System.Windows.Forms.RadioButton();
            this.radioButton_s_t_text = new System.Windows.Forms.RadioButton();
            this.radioButton_s_t_file = new System.Windows.Forms.RadioButton();
            this.groupBox_recv = new System.Windows.Forms.GroupBox();
            this.panel_back = new System.Windows.Forms.Panel();
            this.checkBox_back = new System.Windows.Forms.CheckBox();
            this.groupBox_b_t = new System.Windows.Forms.GroupBox();
            this.radioButton_b_t_recv = new System.Windows.Forms.RadioButton();
            this.radioButton_b_t_hex = new System.Windows.Forms.RadioButton();
            this.radioButton_b_t_bin = new System.Windows.Forms.RadioButton();
            this.radioButton_b_t_text = new System.Windows.Forms.RadioButton();
            this.radioButton_b_t_file = new System.Windows.Forms.RadioButton();
            this.groupBox_b_contain = new System.Windows.Forms.GroupBox();
            this.textBox_b_contain = new System.Windows.Forms.TextBox();
            this.groupBox_r_t = new System.Windows.Forms.GroupBox();
            this.radioButton_r_t_hex = new System.Windows.Forms.RadioButton();
            this.radioButton_r_t_bin = new System.Windows.Forms.RadioButton();
            this.radioButton_r_t_text = new System.Windows.Forms.RadioButton();
            this.radioButton_r_t_file = new System.Windows.Forms.RadioButton();
            this.groupBox_r_dis = new System.Windows.Forms.GroupBox();
            this.textBox_r_dis = new System.Windows.Forms.TextBox();
            this.panel_tcp_or_udp.SuspendLayout();
            this.panel_CorS.SuspendLayout();
            this.groupBox_role_select.SuspendLayout();
            this.groupBox_local.SuspendLayout();
            this.groupBox_send.SuspendLayout();
            this.groupBox_s_to_where.SuspendLayout();
            this.groupBox_s_contain.SuspendLayout();
            this.groupBox_s_t.SuspendLayout();
            this.groupBox_recv.SuspendLayout();
            this.panel_back.SuspendLayout();
            this.groupBox_b_t.SuspendLayout();
            this.groupBox_b_contain.SuspendLayout();
            this.groupBox_r_t.SuspendLayout();
            this.groupBox_r_dis.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_tcp_or_udp
            // 
            this.panel_tcp_or_udp.Controls.Add(this.radioButton_tcp);
            this.panel_tcp_or_udp.Controls.Add(this.radioButton_udp);
            this.panel_tcp_or_udp.Location = new System.Drawing.Point(7, 16);
            this.panel_tcp_or_udp.Name = "panel_tcp_or_udp";
            this.panel_tcp_or_udp.Size = new System.Drawing.Size(47, 45);
            this.panel_tcp_or_udp.TabIndex = 0;
            // 
            // radioButton_tcp
            // 
            this.radioButton_tcp.AutoSize = true;
            this.radioButton_tcp.Location = new System.Drawing.Point(3, 25);
            this.radioButton_tcp.Name = "radioButton_tcp";
            this.radioButton_tcp.Size = new System.Drawing.Size(41, 16);
            this.radioButton_tcp.TabIndex = 0;
            this.radioButton_tcp.Text = "tcp";
            this.radioButton_tcp.UseVisualStyleBackColor = true;
            this.radioButton_tcp.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_udp
            // 
            this.radioButton_udp.AutoSize = true;
            this.radioButton_udp.Location = new System.Drawing.Point(3, 3);
            this.radioButton_udp.Name = "radioButton_udp";
            this.radioButton_udp.Size = new System.Drawing.Size(41, 16);
            this.radioButton_udp.TabIndex = 0;
            this.radioButton_udp.Text = "udp";
            this.radioButton_udp.UseVisualStyleBackColor = true;
            this.radioButton_udp.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // panel_CorS
            // 
            this.panel_CorS.Controls.Add(this.radioButton_S);
            this.panel_CorS.Controls.Add(this.radioButton_C);
            this.panel_CorS.Enabled = false;
            this.panel_CorS.Location = new System.Drawing.Point(57, 16);
            this.panel_CorS.Name = "panel_CorS";
            this.panel_CorS.Size = new System.Drawing.Size(36, 45);
            this.panel_CorS.TabIndex = 0;
            // 
            // radioButton_S
            // 
            this.radioButton_S.AutoSize = true;
            this.radioButton_S.Location = new System.Drawing.Point(3, 25);
            this.radioButton_S.Name = "radioButton_S";
            this.radioButton_S.Size = new System.Drawing.Size(29, 16);
            this.radioButton_S.TabIndex = 0;
            this.radioButton_S.TabStop = true;
            this.radioButton_S.Text = "S";
            this.radioButton_S.UseVisualStyleBackColor = true;
            this.radioButton_S.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_C
            // 
            this.radioButton_C.AutoSize = true;
            this.radioButton_C.Location = new System.Drawing.Point(3, 3);
            this.radioButton_C.Name = "radioButton_C";
            this.radioButton_C.Size = new System.Drawing.Size(29, 16);
            this.radioButton_C.TabIndex = 0;
            this.radioButton_C.TabStop = true;
            this.radioButton_C.Text = "C";
            this.radioButton_C.UseVisualStyleBackColor = true;
            this.radioButton_C.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // textBox_local_ip
            // 
            this.textBox_local_ip.Location = new System.Drawing.Point(6, 17);
            this.textBox_local_ip.Name = "textBox_local_ip";
            this.textBox_local_ip.Size = new System.Drawing.Size(100, 21);
            this.textBox_local_ip.TabIndex = 1;
            this.textBox_local_ip.TextChanged += new System.EventHandler(this.textBoxText_Change);
            // 
            // button_bind
            // 
            this.button_bind.Location = new System.Drawing.Point(167, 15);
            this.button_bind.Name = "button_bind";
            this.button_bind.Size = new System.Drawing.Size(75, 23);
            this.button_bind.TabIndex = 3;
            this.button_bind.Text = "绑定";
            this.button_bind.UseVisualStyleBackColor = true;
            this.button_bind.Click += new System.EventHandler(this.button_event);
            // 
            // textBox_local_port
            // 
            this.textBox_local_port.Location = new System.Drawing.Point(112, 17);
            this.textBox_local_port.Name = "textBox_local_port";
            this.textBox_local_port.Size = new System.Drawing.Size(49, 21);
            this.textBox_local_port.TabIndex = 2;
            this.textBox_local_port.TextChanged += new System.EventHandler(this.textBoxText_Change);
            // 
            // groupBox_role_select
            // 
            this.groupBox_role_select.Controls.Add(this.panel_CorS);
            this.groupBox_role_select.Controls.Add(this.panel_tcp_or_udp);
            this.groupBox_role_select.Location = new System.Drawing.Point(6, 12);
            this.groupBox_role_select.Name = "groupBox_role_select";
            this.groupBox_role_select.Size = new System.Drawing.Size(109, 78);
            this.groupBox_role_select.TabIndex = 3;
            this.groupBox_role_select.TabStop = false;
            this.groupBox_role_select.Text = "选择";
            // 
            // groupBox_local
            // 
            this.groupBox_local.Controls.Add(this.label_local_info);
            this.groupBox_local.Controls.Add(this.textBox_local_ip);
            this.groupBox_local.Controls.Add(this.textBox_local_port);
            this.groupBox_local.Controls.Add(this.button_bind);
            this.groupBox_local.Enabled = false;
            this.groupBox_local.Location = new System.Drawing.Point(121, 12);
            this.groupBox_local.Name = "groupBox_local";
            this.groupBox_local.Size = new System.Drawing.Size(267, 78);
            this.groupBox_local.TabIndex = 4;
            this.groupBox_local.TabStop = false;
            this.groupBox_local.Text = "本地";
            // 
            // label_local_info
            // 
            this.label_local_info.AutoSize = true;
            this.label_local_info.Font = new System.Drawing.Font("楷体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label_local_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_local_info.Location = new System.Drawing.Point(9, 45);
            this.label_local_info.Name = "label_local_info";
            this.label_local_info.Size = new System.Drawing.Size(215, 22);
            this.label_local_info.TabIndex = 4;
            this.label_local_info.Text = "提示：ip\"0.0.0.0\"表示本地所有网卡\r\n      port\"0\"表示有系统随机提供端口";
            // 
            // groupBox_send
            // 
            this.groupBox_send.Controls.Add(this.groupBox_s_to_where);
            this.groupBox_send.Controls.Add(this.groupBox_s_contain);
            this.groupBox_send.Controls.Add(this.groupBox_s_t);
            this.groupBox_send.Enabled = false;
            this.groupBox_send.Location = new System.Drawing.Point(6, 96);
            this.groupBox_send.Name = "groupBox_send";
            this.groupBox_send.Size = new System.Drawing.Size(200, 290);
            this.groupBox_send.TabIndex = 5;
            this.groupBox_send.TabStop = false;
            this.groupBox_send.Text = "发送";
            // 
            // groupBox_s_to_where
            // 
            this.groupBox_s_to_where.Controls.Add(this.textBox_s_t_ip);
            this.groupBox_s_to_where.Controls.Add(this.button_s_t_con);
            this.groupBox_s_to_where.Controls.Add(this.textBox_s_t_port);
            this.groupBox_s_to_where.Controls.Add(this.button_s_t_send);
            this.groupBox_s_to_where.Location = new System.Drawing.Point(10, 199);
            this.groupBox_s_to_where.Name = "groupBox_s_to_where";
            this.groupBox_s_to_where.Size = new System.Drawing.Size(175, 82);
            this.groupBox_s_to_where.TabIndex = 4;
            this.groupBox_s_to_where.TabStop = false;
            this.groupBox_s_to_where.Text = "目的地址端口";
            // 
            // textBox_s_t_ip
            // 
            this.textBox_s_t_ip.Location = new System.Drawing.Point(6, 20);
            this.textBox_s_t_ip.Name = "textBox_s_t_ip";
            this.textBox_s_t_ip.Size = new System.Drawing.Size(100, 21);
            this.textBox_s_t_ip.TabIndex = 1;
            this.textBox_s_t_ip.TextChanged += new System.EventHandler(this.textBoxText_Change);
            // 
            // button_s_t_con
            // 
            this.button_s_t_con.Location = new System.Drawing.Point(6, 47);
            this.button_s_t_con.Name = "button_s_t_con";
            this.button_s_t_con.Size = new System.Drawing.Size(75, 23);
            this.button_s_t_con.TabIndex = 3;
            this.button_s_t_con.Text = "连接";
            this.button_s_t_con.UseVisualStyleBackColor = true;
            this.button_s_t_con.Click += new System.EventHandler(this.button_event);
            // 
            // textBox_s_t_port
            // 
            this.textBox_s_t_port.Location = new System.Drawing.Point(112, 20);
            this.textBox_s_t_port.Name = "textBox_s_t_port";
            this.textBox_s_t_port.Size = new System.Drawing.Size(49, 21);
            this.textBox_s_t_port.TabIndex = 2;
            this.textBox_s_t_port.Text = "123";
            this.textBox_s_t_port.TextChanged += new System.EventHandler(this.textBoxText_Change);
            // 
            // button_s_t_send
            // 
            this.button_s_t_send.Location = new System.Drawing.Point(87, 47);
            this.button_s_t_send.Name = "button_s_t_send";
            this.button_s_t_send.Size = new System.Drawing.Size(74, 23);
            this.button_s_t_send.TabIndex = 3;
            this.button_s_t_send.Text = "发送";
            this.button_s_t_send.UseVisualStyleBackColor = true;
            // 
            // groupBox_s_contain
            // 
            this.groupBox_s_contain.Controls.Add(this.textBox_s_contain);
            this.groupBox_s_contain.Enabled = false;
            this.groupBox_s_contain.Location = new System.Drawing.Point(10, 90);
            this.groupBox_s_contain.Name = "groupBox_s_contain";
            this.groupBox_s_contain.Size = new System.Drawing.Size(148, 103);
            this.groupBox_s_contain.TabIndex = 1;
            this.groupBox_s_contain.TabStop = false;
            this.groupBox_s_contain.Text = "类容";
            // 
            // textBox_s_contain
            // 
            this.textBox_s_contain.Location = new System.Drawing.Point(6, 20);
            this.textBox_s_contain.Multiline = true;
            this.textBox_s_contain.Name = "textBox_s_contain";
            this.textBox_s_contain.Size = new System.Drawing.Size(136, 77);
            this.textBox_s_contain.TabIndex = 1;
            // 
            // groupBox_s_t
            // 
            this.groupBox_s_t.Controls.Add(this.radioButton_s_t_hex);
            this.groupBox_s_t.Controls.Add(this.radioButton_s_t_bin);
            this.groupBox_s_t.Controls.Add(this.radioButton_s_t_text);
            this.groupBox_s_t.Controls.Add(this.radioButton_s_t_file);
            this.groupBox_s_t.Location = new System.Drawing.Point(10, 20);
            this.groupBox_s_t.Name = "groupBox_s_t";
            this.groupBox_s_t.Size = new System.Drawing.Size(123, 62);
            this.groupBox_s_t.TabIndex = 0;
            this.groupBox_s_t.TabStop = false;
            this.groupBox_s_t.Text = "类型";
            // 
            // radioButton_s_t_hex
            // 
            this.radioButton_s_t_hex.AutoSize = true;
            this.radioButton_s_t_hex.Location = new System.Drawing.Point(56, 35);
            this.radioButton_s_t_hex.Name = "radioButton_s_t_hex";
            this.radioButton_s_t_hex.Size = new System.Drawing.Size(59, 16);
            this.radioButton_s_t_hex.TabIndex = 0;
            this.radioButton_s_t_hex.TabStop = true;
            this.radioButton_s_t_hex.Text = "16进制";
            this.radioButton_s_t_hex.UseVisualStyleBackColor = true;
            this.radioButton_s_t_hex.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_s_t_bin
            // 
            this.radioButton_s_t_bin.AutoSize = true;
            this.radioButton_s_t_bin.Location = new System.Drawing.Point(56, 13);
            this.radioButton_s_t_bin.Name = "radioButton_s_t_bin";
            this.radioButton_s_t_bin.Size = new System.Drawing.Size(53, 16);
            this.radioButton_s_t_bin.TabIndex = 0;
            this.radioButton_s_t_bin.TabStop = true;
            this.radioButton_s_t_bin.Text = "2进制";
            this.radioButton_s_t_bin.UseVisualStyleBackColor = true;
            this.radioButton_s_t_bin.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_s_t_text
            // 
            this.radioButton_s_t_text.AutoSize = true;
            this.radioButton_s_t_text.Location = new System.Drawing.Point(9, 35);
            this.radioButton_s_t_text.Name = "radioButton_s_t_text";
            this.radioButton_s_t_text.Size = new System.Drawing.Size(47, 16);
            this.radioButton_s_t_text.TabIndex = 0;
            this.radioButton_s_t_text.TabStop = true;
            this.radioButton_s_t_text.Text = "文本";
            this.radioButton_s_t_text.UseVisualStyleBackColor = true;
            this.radioButton_s_t_text.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_s_t_file
            // 
            this.radioButton_s_t_file.AutoSize = true;
            this.radioButton_s_t_file.Location = new System.Drawing.Point(9, 13);
            this.radioButton_s_t_file.Name = "radioButton_s_t_file";
            this.radioButton_s_t_file.Size = new System.Drawing.Size(47, 16);
            this.radioButton_s_t_file.TabIndex = 0;
            this.radioButton_s_t_file.TabStop = true;
            this.radioButton_s_t_file.Text = "文件";
            this.radioButton_s_t_file.UseVisualStyleBackColor = true;
            this.radioButton_s_t_file.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // groupBox_recv
            // 
            this.groupBox_recv.Controls.Add(this.panel_back);
            this.groupBox_recv.Controls.Add(this.groupBox_r_t);
            this.groupBox_recv.Controls.Add(this.groupBox_r_dis);
            this.groupBox_recv.Enabled = false;
            this.groupBox_recv.Location = new System.Drawing.Point(212, 96);
            this.groupBox_recv.Name = "groupBox_recv";
            this.groupBox_recv.Size = new System.Drawing.Size(176, 416);
            this.groupBox_recv.TabIndex = 6;
            this.groupBox_recv.TabStop = false;
            this.groupBox_recv.Text = "接收";
            // 
            // panel_back
            // 
            this.panel_back.Controls.Add(this.checkBox_back);
            this.panel_back.Controls.Add(this.groupBox_b_t);
            this.panel_back.Controls.Add(this.groupBox_b_contain);
            this.panel_back.Location = new System.Drawing.Point(6, 199);
            this.panel_back.Name = "panel_back";
            this.panel_back.Size = new System.Drawing.Size(148, 205);
            this.panel_back.TabIndex = 2;
            // 
            // checkBox_back
            // 
            this.checkBox_back.AutoSize = true;
            this.checkBox_back.Location = new System.Drawing.Point(12, 3);
            this.checkBox_back.Name = "checkBox_back";
            this.checkBox_back.Size = new System.Drawing.Size(72, 16);
            this.checkBox_back.TabIndex = 0;
            this.checkBox_back.Text = "自动回传";
            this.checkBox_back.UseVisualStyleBackColor = true;
            this.checkBox_back.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox_b_t
            // 
            this.groupBox_b_t.Controls.Add(this.radioButton_b_t_recv);
            this.groupBox_b_t.Controls.Add(this.radioButton_b_t_hex);
            this.groupBox_b_t.Controls.Add(this.radioButton_b_t_bin);
            this.groupBox_b_t.Controls.Add(this.radioButton_b_t_text);
            this.groupBox_b_t.Controls.Add(this.radioButton_b_t_file);
            this.groupBox_b_t.Enabled = false;
            this.groupBox_b_t.Location = new System.Drawing.Point(3, 20);
            this.groupBox_b_t.Name = "groupBox_b_t";
            this.groupBox_b_t.Size = new System.Drawing.Size(123, 81);
            this.groupBox_b_t.TabIndex = 0;
            this.groupBox_b_t.TabStop = false;
            this.groupBox_b_t.Text = "类型";
            // 
            // radioButton_b_t_recv
            // 
            this.radioButton_b_t_recv.AutoSize = true;
            this.radioButton_b_t_recv.Location = new System.Drawing.Point(9, 55);
            this.radioButton_b_t_recv.Name = "radioButton_b_t_recv";
            this.radioButton_b_t_recv.Size = new System.Drawing.Size(83, 16);
            this.radioButton_b_t_recv.TabIndex = 0;
            this.radioButton_b_t_recv.TabStop = true;
            this.radioButton_b_t_recv.Text = "接收的数据";
            this.radioButton_b_t_recv.UseVisualStyleBackColor = true;
            this.radioButton_b_t_recv.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_b_t_hex
            // 
            this.radioButton_b_t_hex.AutoSize = true;
            this.radioButton_b_t_hex.Location = new System.Drawing.Point(56, 35);
            this.radioButton_b_t_hex.Name = "radioButton_b_t_hex";
            this.radioButton_b_t_hex.Size = new System.Drawing.Size(59, 16);
            this.radioButton_b_t_hex.TabIndex = 0;
            this.radioButton_b_t_hex.TabStop = true;
            this.radioButton_b_t_hex.Text = "16进制";
            this.radioButton_b_t_hex.UseVisualStyleBackColor = true;
            this.radioButton_b_t_hex.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_b_t_bin
            // 
            this.radioButton_b_t_bin.AutoSize = true;
            this.radioButton_b_t_bin.Location = new System.Drawing.Point(56, 13);
            this.radioButton_b_t_bin.Name = "radioButton_b_t_bin";
            this.radioButton_b_t_bin.Size = new System.Drawing.Size(53, 16);
            this.radioButton_b_t_bin.TabIndex = 0;
            this.radioButton_b_t_bin.TabStop = true;
            this.radioButton_b_t_bin.Text = "2进制";
            this.radioButton_b_t_bin.UseVisualStyleBackColor = true;
            this.radioButton_b_t_bin.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_b_t_text
            // 
            this.radioButton_b_t_text.AutoSize = true;
            this.radioButton_b_t_text.Location = new System.Drawing.Point(9, 35);
            this.radioButton_b_t_text.Name = "radioButton_b_t_text";
            this.radioButton_b_t_text.Size = new System.Drawing.Size(47, 16);
            this.radioButton_b_t_text.TabIndex = 0;
            this.radioButton_b_t_text.TabStop = true;
            this.radioButton_b_t_text.Text = "文本";
            this.radioButton_b_t_text.UseVisualStyleBackColor = true;
            this.radioButton_b_t_text.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_b_t_file
            // 
            this.radioButton_b_t_file.AutoSize = true;
            this.radioButton_b_t_file.Location = new System.Drawing.Point(9, 13);
            this.radioButton_b_t_file.Name = "radioButton_b_t_file";
            this.radioButton_b_t_file.Size = new System.Drawing.Size(47, 16);
            this.radioButton_b_t_file.TabIndex = 0;
            this.radioButton_b_t_file.TabStop = true;
            this.radioButton_b_t_file.Text = "文件";
            this.radioButton_b_t_file.UseVisualStyleBackColor = true;
            this.radioButton_b_t_file.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // groupBox_b_contain
            // 
            this.groupBox_b_contain.Controls.Add(this.textBox_b_contain);
            this.groupBox_b_contain.Enabled = false;
            this.groupBox_b_contain.Location = new System.Drawing.Point(6, 107);
            this.groupBox_b_contain.Name = "groupBox_b_contain";
            this.groupBox_b_contain.Size = new System.Drawing.Size(148, 95);
            this.groupBox_b_contain.TabIndex = 1;
            this.groupBox_b_contain.TabStop = false;
            this.groupBox_b_contain.Text = "类容";
            // 
            // textBox_b_contain
            // 
            this.textBox_b_contain.Location = new System.Drawing.Point(6, 20);
            this.textBox_b_contain.Multiline = true;
            this.textBox_b_contain.Name = "textBox_b_contain";
            this.textBox_b_contain.Size = new System.Drawing.Size(130, 69);
            this.textBox_b_contain.TabIndex = 1;
            // 
            // groupBox_r_t
            // 
            this.groupBox_r_t.Controls.Add(this.radioButton_r_t_hex);
            this.groupBox_r_t.Controls.Add(this.radioButton_r_t_bin);
            this.groupBox_r_t.Controls.Add(this.radioButton_r_t_text);
            this.groupBox_r_t.Controls.Add(this.radioButton_r_t_file);
            this.groupBox_r_t.Location = new System.Drawing.Point(6, 20);
            this.groupBox_r_t.Name = "groupBox_r_t";
            this.groupBox_r_t.Size = new System.Drawing.Size(123, 62);
            this.groupBox_r_t.TabIndex = 0;
            this.groupBox_r_t.TabStop = false;
            this.groupBox_r_t.Text = "类型";
            // 
            // radioButton_r_t_hex
            // 
            this.radioButton_r_t_hex.AutoSize = true;
            this.radioButton_r_t_hex.Location = new System.Drawing.Point(56, 35);
            this.radioButton_r_t_hex.Name = "radioButton_r_t_hex";
            this.radioButton_r_t_hex.Size = new System.Drawing.Size(59, 16);
            this.radioButton_r_t_hex.TabIndex = 0;
            this.radioButton_r_t_hex.TabStop = true;
            this.radioButton_r_t_hex.Text = "16进制";
            this.radioButton_r_t_hex.UseVisualStyleBackColor = true;
            this.radioButton_r_t_hex.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_r_t_bin
            // 
            this.radioButton_r_t_bin.AutoSize = true;
            this.radioButton_r_t_bin.Location = new System.Drawing.Point(56, 13);
            this.radioButton_r_t_bin.Name = "radioButton_r_t_bin";
            this.radioButton_r_t_bin.Size = new System.Drawing.Size(53, 16);
            this.radioButton_r_t_bin.TabIndex = 0;
            this.radioButton_r_t_bin.TabStop = true;
            this.radioButton_r_t_bin.Text = "2进制";
            this.radioButton_r_t_bin.UseVisualStyleBackColor = true;
            this.radioButton_r_t_bin.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_r_t_text
            // 
            this.radioButton_r_t_text.AutoSize = true;
            this.radioButton_r_t_text.Location = new System.Drawing.Point(9, 35);
            this.radioButton_r_t_text.Name = "radioButton_r_t_text";
            this.radioButton_r_t_text.Size = new System.Drawing.Size(47, 16);
            this.radioButton_r_t_text.TabIndex = 0;
            this.radioButton_r_t_text.TabStop = true;
            this.radioButton_r_t_text.Text = "文本";
            this.radioButton_r_t_text.UseVisualStyleBackColor = true;
            this.radioButton_r_t_text.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // radioButton_r_t_file
            // 
            this.radioButton_r_t_file.AutoSize = true;
            this.radioButton_r_t_file.Location = new System.Drawing.Point(9, 13);
            this.radioButton_r_t_file.Name = "radioButton_r_t_file";
            this.radioButton_r_t_file.Size = new System.Drawing.Size(47, 16);
            this.radioButton_r_t_file.TabIndex = 0;
            this.radioButton_r_t_file.TabStop = true;
            this.radioButton_r_t_file.Text = "文件";
            this.radioButton_r_t_file.UseVisualStyleBackColor = true;
            this.radioButton_r_t_file.CheckedChanged += new System.EventHandler(this.radio_event);
            // 
            // groupBox_r_dis
            // 
            this.groupBox_r_dis.Controls.Add(this.textBox_r_dis);
            this.groupBox_r_dis.Enabled = false;
            this.groupBox_r_dis.Location = new System.Drawing.Point(6, 90);
            this.groupBox_r_dis.Name = "groupBox_r_dis";
            this.groupBox_r_dis.Size = new System.Drawing.Size(148, 103);
            this.groupBox_r_dis.TabIndex = 1;
            this.groupBox_r_dis.TabStop = false;
            this.groupBox_r_dis.Text = "接收类容";
            // 
            // textBox_r_dis
            // 
            this.textBox_r_dis.Location = new System.Drawing.Point(6, 20);
            this.textBox_r_dis.Multiline = true;
            this.textBox_r_dis.Name = "textBox_r_dis";
            this.textBox_r_dis.ReadOnly = true;
            this.textBox_r_dis.Size = new System.Drawing.Size(136, 77);
            this.textBox_r_dis.TabIndex = 1;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 516);
            this.Controls.Add(this.groupBox_recv);
            this.Controls.Add(this.groupBox_send);
            this.Controls.Add(this.groupBox_local);
            this.Controls.Add(this.groupBox_role_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainform";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel_tcp_or_udp.ResumeLayout(false);
            this.panel_tcp_or_udp.PerformLayout();
            this.panel_CorS.ResumeLayout(false);
            this.panel_CorS.PerformLayout();
            this.groupBox_role_select.ResumeLayout(false);
            this.groupBox_local.ResumeLayout(false);
            this.groupBox_local.PerformLayout();
            this.groupBox_send.ResumeLayout(false);
            this.groupBox_s_to_where.ResumeLayout(false);
            this.groupBox_s_to_where.PerformLayout();
            this.groupBox_s_contain.ResumeLayout(false);
            this.groupBox_s_contain.PerformLayout();
            this.groupBox_s_t.ResumeLayout(false);
            this.groupBox_s_t.PerformLayout();
            this.groupBox_recv.ResumeLayout(false);
            this.panel_back.ResumeLayout(false);
            this.panel_back.PerformLayout();
            this.groupBox_b_t.ResumeLayout(false);
            this.groupBox_b_t.PerformLayout();
            this.groupBox_b_contain.ResumeLayout(false);
            this.groupBox_b_contain.PerformLayout();
            this.groupBox_r_t.ResumeLayout(false);
            this.groupBox_r_t.PerformLayout();
            this.groupBox_r_dis.ResumeLayout(false);
            this.groupBox_r_dis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tcp_or_udp;
        private System.Windows.Forms.RadioButton radioButton_tcp;
        private System.Windows.Forms.RadioButton radioButton_udp;
        private System.Windows.Forms.Panel panel_CorS;
        private System.Windows.Forms.RadioButton radioButton_S;
        private System.Windows.Forms.RadioButton radioButton_C;
        private System.Windows.Forms.TextBox textBox_local_ip;
        private System.Windows.Forms.Button button_bind;
        private System.Windows.Forms.TextBox textBox_local_port;
        private System.Windows.Forms.GroupBox groupBox_role_select;
        private System.Windows.Forms.GroupBox groupBox_local;
        private System.Windows.Forms.GroupBox groupBox_send;
        private System.Windows.Forms.TextBox textBox_s_t_ip;
        private System.Windows.Forms.TextBox textBox_s_t_port;
        private System.Windows.Forms.GroupBox groupBox_s_contain;
        private System.Windows.Forms.TextBox textBox_s_contain;
        private System.Windows.Forms.Button button_s_t_con;
        private System.Windows.Forms.GroupBox groupBox_s_t;
        private System.Windows.Forms.RadioButton radioButton_s_t_hex;
        private System.Windows.Forms.RadioButton radioButton_s_t_bin;
        private System.Windows.Forms.RadioButton radioButton_s_t_text;
        private System.Windows.Forms.RadioButton radioButton_s_t_file;
        private System.Windows.Forms.GroupBox groupBox_recv;
        private System.Windows.Forms.GroupBox groupBox_s_to_where;
        private System.Windows.Forms.Button button_s_t_send;
        private System.Windows.Forms.Panel panel_back;
        private System.Windows.Forms.CheckBox checkBox_back;
        private System.Windows.Forms.GroupBox groupBox_b_t;
        private System.Windows.Forms.RadioButton radioButton_b_t_hex;
        private System.Windows.Forms.RadioButton radioButton_b_t_bin;
        private System.Windows.Forms.RadioButton radioButton_b_t_text;
        private System.Windows.Forms.RadioButton radioButton_b_t_file;
        private System.Windows.Forms.GroupBox groupBox_b_contain;
        private System.Windows.Forms.TextBox textBox_b_contain;
        private System.Windows.Forms.GroupBox groupBox_r_t;
        private System.Windows.Forms.RadioButton radioButton_r_t_hex;
        private System.Windows.Forms.RadioButton radioButton_r_t_bin;
        private System.Windows.Forms.RadioButton radioButton_r_t_text;
        private System.Windows.Forms.RadioButton radioButton_r_t_file;
        private System.Windows.Forms.GroupBox groupBox_r_dis;
        private System.Windows.Forms.TextBox textBox_r_dis;
        private System.Windows.Forms.RadioButton radioButton_b_t_recv;
        private System.Windows.Forms.Label label_local_info;
    }
}

