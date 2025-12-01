using CompanyX.ClarioCRM.ApplicationCore.Entities;
using CompanyX.ClarioCRM.ApplicationCore.Interfaces.Repositories;
using CompanyX.ClarioCRM.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyX.ClarioCRM.ApplicationCore.Services
{
    /// <summary>
    /// Service that coordinates actions related to customers using a repository.
    /// </summary>
    public class CustomerService : CustomerServiceInterface
    {
        private readonly ICustomerRepository _customerRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerService"/> class.
        /// </summary>
        /// <param name="repository">Repository used to persist customers.</param>
        public CustomerService(ICustomerRepository repository)
        {
            _customerRepository = repository;
        }

        /// <summary>
        /// Asynchronously creates a new customer.
        /// </summary>
        /// <param name="customer">The customer to create.</param>
        public Task CreateCustomerAsync(Customer customer)
        {
            return _customerRepository.CreateCustomerAsync(customer);
        }

        /// <summary>
        /// Asynchronously deletes a customer by identifier.
        /// </summary>
        /// <param name="customerId">The identifier of the customer to delete.</param>
        public Task DeleteCustomerAsync(string customerId)
        {
            return _customerRepository.DeleteCustomerAsync(customerId);
        }

        /// <summary>
        /// Gets the total number of customers.
        /// </summary>
        /// <returns>The total customer count.</returns>
        public int GetTotalCustomerCount()
        {
            return _customerRepository.GetTotalCustomerCount();
        }

        /// <summary>
        /// Asynchronously updates an existing customer.
        /// </summary>
        /// <param name="customer">The customer with updated data.</param>
        public Task UpdateCustomerAsync(Customer customer)
        {
            return _customerRepository.UpdateCustomerAsync(customer);
        }
    }
}
