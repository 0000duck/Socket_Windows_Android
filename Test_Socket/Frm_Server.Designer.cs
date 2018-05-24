namespace Test_Socket
{
    partial class Frm_Server
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
            this.RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RC_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.RC_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Btn_SendFile = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Port = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Txt_Roomi = new System.Windows.Forms.RichTextBox();
            this.Txt_Back = new System.Windows.Forms.RichTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Txt_Message = new System.Windows.Forms.RichTextBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.cmdBold = new System.Windows.Forms.ToolStripButton();
            this.cmdItalic = new System.Windows.Forms.ToolStripButton();
            this.cmdUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lstFonts = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdColor = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RightClick.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
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
            // RC_Cut
            // 
            this.RC_Cut.Name = "RC_Cut";
            this.RC_Cut.Size = new System.Drawing.Size(122, 22);
            this.RC_Cut.Text = "Cut";
            // 
            // RC_Copy
            // 
            this.RC_Copy.Name = "RC_Copy";
            this.RC_Copy.Size = new System.Drawing.Size(122, 22);
            this.RC_Copy.Text = "Copy";
            // 
            // RC_Paste
            // 
            this.RC_Paste.Name = "RC_Paste";
            this.RC_Paste.Size = new System.Drawing.Size(122, 22);
            this.RC_Paste.Text = "Paste";
            // 
            // RC_Clear
            // 
            this.RC_Clear.Name = "RC_Clear";
            this.RC_Clear.Size = new System.Drawing.Size(122, 22);
            this.RC_Clear.Text = "Clear";
            // 
            // RC_SelectAll
            // 
            this.RC_SelectAll.Name = "RC_SelectAll";
            this.RC_SelectAll.Size = new System.Drawing.Size(122, 22);
            this.RC_SelectAll.Text = "Select All";
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
            this.Txt_Status.Size = new System.Drawing.Size(587, 17);
            this.Txt_Status.Spring = true;
            this.Txt_Status.Text = "None";
            this.Txt_Status.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Txt_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Txt_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Btn_SendFile
            // 
            this.Btn_SendFile.Location = new System.Drawing.Point(268, 6);
            this.Btn_SendFile.Name = "Btn_SendFile";
            this.Btn_SendFile.Size = new System.Drawing.Size(89, 23);
            this.Btn_SendFile.TabIndex = 5;
            this.Btn_SendFile.Text = "SendFile";
            this.Btn_SendFile.UseVisualStyleBackColor = true;
            this.Btn_SendFile.Click += new System.EventHandler(this.Btn_SendFile_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 25);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel6);
            this.splitContainer3.Size = new System.Drawing.Size(604, 344);
            this.splitContainer3.SplitterDistance = 170;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(170, 344);
            this.listBox2.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.splitContainer2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(428, 344);
            this.panel6.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel8);
            this.splitContainer2.Panel2MinSize = 35;
            this.splitContainer2.Size = new System.Drawing.Size(380, 277);
            this.splitContainer2.SplitterDistance = 196;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Txt_Roomi);
            this.splitContainer1.Panel2.Controls.Add(this.Txt_Back);
            this.splitContainer1.Size = new System.Drawing.Size(380, 196);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Btn_SendFile);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.Txt_Port);
            this.panel7.Controls.Add(this.Btn_Start);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(380, 32);
            this.panel7.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port:";
            // 
            // Txt_Port
            // 
            this.Txt_Port.Location = new System.Drawing.Point(53, 6);
            this.Txt_Port.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Port.Name = "Txt_Port";
            this.Txt_Port.Size = new System.Drawing.Size(79, 23);
            this.Txt_Port.TabIndex = 2;
            this.Txt_Port.Text = "5552";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(145, 4);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(112, 28);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Txt_Roomi
            // 
            this.Txt_Roomi.Location = new System.Drawing.Point(11, 3);
            this.Txt_Roomi.Name = "Txt_Roomi";
            this.Txt_Roomi.Size = new System.Drawing.Size(148, 142);
            this.Txt_Roomi.TabIndex = 0;
            this.Txt_Roomi.Text = "";
            // 
            // Txt_Back
            // 
            this.Txt_Back.Location = new System.Drawing.Point(174, 3);
            this.Txt_Back.Name = "Txt_Back";
            this.Txt_Back.Size = new System.Drawing.Size(194, 142);
            this.Txt_Back.TabIndex = 1;
            this.Txt_Back.Text = "";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.toolStrip2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(380, 76);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Txt_Message);
            this.panel9.Controls.Add(this.Btn_Send);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 25);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(380, 51);
            this.panel9.TabIndex = 0;
            // 
            // Txt_Message
            // 
            this.Txt_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Message.Location = new System.Drawing.Point(0, 0);
            this.Txt_Message.Name = "Txt_Message";
            this.Txt_Message.Size = new System.Drawing.Size(275, 51);
            this.Txt_Message.TabIndex = 2;
            this.Txt_Message.Text = "";
            this.Txt_Message.TextChanged += new System.EventHandler(this.Txt_Message_TextChanged);
            // 
            // Btn_Send
            // 
            this.Btn_Send.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Send.Location = new System.Drawing.Point(275, 0);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(105, 51);
            this.Btn_Send.TabIndex = 0;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdBold,
            this.cmdItalic,
            this.cmdUnderline,
            this.toolStripSeparator1,
            this.toolStripComboBox1,
            this.toolStripSeparator2,
            this.lstFonts,
            this.toolStripSeparator3,
            this.cmdColor});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(380, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // cmdBold
            // 
            this.cmdBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBold.Image = global::Test_Socket.Properties.Resources.black_bold_512;
            this.cmdBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBold.Name = "cmdBold";
            this.cmdBold.Size = new System.Drawing.Size(23, 22);
            this.cmdBold.Text = "B";
            this.cmdBold.Click += new System.EventHandler(this.cmdBold_Click);
            // 
            // cmdItalic
            // 
            this.cmdItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdItalic.Image = global::Test_Socket.Properties.Resources.black_italic_512;
            this.cmdItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdItalic.Name = "cmdItalic";
            this.cmdItalic.Size = new System.Drawing.Size(23, 22);
            this.cmdItalic.Text = "I";
            this.cmdItalic.Click += new System.EventHandler(this.cmdItalic_Click);
            // 
            // cmdUnderline
            // 
            this.cmdUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdUnderline.Image = global::Test_Socket.Properties.Resources._240d5a5ec588ea8a80433c7acb97f6e5;
            this.cmdUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUnderline.Name = "cmdUnderline";
            this.cmdUnderline.Size = new System.Drawing.Size(23, 22);
            this.cmdUnderline.Text = "U";
            this.cmdUnderline.Click += new System.EventHandler(this.cmdUnderline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lstFonts
            // 
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(49, 22);
            this.lstFonts.Text = "Fonts";
            this.lstFonts.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.lstFonts_DropDownItemClicked);
            this.lstFonts.Click += new System.EventHandler(this.lstFonts_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdColor
            // 
            this.cmdColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdColor.Image = global::Test_Socket.Properties.Resources.color_wheel;
            this.cmdColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.Size = new System.Drawing.Size(23, 22);
            this.cmdColor.Text = "Color";
            this.cmdColor.Click += new System.EventHandler(this.CmdColor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Frm_Server
            // 
            this.AcceptButton = this.Btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 391);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.RightClick.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip RightClick;
        private System.Windows.Forms.ToolStripMenuItem RC_Cut;
        private System.Windows.Forms.ToolStripMenuItem RC_Copy;
        private System.Windows.Forms.ToolStripMenuItem RC_Paste;
        private System.Windows.Forms.ToolStripMenuItem RC_Clear;
        private System.Windows.Forms.ToolStripMenuItem RC_SelectAll;
        private System.Windows.Forms.ToolStripStatusLabel Txt_Status;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Btn_SendFile;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Port;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdBold;
        private System.Windows.Forms.ToolStripButton cmdItalic;
        private System.Windows.Forms.ToolStripButton cmdUnderline;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripDropDownButton lstFonts;
        private System.Windows.Forms.ToolStripButton cmdColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.RichTextBox Txt_Roomi;
        private System.Windows.Forms.RichTextBox Txt_Back;
        private System.Windows.Forms.RichTextBox Txt_Message;
    }
}

