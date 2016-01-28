using System;
using System.Windows.Forms;

namespace CurrentWallPaper
{
	public partial class SettingsForm : Form
	{
		private Settings _settings;

		public SettingsForm( Settings settings )
		{
			_settings = settings;

			InitializeComponent();
		}

		private void SettingsForm_Load( object sender, EventArgs e )
		{
			txtRefreshInterval.Text = _settings.AutoRefreshInterval.ToString();
			txtOpacityHover.Text = _settings.OpacityHover.ToString();
			txtOpacityLeave.Text = _settings.OpacityLeave.ToString();
		}

		private void btnOK_Click( object sender, EventArgs e )
		{
			bool b = EndEdit();
			if( b )
			{
				_settings.SaveSettings();
				this.Close();
			}
		}

		private bool EndEdit()
		{
			int interval = CheckIntValue( txtRefreshInterval, 0, int.MaxValue );
			int hover = CheckIntValue( txtOpacityHover, 0, 100 );
			int leave = CheckIntValue( txtOpacityLeave, 0, 100 );

			if( interval > 0 && hover >= 0 && leave >= 0 )
			{
				_settings.AutoRefreshInterval = interval;
				_settings.OpacityHover = hover;
				_settings.OpacityLeave = leave;

				return true;
			}

			return false;
		}

		private int CheckIntValue( TextBox txt, int min, int max )
		{
			int intValue;
			bool valid = int.TryParse( txt.Text, out intValue );
			
			string msg = null;
			if( !valid )
			{
				msg = "Should be a number";
				intValue = -1;
			}
			else if( intValue < min || intValue > max )
			{
				msg = string.Format( "Should be between {0} - {1}", min, max );
				intValue = -1;
			}

			errorProvider1.SetError( txt, msg );

			return intValue;
		}
	}
}
