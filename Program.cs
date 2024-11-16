using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Coding_Assessment_Test_Faez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email_OTP_Module email_OTP_Module = new Email_OTP_Module();
            STATUS_EMAIL _res = email_OTP_Module.generate_OTP_email(Console.ReadLine());
            Console.WriteLine(_res);
            if (_res == STATUS_EMAIL.STATUS_EMAIL_OK)
            {
                Console.WriteLine(email_OTP_Module.check_OTP(new iostream()));
            }
            Console.ReadLine();
        }
    }
}
