using System;

namespace Debug
{
	public class Config
	{

		public LogLevels LogLevels { get; set; }
		public string Name { get; set; }
		public bool Enabled { get; internal set; }
		public Config ()
		{
		}
	}
}

