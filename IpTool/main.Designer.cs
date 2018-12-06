namespace IpTool
{
    partial class main
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
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_udp = new System.Windows.Forms.TabPage();
            this.tabPage_tcp = new System.Windows.Forms.TabPage();
            this.tabControl_udp = new System.Windows.Forms.TabControl();
            this.tabPage_udp_send = new System.Windows.Forms.TabPage();
            this.tabPage_udp_recv = new System.Windows.Forms.TabPage();
            this.str_ip_udp_sendto = new System.Windows.Forms.TextBox();
            this.str_port_udp_sendto = new System.Windows.Forms.TextBox();
            this.Btn_select_file = new System.Windows.Forms.Button();
            this.udp_send_file_yes_or = new System.Windows.Forms.CheckBox();
            this.str_path = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_udp_send_send = new System.Windows.Forms.Button();
            this.tabControl_main.SuspendLayout();
            this.tabPage_udp.SuspendLayout();
            this.tabControl_udp.SuspendLayout();
            this.tabPage_udp_send.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_udp);
            this.tabControl_main.Controls.Add(this.tabPage_tcp);
            this.tabControl_main.Location = new System.Drawing.Point(1, -1);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(353, 355);
            this.tabControl_main.TabIndex = 0;
            // 
            // tabPage_udp
            // 
            this.tabPage_udp.Controls.Add(this.tabControl_udp);
            this.tabPage_udp.Location = new System.Drawing.Point(4, 22);
            this.tabPage_udp.Name = "tabPage_udp";
            this.tabPage_udp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_udp.Size = new System.Drawing.Size(345, 329);
            this.tabPage_udp.TabIndex = 0;
            this.tabPage_udp.Text = "UDP";
            this.tabPage_udp.UseVisualStyleBackColor = true;
            // 
            // tabPage_tcp
            // 
            this.tabPage_tcp.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tcp.Name = "tabPage_tcp";
            this.tabPage_tcp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tcp.Size = new System.Drawing.Size(345, 329);
            this.tabPage_tcp.TabIndex = 1;
            this.tabPage_tcp.Text = "TCP";
            this.tabPage_tcp.UseVisualStyleBackColor = true;
            // 
            // tabControl_udp
            // 
            this.tabControl_udp.Controls.Add(this.tabPage_udp_send);
            this.tabControl_udp.Controls.Add(this.tabPage_udp_recv);
            this.tabControl_udp.Location = new System.Drawing.Point(0, 0);
            this.tabControl_udp.Name = "tabControl_udp";
            this.tabControl_udp.SelectedIndex = 0;
            this.tabControl_udp.Size = new System.Drawing.Size(345, 323);
            this.tabControl_udp.TabIndex = 0;
            // 
            // tabPage_udp_send
            // 
            this.tabPage_udp_send.Controls.Add(this.Btn_udp_send_send);
            this.tabPage_udp_send.Controls.Add(this.panel1);
            this.tabPage_udp_send.Controls.Add(this.str_port_udp_sendto);
            this.tabPage_udp_send.Controls.Add(this.str_ip_udp_sendto);
            this.tabPage_udp_send.Location = new System.Drawing.Point(4, 22);
            this.tabPage_udp_send.Name = "tabPage_udp_send";
            this.tabPage_udp_send.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_udp_send.Size = new System.Drawing.Size(337, 297);
            this.tabPage_udp_send.TabIndex = 0;
            this.tabPage_udp_send.Text = "发送";
            this.tabPage_udp_send.UseVisualStyleBackColor = true;
            // 
            // tabPage_udp_recv
            // 
            this.tabPage_udp_recv.Location = new System.Drawing.Point(4, 22);
            this.tabPage_udp_recv.Name = "tabPage_udp_recv";
            this.tabPage_udp_recv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_udp_recv.Size = new System.Drawing.Size(328, 288);
            this.tabPage_udp_recv.TabIndex = 1;
            this.tabPage_udp_recv.Text = "接收";
            this.tabPage_udp_recv.UseVisualStyleBackColor = true;
            // 
            // str_ip_udp_sendto
            // 
            this.str_ip_udp_sendto.Location = new System.Drawing.Point(6, 6);
            this.str_ip_udp_sendto.Name = "str_ip_udp_sendto";
            this.str_ip_udp_sendto.Size = new System.Drawing.Size(106, 21);
            this.str_ip_udp_sendto.TabIndex = 0;
            this.str_ip_udp_sendto.Text = "目标ip";
            this.str_ip_udp_sendto.Enter += new System.EventHandler(this.str_ip_udp_sendto_Enter);
            // 
            // str_port_udp_sendto
            // 
            this.str_port_udp_sendto.Location = new System.Drawing.Point(118, 6);
            this.str_port_udp_sendto.Name = "str_port_udp_sendto";
            this.str_port_udp_sendto.Size = new System.Drawing.Size(43, 21);
            this.str_port_udp_sendto.TabIndex = 1;
            this.str_port_udp_sendto.Text = "port";
            // 
            // Btn_select_file
            // 
            this.Btn_select_file.Enabled = false;
            this.Btn_select_file.Location = new System.Drawing.Point(75, 3);
            this.Btn_select_file.Name = "Btn_select_file";
            this.Btn_select_file.Size = new System.Drawing.Size(89, 23);
            this.Btn_select_file.TabIndex = 3;
            this.Btn_select_file.Text = "来自文件";
            this.Btn_select_file.UseVisualStyleBackColor = true;
            this.Btn_select_file.EnabledChanged += new System.EventHandler(this.Btn_select_file_EnabledChanged);
            this.Btn_select_file.Click += new System.EventHandler(this.Btn_select_file_Click);
            // 
            // udp_send_file_yes_or
            // 
            this.udp_send_file_yes_or.AutoSize = true;
            this.udp_send_file_yes_or.Location = new System.Drawing.Point(54, 8);
            this.udp_send_file_yes_or.Name = "udp_send_file_yes_or";
            this.udp_send_file_yes_or.Size = new System.Drawing.Size(15, 14);
            this.udp_send_file_yes_or.TabIndex = 4;
            this.udp_send_file_yes_or.UseVisualStyleBackColor = true;
            this.udp_send_file_yes_or.CheckedChanged += new System.EventHandler(this.file_yes_or_CheckedChanged);
            // 
            // str_path
            // 
            this.str_path.Enabled = false;
            this.str_path.Location = new System.Drawing.Point(3, 29);
            this.str_path.Name = "str_path";
            this.str_path.Size = new System.Drawing.Size(161, 21);
            this.str_path.TabIndex = 5;
            this.str_path.Text = "路径";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.str_path);
            this.panel1.Controls.Add(this.Btn_select_file);
            this.panel1.Controls.Add(this.udp_send_file_yes_or);
            this.panel1.Location = new System.Drawing.Point(167, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 56);
            this.panel1.TabIndex = 6;
            // 
            // Btn_udp_send_send
            // 
            this.Btn_udp_send_send.Location = new System.Drawing.Point(6, 30);
            this.Btn_udp_send_send.Name = "Btn_udp_send_send";
            this.Btn_udp_send_send.Size = new System.Drawing.Size(155, 23);
            this.Btn_udp_send_send.TabIndex = 7;
            this.Btn_udp_send_send.Text = "发送";
            this.Btn_udp_send_send.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 353);
            this.Controls.Add(this.tabControl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "main";
            this.Text = "socket调试工具";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_udp.ResumeLayout(false);
            this.tabControl_udp.ResumeLayout(false);
            this.tabPage_udp_send.ResumeLayout(false);
            this.tabPage_udp_send.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_udp;
        private System.Windows.Forms.TabControl tabControl_udp;
        private System.Windows.Forms.TabPage tabPage_udp_send;
        private System.Windows.Forms.TabPage tabPage_udp_recv;
        private System.Windows.Forms.TabPage tabPage_tcp;
        private System.Windows.Forms.TextBox str_ip_udp_sendto;
        private System.Windows.Forms.TextBox str_port_udp_sendto;
        private System.Windows.Forms.Button Btn_select_file;
        private System.Windows.Forms.CheckBox udp_send_file_yes_or;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox str_path;
        private System.Windows.Forms.Button Btn_udp_send_send;
    }
}

