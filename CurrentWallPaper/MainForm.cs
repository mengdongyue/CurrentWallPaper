using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CurrentWallPaper
{
	public partial class MainForm : Form
	{
		private Settings _settings;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			NotifyIconHelper helper = new NotifyIconHelper( this, false );
			helper.AddMenuItem( "Settings", menuItemSettings_Click );

			_settings = new Settings();
			timer1.Interval = _settings.AutoRefreshInterval * 1000;

			ShowFileName();

			this.Location = new Point( 800, 0 );
			this.Focus();

			timer1.Start();
		}

		private void lblPicFile_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			string file = lblPicFile.Tag.ToString();
			if( File.Exists( file ) )
				Process.Start( file );
			else
				MessageBox.Show( string.Format( "File Not Found. \r\n\r\n  {0}", file ) );
		}

		private void btnDelete_Click( object sender, EventArgs e )
		{
			if( MessageBox.Show( "Are you sure you want to delete this picture file？", "Delete", MessageBoxButtons.OKCancel ) == DialogResult.OK )
				File.Delete( lblPicFile.Tag.ToString() );
		}

		private void btnExit_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void ShowFileName()
		{
			string file = GetCurrentWallPaperFile();
			lblPicFile.Text = Path.GetFileName( file );
			lblPicFile.Tag = file;

			this.Width = lblPicFile.Text.Length * 14 + 60;
		}

		#region 窗体内按住鼠标左键移动窗体位置。

		int x, y;
		private void MainForm_MouseDown( object sender, MouseEventArgs e )
		{
			if( e.Button == MouseButtons.Left )
			{
				x = e.X;
				y = e.Y;
			}
		}

		private void MainForm_MouseMove( object sender, MouseEventArgs e )
		{
			if( e.Button == MouseButtons.Left )
			{
				this.Location = new Point( this.Location.X + ( e.X - x ), this.Location.Y + ( e.Y - y ) );
			}
		} 

		#endregion

		private static string GetCurrentWallPaperFile()
		{
			var wpReg = Registry.CurrentUser.OpenSubKey( @"Control Panel\Desktop" );
			byte[] cacheBytes = (byte[])wpReg.GetValue( "TranscodedImageCache" );

			int position = 24;
			byte[] pathBytes = new byte[ cacheBytes.Length - position ];
			Array.Copy( cacheBytes, position, pathBytes, 0, pathBytes.Length );

			string wallPaperFile = Encoding.Unicode.GetString( pathBytes ).TrimEnd( "\0".ToCharArray() );

			return wallPaperFile;
		}

		private void panel1_MouseEnter( object sender, EventArgs e )
		{
			this.Opacity = _settings.OpacityHover / 100d;
		}

		private void panel1_MouseLeave( object sender, EventArgs e )
		{
			this.Opacity = _settings.OpacityLeave / 100d;
		}

		private void timer1_Tick( object sender, EventArgs e )
		{
			ShowFileName();
		}

		private void btnRefresh_Click( object sender, EventArgs e )
		{
			lblPicFile.Text = string.Empty;
			ShowFileName();
			timer1.Stop();
			timer1.Start();
		}

		private void menuItemSettings_Click( object sender, EventArgs e )
		{
			SettingsForm sf = new SettingsForm( _settings );
			if( sf.ShowDialog( this ) == DialogResult.OK )
			{
				this.Opacity = _settings.OpacityHover / 100d;
				timer1.Interval = _settings.AutoRefreshInterval;
			}
		}
	}
}
