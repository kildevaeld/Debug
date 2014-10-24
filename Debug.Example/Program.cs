using System;
using Debug;
namespace Debug.Example
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Log.Configuation.LogLevels =  LogLevels.Warn | LogLevels.Debug | LogLevels.Error;
			Log.Configuation.Formatter.Colorize = true;
			Log log = (Log)Log.Create ("mein");
			Log.Configuation.AddTransport<ConsoleTransport> (); 
			//log.Config.LogLevels = LogLevels.Warn | LogLevels.Debug | LogLevels.Error;
			Log.Configuation.Enable ("mein");
			//log.Config.Enabled = true;
			log.Info ("Test");
			log.Debug("Test {0}", "args");
			log.Error ("Error");
			log.Warn ("Warning");
		}
	}
}
