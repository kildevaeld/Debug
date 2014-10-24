using System;

namespace Debug
{
	public interface IFormat
	{
		string Format(LogLevels level, string message);
	}
}

