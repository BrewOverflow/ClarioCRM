using CompanyX.ClarioCRM.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyX.ClarioCRM.ApplicationCore.Interfaces.Repositories
{
    /// <summary>
    /// Repository abstraction for managing <see cref="Customer"/> entities.
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// Asynchronously creates a new customer.
        /// </summary>
        /// <param name="cst">The customer to create.</param>
        Task CreateCustomerAsync(Customer cst);

        /// <summary>
        /// Asynchronously deletes a customer by identifier.
        /// </summary>
        /// <param name="customerId">The identifier of the customer to delete.</param>
        Task DeleteCustomerAsync(string customerId);

        /// <summary>
        /// Asynchronously updates an existing customer.
        /// </summary>
        /// <param name="customer">The customer with updated data.</param>
        Task UpdateCustomerAsync(Customer customer);

        /// <summary>
        /// Gets the total number of customers.
        /// </summary>
        /// <returns>The total customer count.</returns>
        int GetTotalCustomerCount();
    }
}
