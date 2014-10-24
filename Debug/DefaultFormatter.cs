using System;

namespace Debug
{
	public class DefaultFormatter : IFormat
	{
		public bool Colorize { get; set; }
		private AnsiColor _colors;
		public DefaultFormatter ()
		{

		}

		public string Format(LogLevels level, string message) {
			string str;
			if (this.Colorize) {
				str = string.Format("{{bold}}{0}[{1}]{{reset}}: {2}",Color(level),level,message);
				str = AnsiColor.Colorize (str); 
			} else {
				str = string.Format("[{0}]: {1}",level, message); 
			}
			return str;
		}

		public string Color(LogLevels level) {
			switch (level) {
			case LogLevels.Debug: return "{white}";
			case LogLevels.Error: return "{red}";
			case LogLevels.Info:
				return "{cyan}";
			case LogLevels.Warn: return "{yellow}";

			}
			return "";
		}
	}
}

