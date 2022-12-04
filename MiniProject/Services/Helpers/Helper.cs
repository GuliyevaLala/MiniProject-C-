using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Helpers
{
    public static class Helper
    {
        public static void WriteConsole(this ConsoleColor color, string context)
        {
            Console.ForegroundColor= color; 
            Console.WriteLine(context);
            Console.ResetColor();
        }
    }
}
