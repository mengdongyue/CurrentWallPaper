using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace CurrentWallPaper
{
	public class Settings
	{
		private string _keyInterval = "AutoRefreshInterval";
		private string _keyHover = "OpacityHover";
		private string _keyLeave = "OpacityLeave";

		public int AutoRefreshInterval { get; set; }

		public int OpacityHover { get; set; }

		public int OpacityLeave { get; set; }

		private Configuration _config;

		public Settings()
		{
			string configFile = System.Windows.Forms.Application.ExecutablePath;
			Configuration config = ConfigurationManager.OpenExeConfiguration( configFile );
			_config = config;

			AutoRefreshInterval = GetAppSettingsItem( config, _keyInterval, 30000 );
			OpacityHover = GetAppSettingsItem( config, _keyHover, 90 );
			OpacityLeave = GetAppSettingsItem( config, _keyLeave, 20 );
		}

		private int GetAppSettingsItem( Configuration config, string keyName, int defaultValue )
		{
			int i;

			string a = config.AppSettings.Settings[ keyName ].Value;
			bool b = int.TryParse( a, out i );
			if( !b || i <= 0 )
				i = defaultValue;

			return i;
		}

		public void SaveSettings()
		{
			Configuration config = _config;
			config.AppSettings.Settings[ _keyInterval ].Value = AutoRefreshInterval.ToString();
			config.AppSettings.Settings[ _keyHover ].Value = OpacityHover.ToString();
			config.AppSettings.Settings[ _keyLeave ].Value = OpacityLeave.ToString();

			config.Save( ConfigurationSaveMode.Full );
		}
	}
}
