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
    public sealed class DateOfBirth : ValueObject
    {
        public DateTime Today = DateTime.UtcNow;
        public DateOfBirth(string value)
        {
            Value = value;
        }
        public string Value { get; }


        public static Result<DateOfBirth> Create(DateTime dateOfBirth)
        {
            if (string.IsNullOrWhiteSpace(dateOfBirth.ToString()))
            {
                return Result.Failure<DateOfBirth>(DomainErrors.DateOfBirth.Empty);
            }

            if (dateOfBirth.Date > DateTime.Now.Date)
            {
                return Result.Failure<DateOfBirth>(DomainErrors.DateOfBirth.invalid);
            }

            return new DateOfBirth(dateOfBirth.ToString());
        }

        public override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
