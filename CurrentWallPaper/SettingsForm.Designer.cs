namespace CurrentWallPaper
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRefreshInterval = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOpacityHover = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtOpacityLeave = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Auto refresh interval:";
			// 
			// txtRefreshInterval
			// 
			this.txtRefreshInterval.Location = new System.Drawing.Point(174, 21);
			this.txtRefreshInterval.Name = "txtRefreshInterval";
			this.txtRefreshInterval.Size = new System.Drawing.Size(62, 21);
			this.txtRefreshInterval.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(242, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "s";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(242, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(11, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "%";
			// 
			// txtOpacityHover
			// 
			this.txtOpacityHover.Location = new System.Drawing.Point(174, 60);
			this.txtOpacityHover.Name = "txtOpacityHover";
			this.txtOpacityHover.Size = new System.Drawing.Size(62, 21);
			this.txtOpacityHover.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "Opacity when mouse &hover:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(242, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(11, 12);
			this.label5.TabIndex = 8;
			this.label5.Text = "%";
			// 
			// txtOpacityLeave
			// 
			this.txtOpacityLeave.Location = new System.Drawing.Point(174, 99);
			this.txtOpacityLeave.Name = "txtOpacityLeave";
			this.txtOpacityLeave.Size = new System.Drawing.Size(62, 21);
			this.txtOpacityLeave.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(155, 12);
			this.label6.TabIndex = 6;
			this.label6.Text = "Opacity when mouse &leave:";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(174, 142);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(62, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 177);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtOpacityLeave);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtOpacityHover);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRefreshInterval);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRefreshInterval;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOpacityHover;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtOpacityLeave;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}