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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_tcp = new System.Windows.Forms.RadioButton();
            this.radioButton_udp = new System.Windows.Forms.RadioButton();
            this.panel_CorS = new System.Windows.Forms.Panel();
            this.radioButton_S = new System.Windows.Forms.RadioButton();
            this.radioButton_C = new System.Windows.Forms.RadioButton();
            this.textBox_local_ip = new System.Windows.Forms.TextBox();
            this.button_open = new System.Windows.Forms.Button();
            this.textBox_local_port = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_local = new System.Windows.Forms.GroupBox();
            this.groupBox_send = new System.Windows.Forms.GroupBox();
            this.groupBox_recv = new System.Windows.Forms.GroupBox();
            this.groupBox_s_t = new System.Windows.Forms.GroupBox();
            this.radioButton_s_t_file = new System.Windows.Forms.RadioButton();
            this.radioButton_s_t_text = new System.Windows.Forms.RadioButton();
            this.radioButton_s_t_bin = new System.Windows.Forms.RadioButton();
            this.radioButton_s_t_hex = new System.Windows.Forms.RadioButton();
            this.groupBox_s_contain = new System.Windows.Forms.GroupBox();
            this.textBox_s_contain = new System.Windows.Forms.TextBox();
            this.button_s_t_con = new System.Windows.Forms.Button();
            this.textBox_s_t_port = new System.Windows.Forms.TextBox();
            this.textBox_s_t_ip = new System.Windows.Forms.TextBox();
            this.button_s_t_send = new System.Windows.Forms.Button();
            this.groupBox_s_to_where = new System.Windows.Forms.GroupBox();
            this.groupBox_r_t = new System.Windows.Forms.GroupBox();
            this.radioButton_r_t_hex = new System.Windows.Forms.RadioButton();
            this.radioButton_r_t_bin = new System.Windows.Forms.RadioButton();
            this.radioButton_r_t_text = new System.Windows.Forms.RadioButton();
            this.radioButton_r_t_file = new System.Windows.Forms.RadioButton();
            this.groupBox_r_dis = new System.Windows.Forms.GroupBox();
            this.textBox_r_dis = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox_back = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioButton_b_t_hex = new System.Windows.Forms.RadioButton();
            this.radioButton_b_t_bin = new System.Windows.Forms.RadioButton();
            this.radioButton_b_t_text = new System.Windows.Forms.RadioButton();
            this.radioButton_b_t_file = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton_b_t_recv = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel_CorS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_local.SuspendLayout();
            this.groupBox_send.SuspendLayout();
            this.groupBox_recv.SuspendLayout();
            this.groupBox_s_t.SuspendLayout();
            this.groupBox_s_contain.SuspendLayout();
            this.groupBox_s_to_where.SuspendLayout();
            this.groupBox_r_t.SuspendLayout();
            this.groupBox_r_dis.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_tcp);
            this.panel1.Controls.Add(this.radioButton_udp);
            this.panel1.Location = new System.Drawing.Point(7, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 45);
            this.panel1.TabIndex = 0;
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
            this.radioButton_udp.CheckedChanged += new System.EventHandler(this.radioButton_udp_CheckedChanged_1);
            // 
            // panel_CorS
            // 
            this.panel_CorS.Controls.Add(this.radioButton_S);
            this.panel_CorS.Controls.Add(this.radioButton_C);
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
            // 
            // textBox_local_ip
            // 
            this.textBox_local_ip.Location = new System.Drawing.Point(6, 17);
            this.textBox_local_ip.Name = "textBox_local_ip";
            this.textBox_local_ip.Size = new System.Drawing.Size(100, 21);
            this.textBox_local_ip.TabIndex = 1;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(167, 15);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "打开";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // textBox_local_port
            // 
            this.textBox_local_port.Location = new System.Drawing.Point(112, 17);
            this.textBox_local_port.Name = "textBox_local_port";
            this.textBox_local_port.Size = new System.Drawing.Size(49, 21);
            this.textBox_local_port.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_CorS);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择";
            // 
            // groupBox_local
            // 
            this.groupBox_local.Controls.Add(this.textBox_local_ip);
            this.groupBox_local.Controls.Add(this.textBox_local_port);
            this.groupBox_local.Controls.Add(this.button_open);
            this.groupBox_local.Location = new System.Drawing.Point(121, 12);
            this.groupBox_local.Name = "groupBox_local";
            this.groupBox_local.Size = new System.Drawing.Size(267, 78);
            this.groupBox_local.TabIndex = 4;
            this.groupBox_local.TabStop = false;
            this.groupBox_local.Text = "本地";
            // 
            // groupBox_send
            // 
            this.groupBox_send.Controls.Add(this.groupBox_s_to_where);
            this.groupBox_send.Controls.Add(this.groupBox_s_contain);
            this.groupBox_send.Controls.Add(this.groupBox_s_t);
            this.groupBox_send.Location = new System.Drawing.Point(6, 96);
            this.groupBox_send.Name = "groupBox_send";
            this.groupBox_send.Size = new System.Drawing.Size(200, 290);
            this.groupBox_send.TabIndex = 5;
            this.groupBox_send.TabStop = false;
            this.groupBox_send.Text = "发送";
            // 
            // groupBox_recv
            // 
            this.groupBox_recv.Controls.Add(this.panel3);
            this.groupBox_recv.Controls.Add(this.groupBox_r_t);
            this.groupBox_recv.Controls.Add(this.groupBox_r_dis);
            this.groupBox_recv.Location = new System.Drawing.Point(212, 96);
            this.groupBox_recv.Name = "groupBox_recv";
            this.groupBox_recv.Size = new System.Drawing.Size(176, 416);
            this.groupBox_recv.TabIndex = 6;
            this.groupBox_recv.TabStop = false;
            this.groupBox_recv.Text = "接收";
            // 
            // groupBox_s_t
            // 
            this.groupBox_s_t.Controls.Add(this.radioButton_s_t_hex);
            this.groupBox_s_t.Controls.Add(this.radioButton_s_t_bin);
            this.groupBox_s_t.Controls.Add(this.radioButton_s_t_text);
            this.groupBox_s_t.Controls.Add(this.radioButton_s_t_file);
            this.groupBox_s_t.Enabled = false;
            this.groupBox_s_t.Location = new System.Drawing.Point(10, 20);
            this.groupBox_s_t.Name = "groupBox_s_t";
            this.groupBox_s_t.Size = new System.Drawing.Size(123, 62);
            this.groupBox_s_t.TabIndex = 0;
            this.groupBox_s_t.TabStop = false;
            this.groupBox_s_t.Text = "类型";
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
            // button_s_t_con
            // 
            this.button_s_t_con.Location = new System.Drawing.Point(6, 47);
            this.button_s_t_con.Name = "button_s_t_con";
            this.button_s_t_con.Size = new System.Drawing.Size(75, 23);
            this.button_s_t_con.TabIndex = 3;
            this.button_s_t_con.UseVisualStyleBackColor = true;
            // 
            // textBox_s_t_port
            // 
            this.textBox_s_t_port.Location = new System.Drawing.Point(112, 20);
            this.textBox_s_t_port.Name = "textBox_s_t_port";
            this.textBox_s_t_port.Size = new System.Drawing.Size(49, 21);
            this.textBox_s_t_port.TabIndex = 2;
            // 
            // textBox_s_t_ip
            // 
            this.textBox_s_t_ip.Location = new System.Drawing.Point(6, 20);
            this.textBox_s_t_ip.Name = "textBox_s_t_ip";
            this.textBox_s_t_ip.Size = new System.Drawing.Size(100, 21);
            this.textBox_s_t_ip.TabIndex = 1;
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
            // 
            // groupBox_r_dis
            // 
            this.groupBox_r_dis.Controls.Add(this.textBox_r_dis);
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
            this.textBox_r_dis.Size = new System.Drawing.Size(136, 77);
            this.textBox_r_dis.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox_back);
            this.panel3.Controls.Add(this.groupBox9);
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Location = new System.Drawing.Point(6, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 205);
            this.panel3.TabIndex = 2;
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
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radioButton_b_t_recv);
            this.groupBox9.Controls.Add(this.radioButton_b_t_hex);
            this.groupBox9.Controls.Add(this.radioButton_b_t_bin);
            this.groupBox9.Controls.Add(this.radioButton_b_t_text);
            this.groupBox9.Controls.Add(this.radioButton_b_t_file);
            this.groupBox9.Location = new System.Drawing.Point(3, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(123, 81);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "类型";
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
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox2);
            this.groupBox10.Location = new System.Drawing.Point(6, 107);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(148, 95);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "类容";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 69);
            this.textBox2.TabIndex = 1;
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
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 516);
            this.Controls.Add(this.groupBox_recv);
            this.Controls.Add(this.groupBox_send);
            this.Controls.Add(this.groupBox_local);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainform";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_CorS.ResumeLayout(false);
            this.panel_CorS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_local.ResumeLayout(false);
            this.groupBox_local.PerformLayout();
            this.groupBox_send.ResumeLayout(false);
            this.groupBox_recv.ResumeLayout(false);
            this.groupBox_s_t.ResumeLayout(false);
            this.groupBox_s_t.PerformLayout();
            this.groupBox_s_contain.ResumeLayout(false);
            this.groupBox_s_contain.PerformLayout();
            this.groupBox_s_to_where.ResumeLayout(false);
            this.groupBox_s_to_where.PerformLayout();
            this.groupBox_r_t.ResumeLayout(false);
            this.groupBox_r_t.PerformLayout();
            this.groupBox_r_dis.ResumeLayout(false);
            this.groupBox_r_dis.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_tcp;
        private System.Windows.Forms.RadioButton radioButton_udp;
        private System.Windows.Forms.Panel panel_CorS;
        private System.Windows.Forms.RadioButton radioButton_S;
        private System.Windows.Forms.RadioButton radioButton_C;
        private System.Windows.Forms.TextBox textBox_local_ip;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.TextBox textBox_local_port;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox_back;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton radioButton_b_t_hex;
        private System.Windows.Forms.RadioButton radioButton_b_t_bin;
        private System.Windows.Forms.RadioButton radioButton_b_t_text;
        private System.Windows.Forms.RadioButton radioButton_b_t_file;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox_r_t;
        private System.Windows.Forms.RadioButton radioButton_r_t_hex;
        private System.Windows.Forms.RadioButton radioButton_r_t_bin;
        private System.Windows.Forms.RadioButton radioButton_r_t_text;
        private System.Windows.Forms.RadioButton radioButton_r_t_file;
        private System.Windows.Forms.GroupBox groupBox_r_dis;
        private System.Windows.Forms.TextBox textBox_r_dis;
        private System.Windows.Forms.RadioButton radioButton_b_t_recv;
    }
}

