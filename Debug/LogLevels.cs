using System;

namespace Debug
{
	[Flags]
	public enum LogLevels
	{
		Debug = 1,
		Info = 2,
		Warn = 4,
		Error = 8
	}
}

