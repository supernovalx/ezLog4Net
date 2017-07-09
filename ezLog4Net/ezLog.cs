using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ezLog4Net
{
    public class ezLog
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        private static ezLog instance;
        public static ezLog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ezLog();
                }
                return instance;
            }
        }

        public bool DateTimeLog = true;

        private ezLog()
        {
            AllocConsole();
        }

        public void Debug(string mess)
        {
            this.Write(mess, ELogLevel.DEBUG);
        }

        public void Info(string mess)
        {
            this.Write(mess, ELogLevel.INFO);
        }

        public void Warn(string mess)
        {
            this.Write(mess, ELogLevel.WARN);
        }

        public void Error(string mess)
        {
            this.Write(mess, ELogLevel.ERROR);
        }

        private void Write(string mess, ELogLevel loglv)
        {
            if (DateTimeLog)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"[{DateTime.Now.ToShortTimeString()}] - ");
            }
            Console.ForegroundColor = (ConsoleColor)loglv;
            Console.WriteLine($"{loglv} - {mess}");
        }
    }
}
