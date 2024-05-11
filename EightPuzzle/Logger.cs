using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightPuzzle
{
    public class Logger
    {
        private RichTextBox logTextBox = new RichTextBox();
        private bool enabled = false;
        public Logger() {
        
        }

        public void setTextBox(RichTextBox logTextBox)
        {
            this.logTextBox = logTextBox;
        }
        public void enable() { enabled = true; }
        public void disable() { enabled = false; }
        public void log(string message, string caller)
        {
            if (!enabled) return;
            logTextBox.Text += "[" + caller + "]" + ": " + message + "\n";
        }

        public void clear()
        {
            logTextBox.Clear();
        }
    }
}
