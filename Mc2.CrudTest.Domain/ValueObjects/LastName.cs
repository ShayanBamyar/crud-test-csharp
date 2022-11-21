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
    public sealed class LastName : ValueObject
    {
        public const int MaxLength = 150;
        public LastName(string value)
        {
            Value = value;
        }
        public string Value { get; }


        public static Result<LastName> Create(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return Result.Failure<LastName>(DomainErrors.LastName.Empty);
            }

            if (lastName.Length > MaxLength)
            {
                return Result.Failure<LastName>(DomainErrors.LastName.TooLong);
            }

            return new LastName(lastName);
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
