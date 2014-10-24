using System;

namespace Debug
{
	public class ConsoleTransport : ITransport
	{
		public ConsoleTransport ()
		{
		}

		public bool Write(string message) {
			Console.WriteLine (message);
			return true;
		}
	}
}

