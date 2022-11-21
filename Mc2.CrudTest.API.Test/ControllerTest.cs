using Castle.Core.Resource;
using Mc2.CrudTest.API.Controllers;
using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Domain.Primitives;
using Mc2.CrudTest.Domain.Shared;
using Mc2.CrudTest.Domain.ValueObjects;
using Mc2.CrudTest.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit.Sdk;

namespace Mc2.CrudTest.API.Test
{
    public class ControllerTest
    {
        //private readonly Mock<RepositoryDbContext> _context;
        //private readonly CustomerBase _customer;
        //public ControllerTest()
        //{
        //    //Arrange
        //    _context = new Mock<RepositoryDbContext>();
        //    Guid id = new Guid();
        //    Email email = new Email("test@gmail.com");
        //    PhoneNumber phone = new PhoneNumber("989358428527");
        //    FirstName firstName = new FirstName("first name");
        //    LastName lastName = new LastName("last name");
        //    DateOfBirth dateOfBirth = new DateOfBirth(DateTime.Now.Date.ToString());
        //    BankAccountNumber bankAccountNumber = new BankAccountNumber("1234567891234567");

        //    _customer = new CustomerBase(id, firstName, lastName, email, phone, bankAccountNumber, dateOfBirth);
        //}

        //[Fact]
        //public void CustomerControllerTest()
        //{
        //    //Arrange
        //    var mockRepo = new Mock<RepositoryDbContext>();

        //    var controller = new CustomerController(mockRepo.Object);

        //    //Act
        //    var result_Index = controller.Index();
        //    var result_Details = controller.Details(new Guid());
        //    var result_Create_Get = controller.Create();
        //    var result_Create_Post = controller.Creat(_customer);
        //    var result_Edit_Get = controller.Edit(new Guid());
        //    var result_Edit_Post = controller.Edit(new Guid(), _customer);
        //    var result_Deletet = controller.Delete(new Guid());
            
        //    var result = controller.Edit(new Guid());
            

        //    //Assert
        //    Assert.IsType<ViewResult>(result_Index);
        //    Assert.IsType<ViewResult>(result_Details);
        //    Assert.IsType<ViewResult>(result_Create_Get);
        //    Assert.IsType<ViewResult>(result_Create_Post);
        //    Assert.IsType<ViewResult>(result_Edit_Get);
        //    Assert.IsType<ViewResult>(result_Edit_Post);
        //    Assert.IsType<ViewResult>(result_Deletet);


        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    var model = Assert.IsAssignableFrom<IEnumerable<RepositoryDbContext>>(viewResult.ViewData.Model);
        //    Assert.Equal(2, model.Count());


        }
    }

    internal interface IRepositoryDbContext<T>
    {
    }
}