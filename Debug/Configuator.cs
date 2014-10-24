using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace Debug
{
	public class Configuator
	{
		public LogLevels LogLevels { get; set; }

		public Config GetConfig() {
			return GetConfig (null);
		}

		public Config GetConfig(string name) {
			var config = new Config {
				LogLevels = this.LogLevels,
				Enabled = ParseEnvironment(name)
			};
			if (name != null)
				config.Name = name;


			_configs.Add (config);

			return config;
		}



		public IFormat Formatter { get; set; }

		private List<ITransport> _transports;
		public Writer Writer;

		private List<Config> _configs;
	

		public Configuator ()
		{
			_transports = new List<ITransport> ();
			_configs = new List<Config> ();
			Writer = new Writer (_transports);
			Formatter = new DefaultFormatter ();
			Writer.Formatter = Formatter;
		
		}

		public void Enable(string name) {
			var reg = new Regex(name.Replace("*",".*"));
			_configs.ForEach (x => {
				if (reg.IsMatch(x.Name)) {
					x.Enabled = true;
				}
			});
		}

		public void Enable(Type type) {
			Enable (type.FullName);
		}

		public void Disable(string name) {
			var reg = new Regex(name.Replace("*",".*"));
			_configs.ForEach (x => {
				if (reg.IsMatch(x.Name)) {
					x.Enabled = false;
				}
			});
		}

		public void Disable(Type type) {
			Disable (type.FullName);
		}

		public T AddTransport<T>() where T: ITransport, new() {
			var transport = new T ();
			transport.LogLevels = this.LogLevels;
			_transports.Add (transport);
			return transport;
		}


		private bool ParseEnvironment (string name) {
			if (name == null)
				return true;
			var str = Environment.GetEnvironmentVariable ("DEBUG");
			if (str == null)
				return false;

			var reg = new Regex(str.Replace("*",".*"));

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

