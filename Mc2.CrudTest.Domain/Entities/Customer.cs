using Mc2.CrudTest.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Customer(Guid id) : base(id)
        {
        }
        [RegularExpression("^[a-zA-Z -']+$", ErrorMessage = "Invalid Firstname(Just Enter Charecter)")]
        [Required]
        public string FirstName { get; set; }
        [RegularExpression("^[a-zA-Z -']+$", ErrorMessage = "Invalid Firstname(Just Enter Charecter)")]
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Column(TypeName = "VARCHAR")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Invalid Phone Number(Just Enter Number)")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
