using System;
using System.IO;

namespace Logger
{
    public class Starter
    {
        private Actions _actions = new Actions();
        private LoggerSingleton _logger = LoggerSingleton.GetInstance();

        public void Run()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    switch (new Random().Next(1, 4))
                    {
                        case 1:
                            _actions.Method1();
                            break;
                        case 2:
                            _actions.Method2();
                            break;
                        case 3:
                            _actions.Method3();
                            break;
                    }
                }
            }
            catch (BusinessException bEx)
            {
                _logger.Log(LogType.Warning, $"Action got this custom Exception : {bEx.Message}");
            }
            catch (Exception ex)
            {
                 _logger.Log(LogType.Warning, $"Action failed by reason : {ex}");
            }
        }
    }
}
