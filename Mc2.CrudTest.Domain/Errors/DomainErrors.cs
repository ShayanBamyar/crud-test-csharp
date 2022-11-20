using Mc2.CrudTest.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Domain.Errors
{
    public static class DomainErrors
    {
        public static class Email
        {
            public static readonly Error Empty = new(
                "Email.Empty",
                "Email is empty.");

            public static readonly Error InvalidFormat = new(
                "Email.InvalidFormat",
                "Email format is invalid.");
        }

        public static class FirstName
        {
            public static readonly Error Empty = new(
                "FirstName.Empty",
                "First name is empty.");

            public static readonly Error TooLong = new(
                "LastName.TooLong",
                "FirstName name is too long.");
        }

        public static class LastName
        {
            public static readonly Error Empty = new(
                "LastName.Empty",
                "Last name is empty.");

            public static readonly Error TooLong = new(
                "LastName.TooLong",
                "Last name is too long.");
        }

        public static class PhoneNumber
        {
            public static readonly Error Empty = new(
                "PhoneNumber.Empty",
                "Phone number is empty.");

            public static readonly Error invalid = new(
                "PhoneNumber.invalid",
                "Invalid Phone number.");
        }

        public static class DateOfBirth
        {
            public static readonly Error Empty = new(
                "DateOfBirth.Empty",
                "Date of birth is empty.");

            public static readonly Error invalid = new(
                "DateOfBirth.invalid",
                "Date of birth is invalid.");


        }

        public static class BankAccountNumber
        {
            public static readonly Error Empty = new(
                "BankAccountNumber.Empty",
                "Bank account number is empty.");

            public static readonly Error invalid = new(
                "BankAccountNumber.invalid",
                "Invalid Bank account number.");
        }
    }
}
