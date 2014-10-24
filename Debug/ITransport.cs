using System;

namespace Debug
{
	public interface ITransport
	{
		bool Write(string message);
	}


}

