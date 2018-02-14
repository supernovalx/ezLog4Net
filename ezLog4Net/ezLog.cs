using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

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
        public bool ThreadLog = true;

        private ezLog()
        {
            console = new LogConsole();

            Rectangle workingArea = Screen.GetWorkingArea(console);
            console.Location = new Point(workingArea.Right - console.Size.Width,
                                      workingArea.Bottom - console.Size.Height);


            console.Show();
        }

        public async void Debug(string mess,params object[] values)
        {
            
            this.Write(mess,values, ELogLevel.DEBUG);
        }

        public async void Info(string mess, params object[] values)
        {
            this.Write(mess, values, ELogLevel.INFO);
        }

        public async void Warn(string mess, params object[] values)
        {
            this.Write(mess, values, ELogLevel.WARN);
        }

        public async void Error(string mess, params object[] values)
        {
            this.Write(mess, values, ELogLevel.ERROR);
        }

        private void Write(string mess,object[] values, ELogLevel loglv)
        {
            console.rtbLog.Invoke(new MethodInvoker(delegate
            {
                RichTextBox rtbLog = console.rtbLog;

                // Write datetime
                if (DateTimeLog)
                    rtbLog.WriteTextWithColor($"[{DateTime.Now.ToString("HH:mm:ss.fff")}] - ", Color.Gray);

                // Write current thread id
                if (ThreadLog)
                    rtbLog.WriteTextWithColor($"[ThreadID = {Thread.CurrentThread.ManagedThreadId}] - ", Color.Aqua);

                // Format mess
                if (values.Length > 0)
                    mess = string.Format(mess, values);

                // Main log content
                rtbLog.WriteTextWithColor($"{loglv} - {mess}\n", loglv);
            }));
        }

        
    }
}
