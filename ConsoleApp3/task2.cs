using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class task2
{
    delegate void NotificationHandler(string message);

    static void SendEmail(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }

    static void SendSMS(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }

  /*  static void Main()
    {
        NotificationHandler notify = null;

        notify += SendEmail;
        notify += SendSMS;

        notify("!!!!");
    }*/
}