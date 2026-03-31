using System.Diagnostics;
using System.Xml.Linq;
using static Core.Enums.Enums;

namespace Model
{

    public class Order
    {
        public int id { get; set; }
        public Customer Customer { get; set; } = null!;
        public List<OrderItem> OrderItems { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get ; set; } = OrderStatus.Openned;

        #region Constructors
        public Order(int id, Customer customer, List<OrderItem> orderItems, DateTime orderDate, OrderStatus orderStatus)
        {
            this.id = id;
            Customer = customer;
            OrderItems = orderItems;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }
        #endregion

        /// <summary>
        /// Valida se nome é vazio e valor <= 0
        /// </summary>
        /// <returns>boolean</returns>
       
        #region Validation
        public bool Validate()
        {
           if (Customer == null)
                return false;
            if (OrderItems == null || OrderItems.Count == 0)
                return false;
            if (OrderDate == default)
                return false;

            return true;

        }
        #endregion
    }

}
