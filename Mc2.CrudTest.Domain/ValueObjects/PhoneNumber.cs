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
    public sealed class PhoneNumber : ValueObject
    {
        public const int MaxLength = 13;
        public PhoneNumber(string value)
        {
            Value = value;
        }
        public string Value { get; }


        public static Result<PhoneNumber> Create(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return Result.Failure<PhoneNumber>(DomainErrors.PhoneNumber.Empty);
            }

            if (phoneNumber.Length != MaxLength)
            {
                return Result.Failure<PhoneNumber>(DomainErrors.PhoneNumber.invalid);
            }

            if (PhoneNemberValidation.CheckPhoneNumber(phoneNumber) is false)
            {
                return Result.Failure<PhoneNumber>(DomainErrors.PhoneNumber.invalid);
            }

            return new PhoneNumber(phoneNumber);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
