using System;

namespace Debug
{
	public interface IFormat
	{
		bool Colorize { get; set;}
		string Format(LogLevels level, string message);
	}
}

