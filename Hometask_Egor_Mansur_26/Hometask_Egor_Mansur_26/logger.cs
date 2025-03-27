using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    interface ILogging
    {
        void LogMessage(string message)
        {
            Console.WriteLine($"[Default Log] {message}");
        }
    }

    class Logger : ILogging
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"[Custom Log] {message}");
        }
    }

    class Task11
    {
        public static void Execute()
        {
            ILogging defaultLogger = new Logger();
            defaultLogger.LogMessage("Это сообщение по умолчанию");

            Logger customLogger = new Logger();
            customLogger.LogMessage("Это переопределённое сообщение");
        }
    }
}
