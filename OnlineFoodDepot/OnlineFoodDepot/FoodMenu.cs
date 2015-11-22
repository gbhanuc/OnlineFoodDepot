using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodDepot
{
    class FoodMenu
    {
        #region properties
        /// <summary>
        /// Name of the FoodItem
        /// </summary>
        public string FoodName { get; set; }
        /// <summary>
        /// Price of the selected FoodItem
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// calories associated with the selected FoodItem
        /// </summary>
        public decimal Calories { get; set; }
        /// <summary>
        /// Sppice level associated with the selected food
        /// </summary>
        public object Spicelevel { get; set; }

        #endregion

        #region Methods

        #endregion
    }
}