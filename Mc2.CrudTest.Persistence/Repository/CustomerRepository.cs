using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Persistence.IRepository;
using Mc2.CrudTest.Persistence.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Persistence.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await FindAll()
               .OrderBy(x => x.Id)
               .ToListAsync();
        }
        public async Task<Customer> GetCustomerByIdAsync(Guid customerId)
        {
            return await FindByCondition(customer => customer.Id.Equals(customerId))
                .FirstOrDefaultAsync();
        }
        public async Task<Customer> GetCustomerWithDetailsAsync(Guid customerId)
        {
            return await FindByCondition(customer => customer.Id.Equals(customerId))
                .Include(x => x.Email)
                .FirstOrDefaultAsync();
        }
        public void CreateCustomer(Customer customer)
        {
            Create(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            Update(customer);
        }
        public void DeleteCustomer(Customer customer)
        {
            Delete(customer);
        }
    }

}
