using System.Diagnostics;
using System.Xml.Linq;

namespace Model
{
    public class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Address? HomeAddress { get; set; }
        public Address ShippingAddress { get; set; } = null!;

        #region Constructors
        public Customer()
        {

        }

        public Customer(
            int id,
            string firstName,
            string lastName,
            string email,
            string phone,
            Address? homeAddress,
            Address shippingAddress
            )
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            HomeAddress = homeAddress;
            ShippingAddress = shippingAddress;
        }
        #endregion

        /// <summary>
        /// Valida se nome é vazio e valor <= 0
        /// </summary>
        /// <returns>boolean</returns>
        
        #region Validation
        public bool Validate()
        {
           if (string.IsNullOrWhiteSpace(FirstName))
                return false;
            if (string.IsNullOrWhiteSpace(LastName))
                return false;
            if (string.IsNullOrWhiteSpace(Email))
                return false;
            if (string.IsNullOrWhiteSpace(Phone))
                return false;
            if (ShippingAddress == null)
                return false;

            return true;
        }
        #endregion

    }
}


