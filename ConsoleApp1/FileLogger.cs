using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FileLogger
    {
        private string _fileName;

        public FileLogger(string fileName)
        {
            this._fileName = fileName;
        }

        public void Subscribe(MessagePublisher publisher)
        {
            publisher.MessageSent += LogMessage;
        }

        private void LogMessage(string message)
        {
            string log = $"[{DateTime.Now}] {message}";
            File.AppendAllText(_fileName, log + Environment.NewLine);
        }
    }
}
