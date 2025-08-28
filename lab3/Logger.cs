using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
    internal static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }
    }
}
