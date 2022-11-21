using Mc2.CrudTest.Domain.Primitives;
using Mc2.CrudTest.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Mc2.CrudTest.Domain.Entities
{
    public class CustomerBase : AggregateRoot
    {

        public CustomerBase(Guid id,  FirstName firstName, LastName lastName, Email email,PhoneNumber phoneNumber
                        ,BankAccountNumber bankAccountNumber, DateOfBirth dateOfBirth)
        : base(id)
        {      
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            BankAccountNumber = bankAccountNumber;
            DateOfBirth = dateOfBirth;
        }
        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public Email Email { get; set; }
        public PhoneNumber PhoneNumber { get; set;}
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateOfBirth DateOfBirth { get; set; }
        public BankAccountNumber BankAccountNumber { get; set; }
    }
}
