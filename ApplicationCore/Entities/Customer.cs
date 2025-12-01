using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyX.ClarioCRM.ApplicationCore.Entities
{
    /// <summary>
    /// Represents a customer organization that can have one or more associated contacts.
    /// </summary>
    /// <remarks>
    /// Instances of <see cref="Customer"/> are typically persisted by the application core
    /// and may be used as an aggregate root for related <see cref="Contact"/> entities.
    /// </remarks>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the company name for the customer.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets an optional description or notes about the customer.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the concurrency token used to detect conflicting updates.
        /// </summary>
        [ConcurrencyCheck]
        public Guid Version { get; set; }

        /// <summary>
        /// Gets or sets the collection of contacts that belong to this customer.
        /// The collection is initialized to an empty list to simplify usage and avoid null checks.
        /// </summary>
        public virtual List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}
