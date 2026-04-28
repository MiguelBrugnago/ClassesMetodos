
namespace Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }

        #region Constructors

        public Product()
        {

        }

        public Product(int id, string name, double price)
        {
            this.Id = id;
            Name = name;
            Price = price;
        }
        #endregion

        /// <summary>
        /// Valida se nome é vazio e valor <= 0
        /// </summary>
        /// <returns>boolean</returns>
        
        #region Validation
        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;
            if (Price <= 0)
                return false;

            return true;

        }
        #endregion
    }
}
