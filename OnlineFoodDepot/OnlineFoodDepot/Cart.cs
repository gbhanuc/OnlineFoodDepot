using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodDepot
{
    class Cart
    {
        #region properties
        /// <summary>
        /// Name if the selected Item
        /// </summary>
        public string Item { get; set; }
        /// <summary>
        /// Price of the item
        /// </summary>
        public int price { get; set; }
        // <summary>
        /// Tax collected for the total
        /// </summary>
        public decimal tax { get; set; }
        /// <summary>
        /// Shipping price for total value
        /// </summary>
        public decimal shippingprice { get; set; }
        /// <summary>
        /// Total price of all items
        /// </summary>
        public decimal subtotal { get; set; }

        #endregion

        #region methods

        #endregion


    }
}