namespace CurrentWallPaper
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblPicFile = new System.Windows.Forms.LinkLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblPicFile
			// 
			this.lblPicFile.AutoSize = true;
			this.lblPicFile.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPicFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lblPicFile.Location = new System.Drawing.Point(42, 16);
			this.lblPicFile.Name = "lblPicFile";
			this.lblPicFile.Size = new System.Drawing.Size(429, 20);
			this.lblPicFile.TabIndex = 0;
			this.lblPicFile.TabStop = true;
			this.lblPicFile.Text = "current wallpaper picture file name";
			this.lblPicFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPicFile_LinkClicked);
			this.lblPicFile.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
			this.lblPicFile.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.ContextMenuStrip = this.contextMenuStrip1;
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnRefresh);
			this.panel1.Controls.Add(this.lblPicFile);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(827, 45);
			this.panel1.TabIndex = 3;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
			this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSettings});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
			// 
			// menuItemSettings
			// 
			this.menuItemSettings.Name = "menuItemSettings";
			this.menuItemSettings.Size = new System.Drawing.Size(122, 22);
			this.menuItemSettings.Text = "&Settings";
			this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.ForeColor = System.Drawing.Color.AliceBlue;
			this.btnExit.Image = global::CurrentWallPaper.Properties.Resources.FileExit;
			this.btnExit.Location = new System.Drawing.Point(807, -1);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(19, 18);
			this.btnExit.TabIndex = 5;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			this.btnExit.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
			this.btnExit.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.ForeColor = System.Drawing.Color.AliceBlue;
			this.btnDelete.Image = global::CurrentWallPaper.Properties.Resources.delete_16;
			this.btnDelete.Location = new System.Drawing.Point(777, 13);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(24, 24);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnDelete.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
			this.btnDelete.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
			// 
			// btnRefresh
			// 
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.ForeColor = System.Drawing.Color.AliceBlue;
			this.btnRefresh.Image = global::CurrentWallPaper.Properties.Resources.refresh_16;
			this.btnRefresh.Location = new System.Drawing.Point(11, 13);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(24, 24);
			this.btnRefresh.TabIndex = 3;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			this.btnRefresh.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
			this.btnRefresh.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
			// 
			// timer1
			// 
			this.timer1.Interval = 60000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 45);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Opacity = 0.9D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.LinkLabel lblPicFile;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
	}
}

