using Mc2.CrudTest.Domain.Primitives;
using Mc2.CrudTest.Domain.ValueObjects;


namespace Mc2.CrudTest.Domain.Entities
{
    public class CustomerBase : BaseEntity
    {
        public CustomerBase(Guid id,  FirstName firstName, LastName lastName, Email email,PhoneNumber phoneNumber
                        ,BankAccountNumber bankAccountNumber)
        : base(id)
        {      
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            BankAccountNumber = bankAccountNumber;
        }
        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public Email Email { get; set; }
        public PhoneNumber PhoneNumber { get; set;}
        public DateOfBirth DateOfBirth { get; set; }
        public BankAccountNumber BankAccountNumber { get; set; }
    }
}
