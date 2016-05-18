﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CurrentWallPaper
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			Settings.PrepareConfigFile();

			Application.Run( new MainForm() );
		}
	}
}
