using GemBox.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Domain.ValueObjects.Services
{
    public static class EmailValidation
    {
        public static bool CheckMail(string mail)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            var result = MailAddressValidator.Validate(mail);
            if (result.Status == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
