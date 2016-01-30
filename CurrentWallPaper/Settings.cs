using System.Configuration;
using System.IO;
using System.Reflection;
using System.Text;

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

		public static void PrepareConfigFile()
		{
			string configFile = System.Windows.Forms.Application.ExecutablePath + ".config";
			if( File.Exists( configFile ) && ( new FileInfo( configFile ).Length > 0 ) )
				return;

			Assembly assembly = Assembly.GetExecutingAssembly();
			Stream stream = assembly.GetManifestResourceStream( "CurrentWallPaper.App.config" );
			if( stream == null || stream.Length == 0 )
				return;

			string targetFile = configFile;
			using( FileStream fs = new FileStream( targetFile, FileMode.Create, FileAccess.Write ) )
			{
				StreamReader reader = new StreamReader( stream, Encoding.UTF8 );
				string txt = reader.ReadToEnd();
				reader.Close();

				StreamWriter writer = new StreamWriter( fs, Encoding.UTF8 );
				writer.Write( txt );
				writer.Flush();
				writer.Close();
			}			
		}
	}
}
