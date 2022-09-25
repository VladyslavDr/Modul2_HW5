using System;
using System.Text;

namespace Logger
{
    public class LoggerSingleton
    {
        private static LoggerSingleton _instance;
        private static StringBuilder _textLog = new StringBuilder();

        private LoggerSingleton()
        {
        }

        public StringBuilder DatabaseLogs => _textLog;

        public static LoggerSingleton GetInstance()
        {
            if (_instance is null)
            {
                _instance = new LoggerSingleton();
            }

            return _instance;
        }

        public void Log(LogType logType, string textLog)
        {
            _textLog.Append($"{DateTime.Now}: {logType}: {textLog}\n");
        }
    }
}
