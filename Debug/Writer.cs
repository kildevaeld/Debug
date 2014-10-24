using System;
using System.Linq;
using System.Collections.Generic;

namespace Debug
{
	public class Writer
	{

		public IFormat Formatter { get; internal set; }
		public IEnumerable<ITransport> _transports;
		public Writer (IEnumerable<ITransport> transports)
		{
			_transports = transports;
		}


		public void Write(LogLevels level, Config config, string message) {

			if ((!config.Enabled  && level == LogLevels.Debug) 
				|| Formatter == null)
				return;

			if (config.Name != null)
				message = "(" + config.Name + ")" + " " + message;

			var str = Formatter.Format (level, message);


			foreach (var transport in this.GetTransports(level,config)) {
				transport.Write (str);
			}
		}

		private IEnumerable<ITransport> GetTransports(LogLevels level, Config config) {

			return _transports.Where (x => {
				return Validate(level,config);
			});
		}

		private bool Validate(LogLevels level, Config config) {
			return config.LogLevels.HasFlag (level);
		}
	}
}

