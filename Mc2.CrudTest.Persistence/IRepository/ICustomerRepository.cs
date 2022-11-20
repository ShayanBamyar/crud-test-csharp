using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Persistence.IRepository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Persistence.IRepository
{
    public interface ICustomerRepository : IRepositoryBase<CustomerBase>
    {
        Task<IEnumerable<CustomerBase>> GetAllCustomersAsync();
        Task<CustomerBase> GetCustomerByIdAsync(Guid customerId);
        Task<CustomerBase> GetCustomerWithDetailsAsync(Guid customerId);
        void CreateCustomer(CustomerBase customer);
        void UpdateCustomer(CustomerBase customer);
        void DeleteCustomer(CustomerBase customer);
    }
}
