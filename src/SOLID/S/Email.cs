using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.SOLID.S
{
    public class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            System.Console.WriteLine($"Sending email to {email} : {message}");
        }
    }
}