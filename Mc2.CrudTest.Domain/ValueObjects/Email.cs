using Mc2.CrudTest.Domain.Errors;
using Mc2.CrudTest.Domain.Primitives;
using Mc2.CrudTest.Domain.Shared;
using Mc2.CrudTest.Domain.ValueObjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Domain.ValueObjects
{
    public sealed class Email : ValueObject
    {
        public Email(string value)
        {
            Value = value;
        }
        public string Value { get; }


        public static Result<Email> Create(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Result.Failure<Email>(DomainErrors.Email.Empty);
            }

            if (EmailValidation.CheckMail(email) is false)
            {
                return Result.Failure<Email>(DomainErrors.Email.InvalidFormat);
            }

            return new Email(email);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
