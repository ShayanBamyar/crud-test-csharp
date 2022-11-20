using PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Domain.ValueObjects.Services
{
    public static class PhoneNemberValidation
    {
        public static bool CheckPhoneNumber(string value)
        {
            var valueString = "+" + value as string;
            if (string.IsNullOrEmpty(valueString))
            {
                return true;
            }
            var util = PhoneNumberUtil.GetInstance();
            try
            {
                var number = util.Parse(valueString, null);
                return util.IsValidNumber(number);
            }
            catch (NumberParseException)
            {
                return false;
            }
        }
    }
}
