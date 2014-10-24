using System;

namespace Debug
{
	public interface ITransport
	{
		LogLevels LogLevels { get; set; }
		bool Write(string message);

	}


}

