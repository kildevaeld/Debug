using System;

namespace Debug
{
	[Flags]
	public enum LogLevels
	{
		Info = 0x00,
		Error = 0x01,
		Warn = 0x02,
		Debug = 0x03
	}
}

