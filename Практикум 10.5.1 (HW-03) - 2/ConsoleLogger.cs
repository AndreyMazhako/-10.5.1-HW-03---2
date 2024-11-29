using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикум_10._5._1__HW_03____2
{
    // Реализация логгера, который выводит в консоль
    class ConsoleLogger : ILogger
    {
        public void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
