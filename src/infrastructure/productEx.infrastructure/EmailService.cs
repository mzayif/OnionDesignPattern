using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace productEx.infrastructure
{
    public class EmailService: IEmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Mail Gönderildi");
        }
    }
}
