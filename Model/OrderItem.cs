using System.Diagnostics;
using System.Xml.Linq;

namespace Model
{
    public class OrderItem
    {
        public  int id { get; set; }
        public Product Product { get; set; } = null!;
        public float Qty { get; set; }
        public double SalePrice { get; set; }
        public  double TotalPrice { get; set; }

        #region Constructors
        public OrderItem(
            int id,
            Product product,
            float qty,
            double salePrice,
            double totalPrice)
        {
            this.id = id;
            Product = product;
            Qty = qty;
            SalePrice = salePrice;
            TotalPrice = totalPrice;
        }
        #endregion

        /// <summary>
        /// Valida se nome é vazio e valor <= 0
        /// </summary>
        /// <returns>boolean</returns>
        
        #region Validation
        public bool Validate()
        {
           if (Product == null)
                return false;
            if (Qty <= 0)
                return false;
            if (SalePrice <= 0)
                return false;
            if (TotalPrice <= 0)
                return false;

            return true;

        }
        #endregion

    }
}
