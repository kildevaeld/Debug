using System;
using System.Collections.Generic;
namespace Debug
{
	public class Log : ILog
	{

		public static Configuator Configuation = new Configuator();

		public static ILog Create(string name) {
			var config = Configuation.GetConfig (name);
			var log = new Log (config);
			return log;
		}

		public static ILog Create(Type name) {
			return Create (name.FullName);
		}

		public Config Config { get; internal set; }
			
		public Log (Config config)
		{
			Config = config;
		}

		public void Debug(string message) {
			Write (LogLevels.Debug, message, null);
		}

		public void Debug(string message, params object[] args) {
			Write (LogLevels.Debug, message, args);
		}

		public void Info(string message) {
			Write (LogLevels.Info, message, null);
		}

		public void Info(string message, params object[] args) {
			Write (LogLevels.Info, message, args);
		}

		public void Warn(string message) {
			Write (LogLevels.Warn, message, null);
		}

		public void Warn(string message, params object[] args) {
			Write (LogLevels.Warn, message, args);
		}

		public void Error(string message) {
			Write (LogLevels.Error, message, null);
		}

		public void Error(string message, params object[] args) {
			Write (LogLevels.Error, message, args);
		}

		internal void Write(LogLevels level, string message, object[] args) {
			var str = message;
			if (args != null)
				str = string.Format (message, args);
			Log.Configuation.Writer.Write (level, Config, str);
		}
			
	}
}

