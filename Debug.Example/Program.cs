using System;
using Debug;
namespace Debug.Example
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var log = Log.Create ("mein");
			log.Config.LogLevels = LogLevels.Info;
			log.Info ("Test");
			log.Debug("Test {0}", "args");
			log.Error ("Error");
			log.Warn ("Warning");
		}
	}
}
