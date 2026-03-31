

namespace Model
{
    public class Address
    {
        #region Properties
        public int id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string FederalState { get; set; } = string.Empty;
        #endregion

        #region Constructors
        public Address() 
        { 

        }

        public Address(
            int id,
            string street,
            string number,
            string city,
            string postalCode,
            string country,
            string federalState
            )
        {
            this.id = id;
            Street = street;
            Number = number;
            City = city;
            PostalCode = postalCode;
            Country = country;
            FederalState = federalState;
        }

        #endregion
    }
}
