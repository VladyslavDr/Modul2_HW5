using System;

namespace Logger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = LoggerSingleton.GetInstance();
            var res = new Starter();
            res.Run();

            Console.WriteLine(logger.DatabaseLogs);
        }
    }
}
