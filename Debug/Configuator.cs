using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace Debug
{
	public class Configuator
	{

		public Config GetConfig() {
			return GetConfig (null);
		}

		public Config GetConfig(string name) {
			var config = new Config {
				LogLevels = LogLevels.Debug | LogLevels.Info | LogLevels.Error | LogLevels.Warn,
				Enabled = ParseEnvironment(name)
			};
			if (name != null)
				config.Name = name;

			return config;
		}

		public IFormat Formatter { get; set; }

		private List<ITransport> _transports;
		public Writer Writer;


		public Configuator ()
		{
			_transports = new List<ITransport> ();
			_transports.Add (new ConsoleTransport ());

			Writer = new Writer (_transports);
			Formatter = new DefaultFormatter ();
			Writer.Formatter = Formatter;
		
		}

		private bool ParseEnvironment (string name) {
			if (name == null)
				return true;
			var str = Environment.GetEnvironmentVariable ("DEBUG");
			if (str == null)
				return false;

			var reg = new Regex(str.Replace("*",".*"));
			Console.WriteLine (reg);
			return reg.IsMatch (name);
		}

		public void SetLogLevels(LogLevels loglevels) {
			if ((loglevels & LogLevels.Info) != 0) {

			}
			if ((loglevels & LogLevels.Debug) != 0) {
			
			}
			if ((loglevels & LogLevels.Warn) != 0) {
			
			}
			if ((loglevels & LogLevels.Error) != 0) {
			
			}
		}
	}
}

