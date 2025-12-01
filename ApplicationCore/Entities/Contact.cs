using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyX.ClarioCRM.ApplicationCore.Entities
{
    /// <summary>
    /// Represents an individual contact person associated with a <see cref="Customer"/>.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets the unique identifier for the contact.
        /// </summary>
        public string ContactId { get; set; }

        /// <summary>
        /// Gets or sets the contact's full name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the contact's gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the contact's job title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the contact's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the contact's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the parent customer for this contact.
        /// </summary>
        public Customer Customer { get; set; }
    }

}
