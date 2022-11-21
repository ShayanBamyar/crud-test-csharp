

using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Domain.ValueObjects;
using Mc2.CrudTest.Domain.ValueObjects.Services;
using System.Diagnostics;
using System.Globalization;
using static Mc2.CrudTest.Domain.Errors.DomainErrors;

namespace Mc2.CrudTest.Domain.Test
{
    public class CustomerTest
    {

        [Fact]
        public void Check_PhoneNumber()
        {
            //Arrenge
            string phone1 = "989358428527";
            string phone2 = "+989358428527";
            string phone3 = "9893584";
            //Act
            bool isValid1 = PhoneNemberValidation.CheckPhoneNumber(phone1);
            bool isValid2 = PhoneNemberValidation.CheckPhoneNumber(phone2);
            bool isValid3 = PhoneNemberValidation.CheckPhoneNumber(phone3);
            //Asserst
            Assert.Equal(true, isValid1);
            Assert.Equal(true, isValid2);
            Assert.Equal(false, isValid3);
        }

        [Fact]
        public void Customer()
        {
            //Arrenge
            Guid id = new Guid();
            ValueObjects.Email email = new ValueObjects.Email("test@gmail.com");
            ValueObjects.PhoneNumber phone = new ValueObjects.PhoneNumber("989358428527");
            ValueObjects.FirstName firstName = new ValueObjects.FirstName("first name");
            ValueObjects.LastName lastName = new ValueObjects.LastName("last name");
            ValueObjects.DateOfBirth dateOfBirth = new ValueObjects.DateOfBirth(DateTime.Now.Date.ToString());
            ValueObjects.BankAccountNumber bankAccountNumber = new ValueObjects.BankAccountNumber("1234567891234567");
            Type type = typeof(CustomerBase);

            //Act
            CustomerBase customer = new CustomerBase(id,firstName,lastName,email,phone,bankAccountNumber,dateOfBirth);
            int NumberOfRecords = type.GetProperties().Length;

            //Assert
            Assert.Equal(customer.Id, id);
            Assert.Equal(customer.FirstName,firstName);
            Assert.Equal(customer.LastName,lastName);
            Assert.Equal(customer.Email,email);
            Assert.Equal(customer.PhoneNumber,phone);
            Assert.Equal(customer.DateOfBirth, dateOfBirth);
            Assert.Equal(customer.BankAccountNumber, bankAccountNumber);

            Assert.Equal(7, NumberOfRecords);

        }
    }
}