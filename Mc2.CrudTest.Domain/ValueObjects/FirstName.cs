using Mc2.CrudTest.Domain.Errors;
using Mc2.CrudTest.Domain.Primitives;
using Mc2.CrudTest.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Domain.ValueObjects
{
    public sealed class FirstName : ValueObject
    {
        public const int MaxLength = 150;
        private FirstName(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static Result<FirstName> Create(string FirstName)
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                return Result.Failure<FirstName>(DomainErrors.FirstName.Empty);
            }

            if (FirstName.Length > MaxLength)
            {
                return Result.Failure<FirstName>(DomainErrors.FirstName.TooLong);
            }

            return new FirstName(FirstName);
        }



        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
