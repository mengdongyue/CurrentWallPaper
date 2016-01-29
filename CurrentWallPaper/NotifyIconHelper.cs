using System;
using System.Drawing;
using System.Windows.Forms;
using CurrentWallPaper.Properties;

namespace CurrentWallPaper
{
	/// <summary>
	/// 帮助应用程序具备驻留系统托盘的功能。
	/// </summary>
	public class NotifyIconHelper
	{
		#region Fields & Properties.

		private Form _mainForm;

		private NotifyIcon _notifyIcon;

		private ContextMenuStrip _contextMenu;

		private ImageList _imgLst;

		private bool _showPromptWhenClosing;

		#endregion

		#region Constructors.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="mainForm"></param>
		public NotifyIconHelper( Form mainForm )
			: this( mainForm, false, true )
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="mainForm"></param>
		/// <param name="showPromptWhenClosing"></param>
		public NotifyIconHelper( Form mainForm, bool showPromptWhenClosing )
			: this( mainForm, false, showPromptWhenClosing )
		{
		}

		/// <summary>
		/// 构造 NotifyIconHelper 的新实例。
		/// </summary>
		/// <param name="mainForm">应用程序主窗体。</param>
		/// <param name="notHandleClosingEvent">是否不让 NotifyIconHelper 处理主窗体的 FormClosing 事件。
		/// <remarks>
		/// 缺省情况下此参数应为 False，即 NotifyIconHelper 总是通过处理主窗体的 FormClosing 事件达到让主窗体在关闭后
		/// 驻留系统托盘区的目的。但特殊情况下，应用程序可能会自己处理主窗体的的 FormClosing 事件，此时应设置此属性为 True。
		/// </remarks>
		/// </param>
		/// <param name="showPromptWhenClosing">是否在窗体关闭时给用户以提示，仅当 NotHandleClosingEvent = False 时有效。</param>
		public NotifyIconHelper( Form mainForm, bool notHandleClosingEvent, bool showPromptWhenClosing )
		{
			_mainForm = mainForm;
			_showPromptWhenClosing = showPromptWhenClosing;

			_imgLst = new ImageList();
			_imgLst.Images.Add( _mainForm.Icon );

			Image img = Image.FromHbitmap( _mainForm.Icon.ToBitmap().GetHbitmap() );

			_contextMenu = new ContextMenuStrip();

			_contextMenu.Items.Add( new ToolStripMenuItem( Resources.MenuShowMainForm, img, OnShowMainForm ) );
			_contextMenu.Items.Add( new ToolStripSeparator() );
			_contextMenu.Items.Add( new ToolStripMenuItem( Resources.MenuExit, null, OnExitApp ) );

			_notifyIcon = new NotifyIcon();
			_notifyIcon.Icon = GetAppIcon();
			_notifyIcon.Text = _mainForm.Text;
			_notifyIcon.Visible = true;
			_notifyIcon.ContextMenuStrip = _contextMenu;
			_notifyIcon.MouseDown += _notifyIcon_MouseDown;

			_mainForm.FormClosed += _mainForm_FormClosed;

			if( notHandleClosingEvent == false )
				_mainForm.FormClosing += new FormClosingEventHandler( _mainForm_FormClosing );
		}

		#endregion

		#region Private Methods.

		// 左键单击，显示主界面。
		void _notifyIcon_MouseDown( object sender, MouseEventArgs e )
		{
			if( e.Button == MouseButtons.Left )
				OnShowMainForm( sender, e );
		}

		// FormClosing 时，不关闭窗体而是隐藏。除非是应用程序退出、系统关机或从任务管理器杀死进程。
		void _mainForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			if( e.CloseReason == CloseReason.ApplicationExitCall
				|| e.CloseReason == CloseReason.TaskManagerClosing
				|| e.CloseReason == CloseReason.WindowsShutDown )
			{
				e.Cancel = false;
				return;
			}

			if( _showPromptWhenClosing )
			{
				if( MessageBox.Show( Resources.MsgExitApp, _mainForm.Text, MessageBoxButtons.OKCancel ) == DialogResult.Cancel )
				{
					e.Cancel = true;
					_mainForm.Hide();
					return;
				}
			}
			else
			{
				e.Cancel = true;
				_mainForm.Hide();
			}
		}

		// 窗体关闭后释放托盘图标，否则托盘图标总是存在，等鼠标放上去才自动消失。
		void _mainForm_FormClosed( object sender, FormClosedEventArgs e )
		{
			_notifyIcon.Dispose();
		}

		private void OnExitApp( object sender, EventArgs e )
		{
			Application.Exit();
		}

		private void OnShowMainForm( object sender, EventArgs e )
		{
			if( _mainForm.WindowState == FormWindowState.Minimized )
				_mainForm.WindowState = FormWindowState.Normal;

			_mainForm.Activate();
			_mainForm.Show();
		}

		private Icon GetAppIcon()
		{
			string appFile = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;

			Icon icon = Icon.ExtractAssociatedIcon( appFile );

			if( icon == null )
				icon = _mainForm.Icon;

			return icon;
		}

		#endregion

		#region Public Methods.

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		/// <param name="onClick"></param>
		public void AddMenuItem( string text, EventHandler onClick )
		{
			AddMenuItem( text, null, onClick );
		}

		/// <summary>
		/// 为托盘图标添加右键菜单。
		/// </summary>
		/// <param name="text">菜单文本。</param>
		/// <param name="image">菜单图标。</param>
		/// <param name="onClick">菜单单击事件处理程序。</param>
		public void AddMenuItem( string text, Image image, EventHandler onClick )
		{
			if( string.IsNullOrWhiteSpace( text ) )
				return;

			text = text.Trim();

			if( _contextMenu.Items.Count == 3 )
				_contextMenu.Items.Insert( 2, new ToolStripSeparator() );

			int idx = _contextMenu.Items.Count - 2;
			_contextMenu.Items.Insert( idx, new ToolStripMenuItem( text, image, onClick ) );
		}

		#endregion
	}
}
