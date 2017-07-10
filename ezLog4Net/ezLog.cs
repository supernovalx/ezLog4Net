using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace ezLog4Net
{
    public class ezLog
    {
        private LogConsole console;

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
            console = new LogConsole();
            console.Show();
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
            RichTextBox rtbLog = console.rtbLog;

            if (DateTimeLog)
            {
                rtbLog.SelectionColor = Color.Gray;
                rtbLog.SelectedText=$"[{DateTime.Now.ToString("HH:mm:ss.fff")}] - ";
            }
            rtbLog.SelectionColor = Color.FromKnownColor((KnownColor)loglv);
            rtbLog.SelectedText = $"{loglv} - {mess}\n";
        }
    }
}
