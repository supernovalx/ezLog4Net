using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezLog4Net
{
    public static class RichTextBoxControlExtension
    {
        public static void WriteTextWithColor(this RichTextBox rtb, string text, ELogLevel loglv)
        {
            WriteTextWithColor(rtb, text, Color.FromKnownColor((KnownColor)loglv));
        }

        public static void WriteTextWithColor(this RichTextBox rtb, string text, Color color)
        {
            rtb.SelectionColor = color;
            rtb.SelectedText = text;
        }
    }
}
