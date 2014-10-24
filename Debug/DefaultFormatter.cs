using System;

namespace Debug
{
	public class DefaultFormatter : IFormat
	{
		public DefaultFormatter ()
		{
		}

		public string Format(LogLevels level, string message) {
			return string.Format("[{0}]: {1}",level, message); 
		}
	}
}

