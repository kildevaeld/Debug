using System;

namespace Debug
{
	public class ConsoleTransport : ITransport
	{
		public LogLevels LogLevels { get; set;}

		public ConsoleTransport ()
		{
		}

		public bool Write(string message) {
			Console.WriteLine (message);
			return true;
		}
	}
}

