namespace TestClientSocket
{
    partial class Frm_Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_SendFile = new System.Windows.Forms.Button();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Btn_DisConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Txt_IP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Port = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.RC_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Txt_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Txt_Messagesssss = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.RightClick.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "User name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_SendFile);
            this.panel2.Controls.Add(this.Txt_Username);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(266, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 83);
            this.panel2.TabIndex = 6;
            // 
            // Btn_SendFile
            // 
            this.Btn_SendFile.Location = new System.Drawing.Point(12, 48);
            this.Btn_SendFile.Name = "Btn_SendFile";
            this.Btn_SendFile.Size = new System.Drawing.Size(100, 26);
            this.Btn_SendFile.TabIndex = 8;
            this.Btn_SendFile.Text = "SendFile";
            this.Btn_SendFile.UseVisualStyleBackColor = true;
            this.Btn_SendFile.Click += new System.EventHandler(this.Btn_SendFile_Click);
            // 
            // Txt_Username
            // 
            this.Txt_Username.Location = new System.Drawing.Point(101, 19);
            this.Txt_Username.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(79, 23);
            this.Txt_Username.TabIndex = 7;
            this.Txt_Username.Text = "Client";
            // 
            // Btn_DisConnect
            // 
            this.Btn_DisConnect.Location = new System.Drawing.Point(137, 45);
            this.Btn_DisConnect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_DisConnect.Name = "Btn_DisConnect";
            this.Btn_DisConnect.Size = new System.Drawing.Size(118, 34);
            this.Btn_DisConnect.TabIndex = 5;
            this.Btn_DisConnect.Text = "Disconnect";
            this.Btn_DisConnect.UseVisualStyleBackColor = true;
            this.Btn_DisConnect.Click += new System.EventHandler(this.Btn_DisConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(137, 10);
            this.Btn_Connect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(118, 34);
            this.Btn_Connect.TabIndex = 0;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Txt_IP
            // 
            this.Txt_IP.Location = new System.Drawing.Point(46, 11);
            this.Txt_IP.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Txt_IP.Name = "Txt_IP";
            this.Txt_IP.Size = new System.Drawing.Size(88, 23);
            this.Txt_IP.TabIndex = 1;
            this.Txt_IP.Text = "127.0.0.1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_DisConnect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Btn_Connect);
            this.panel1.Controls.Add(this.Txt_IP);
            this.panel1.Controls.Add(this.Txt_Port);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 83);
            this.panel1.TabIndex = 5;
            // 
            // Txt_Port
            // 
            this.Txt_Port.Location = new System.Drawing.Point(46, 51);
            this.Txt_Port.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Txt_Port.Name = "Txt_Port";
            this.Txt_Port.Size = new System.Drawing.Size(88, 23);
            this.Txt_Port.TabIndex = 2;
            this.Txt_Port.Text = "8888";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(6, 21);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 83);
            this.panel5.TabIndex = 13;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Send.Location = new System.Drawing.Point(351, 0);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(108, 58);
            this.Btn_Send.TabIndex = 7;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // RC_SelectAll
            // 
            this.RC_SelectAll.Name = "RC_SelectAll";
            this.RC_SelectAll.Size = new System.Drawing.Size(122, 22);
            this.RC_SelectAll.Text = "Select All";
            // 
            // RC_Clear
            // 
            this.RC_Clear.Name = "RC_Clear";
            this.RC_Clear.Size = new System.Drawing.Size(122, 22);
            this.RC_Clear.Text = "Clear";
            // 
            // RC_Paste
            // 
            this.RC_Paste.Name = "RC_Paste";
            this.RC_Paste.Size = new System.Drawing.Size(122, 22);
            this.RC_Paste.Text = "Paste";
            // 
            // RC_Copy
            // 
            this.RC_Copy.Name = "RC_Copy";
            this.RC_Copy.Size = new System.Drawing.Size(122, 22);
            this.RC_Copy.Text = "Copy";
            // 
            // RC_Cut
            // 
            this.RC_Cut.Name = "RC_Cut";
            this.RC_Cut.Size = new System.Drawing.Size(122, 22);
            this.RC_Cut.Text = "Cut";
            // 
            // RightClick
            // 
            this.RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RC_Cut,
            this.RC_Copy,
            this.RC_Paste,
            this.RC_Clear,
            this.RC_SelectAll});
            this.RightClick.Name = "RightClick";
            this.RightClick.Size = new System.Drawing.Size(123, 114);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(459, 94);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Txt_Messagesssss);
            this.panel3.Controls.Add(this.Btn_Send);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 58);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 104);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 152);
            this.panel4.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(471, 261);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Txt_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 261);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(471, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Txt_Status
            // 
            this.Txt_Status.AutoToolTip = true;
            this.Txt_Status.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.Txt_Status.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.Txt_Status.DoubleClickEnabled = true;
            this.Txt_Status.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Txt_Status.LinkVisited = true;
            this.Txt_Status.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.Txt_Status.RightToLeftAutoMirrorImage = true;
            this.Txt_Status.Size = new System.Drawing.Size(456, 17);
            this.Txt_Status.Spring = true;
            this.Txt_Status.Text = "None";
            this.Txt_Status.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Txt_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Txt_Messagessss
            // 
            this.Txt_Messagesssss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Messagesssss.Location = new System.Drawing.Point(0, 0);
            this.Txt_Messagesssss.Multiline = true;
            this.Txt_Messagesssss.Name = "Txt_Messagesssss";
            this.Txt_Messagesssss.Size = new System.Drawing.Size(351, 58);
            this.Txt_Messagesssss.TabIndex = 13;
            // 
            // Frm_Clients
            // 
            this.AcceptButton = this.Btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 283);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(487, 322);
            this.Name = "Frm_Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.RightClick.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.Button Btn_DisConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.TextBox Txt_IP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_Port;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.ToolStripMenuItem RC_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem RC_Clear;
        private System.Windows.Forms.ToolStripMenuItem RC_Paste;
        private System.Windows.Forms.ToolStripMenuItem RC_Copy;
        private System.Windows.Forms.ToolStripMenuItem RC_Cut;
        private System.Windows.Forms.ContextMenuStrip RightClick;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Txt_Status;
        private System.Windows.Forms.Button Btn_SendFile;
        private System.Windows.Forms.TextBox Txt_Messagesssss;
    }
}

