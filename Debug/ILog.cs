﻿using System;

namespace Debug
{
	public interface ILog
	{

		void Debug(string message);
		void Debug(string message, params object[] args);

		void Info(string message);
		void Info(string message, params object[] args);

		void Warn(string message);
		void Warn(string message, params object[] args);

		void Error(string message);
		void Error(string message, params object[] args);
	}
}

