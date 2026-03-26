using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MessagePublisher
    {
        public event MessageEventHandler MessageSent;

        public void Send(string message)
        {
            if (MessageSent != null)
            {
                MessageSent(message);
            }
        }
    }
}
