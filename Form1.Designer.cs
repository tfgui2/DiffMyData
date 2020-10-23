namespace DiffMyData
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_diff = new System.Windows.Forms.Button();
            this.textBox_SkyrimDataFolder = new System.Windows.Forms.TextBox();
            this.textBox_MyDataFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox_MyData = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_openinbrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_SkyrimData = new System.Windows.Forms.ListBox();
            this.useThisFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_fileinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_fileinfo);
            this.splitContainer1.Panel1.Controls.Add(this.button_diff);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_SkyrimDataFolder);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_MyDataFolder);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 698);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_diff
            // 
            this.button_diff.Location = new System.Drawing.Point(562, 16);
            this.button_diff.Name = "button_diff";
            this.button_diff.Size = new System.Drawing.Size(66, 45);
            this.button_diff.TabIndex = 4;
            this.button_diff.Text = "Diff";
            this.button_diff.UseVisualStyleBackColor = true;
            this.button_diff.Click += new System.EventHandler(this.button_diff_Click);
            // 
            // textBox_SkyrimDataFolder
            // 
            this.textBox_SkyrimDataFolder.Location = new System.Drawing.Point(140, 41);
            this.textBox_SkyrimDataFolder.Name = "textBox_SkyrimDataFolder";
            this.textBox_SkyrimDataFolder.Size = new System.Drawing.Size(408, 21);
            this.textBox_SkyrimDataFolder.TabIndex = 3;
            // 
            // textBox_MyDataFolder
            // 
            this.textBox_MyDataFolder.Location = new System.Drawing.Point(140, 13);
            this.textBox_MyDataFolder.Name = "textBox_MyDataFolder";
            this.textBox_MyDataFolder.Size = new System.Drawing.Size(408, 21);
            this.textBox_MyDataFolder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "SkyrimDataFolder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MyDataFolder";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox_MyData);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox_SkyrimData);
            this.splitContainer2.Size = new System.Drawing.Size(1240, 581);
            this.splitContainer2.SplitterDistance = 630;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox_MyData
            // 
            this.listBox_MyData.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox_MyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_MyData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_MyData.FormattingEnabled = true;
            this.listBox_MyData.HorizontalScrollbar = true;
            this.listBox_MyData.ItemHeight = 14;
            this.listBox_MyData.Location = new System.Drawing.Point(0, 0);
            this.listBox_MyData.Name = "listBox_MyData";
            this.listBox_MyData.ScrollAlwaysVisible = true;
            this.listBox_MyData.Size = new System.Drawing.Size(630, 581);
            this.listBox_MyData.TabIndex = 0;
            this.listBox_MyData.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_MyData_DrawItem);
            this.listBox_MyData.SelectedIndexChanged += new System.EventHandler(this.listBox_MyData_SelectedIndexChanged);
            this.listBox_MyData.DoubleClick += new System.EventHandler(this.listBox_MyData_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_openinbrowser,
            this.useThisFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem_openinbrowser
            // 
            this.toolStripMenuItem_openinbrowser.Name = "toolStripMenuItem_openinbrowser";
            this.toolStripMenuItem_openinbrowser.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem_openinbrowser.Text = "open in browser";
            this.toolStripMenuItem_openinbrowser.Click += new System.EventHandler(this.toolStripMenuItem_openinbrowser_Click);
            // 
            // listBox_SkyrimData
            // 
            this.listBox_SkyrimData.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox_SkyrimData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_SkyrimData.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_SkyrimData.FormattingEnabled = true;
            this.listBox_SkyrimData.HorizontalScrollbar = true;
            this.listBox_SkyrimData.ItemHeight = 14;
            this.listBox_SkyrimData.Location = new System.Drawing.Point(0, 0);
            this.listBox_SkyrimData.Name = "listBox_SkyrimData";
            this.listBox_SkyrimData.ScrollAlwaysVisible = true;
            this.listBox_SkyrimData.Size = new System.Drawing.Size(606, 581);
            this.listBox_SkyrimData.TabIndex = 0;
            this.listBox_SkyrimData.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_SkyrimData_DrawItem);
            this.listBox_SkyrimData.SelectedIndexChanged += new System.EventHandler(this.listBox_SkyrimData_SelectedIndexChanged);
            this.listBox_SkyrimData.DoubleClick += new System.EventHandler(this.listBox_SkyrimData_DoubleClick);
            // 
            // useThisFileToolStripMenuItem
            // 
            this.useThisFileToolStripMenuItem.Name = "useThisFileToolStripMenuItem";
            this.useThisFileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.useThisFileToolStripMenuItem.Text = "use this file";
            this.useThisFileToolStripMenuItem.Click += new System.EventHandler(this.useThisFileToolStripMenuItem_Click);
            // 
            // label_fileinfo
            // 
            this.label_fileinfo.AutoSize = true;
            this.label_fileinfo.Location = new System.Drawing.Point(15, 91);
            this.label_fileinfo.Name = "label_fileinfo";
            this.label_fileinfo.Size = new System.Drawing.Size(38, 12);
            this.label_fileinfo.TabIndex = 5;
            this.label_fileinfo.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 698);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_diff;
        private System.Windows.Forms.TextBox textBox_SkyrimDataFolder;
        private System.Windows.Forms.TextBox textBox_MyDataFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox_MyData;
        private System.Windows.Forms.ListBox listBox_SkyrimData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_openinbrowser;
        private System.Windows.Forms.ToolStripMenuItem useThisFileToolStripMenuItem;
        private System.Windows.Forms.Label label_fileinfo;
    }
}

