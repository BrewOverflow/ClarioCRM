using CompanyX.ClarioCRM.ApplicationCore.Entities; 
using CompanyX.ClarioCRM.ApplicationCore.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyX.ClarioCRM.Infrastructure.Repositories
{
    /// <summary>
    /// Repository implementation that persists customers using an EF Core DbContext.
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext DbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context used for persistence.</param>
        public CustomerRepository(CustomerDbContext dbContext)
        {
            DbContext = dbContext;
        }

        /// <summary>
        /// Asynchronously creates a new customer.
        /// </summary>
        /// <param name="cst">The customer to create.</param>
        public Task CreateCustomerAsync(Customer cst)
        {
            DbContext.Customers.Add(cst);
            return DbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronously deletes a customer by identifier.
        /// </summary>
        /// <param name="customerId">The identifier of the customer to delete.</param>
        public Task DeleteCustomerAsync(string customerId)
        {
            var customerToBeDeleted = DbContext.Customers.First(c => c.CustomerId == customerId);
            DbContext.Customers.Remove(customerToBeDeleted);
            return DbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the total number of customers.
        /// </summary>
        /// <returns>The total customer count.</returns>
        public int GetTotalCustomerCount()
        {
            var totalCount = DbContext.Customers
                            .ToList()
                            .Count();

            return totalCount;
        }

        /// <summary>
        /// Asynchronously updates an existing customer.
        /// </summary>
        /// <param name="customer">The customer with updated data.</param>
        public Task UpdateCustomerAsync(Customer customer)
        {
            try
            {
                DbContext.Customers.Update(customer);
                return DbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine($"{ex.Message}\r\n{ex.StackTrace}");
                throw ex;
            }
         }
    }
}
