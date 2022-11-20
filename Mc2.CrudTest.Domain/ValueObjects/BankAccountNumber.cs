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
    public sealed class BankAccountNumber : ValueObject
    {
        public const int MaxLength = 16;
        public BankAccountNumber(string value)
        {
            Value = value;
        }
        public string Value { get; }


        public static Result<BankAccountNumber> Create(string bankAccountNumber)
        {
            if (string.IsNullOrWhiteSpace(bankAccountNumber))
            {
                return Result.Failure<BankAccountNumber>(DomainErrors.BankAccountNumber.Empty);
            }

            if (bankAccountNumber.Length != MaxLength)
            {
                return Result.Failure<BankAccountNumber>(DomainErrors.BankAccountNumber.invalid);
            }

            return new BankAccountNumber(bankAccountNumber);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
