using ezLog4Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.ezLog4Net
{
    public partial class Main : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        private ezLog logger;
        public Main()
        {
            InitializeComponent();
        }

        

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            logger = ezLog.Instance;
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            logger.Debug(rtbLogMess.Text);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            logger.Info(rtbLogMess.Text);
        }

        private void btnWarn_Click(object sender, EventArgs e)
        {
            logger.Warn(rtbLogMess.Text);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            logger.Error(rtbLogMess.Text);
        }
    }
}
