using System.Collections.Generic;

namespace JobCalculator.Models
{
    /// <summary>
    /// An object that holds data about a single job
    /// </summary>
    public class JobReceipt
    {
        /// <summary>
        ///  Empty Constructor
        /// </summary>
        public JobReceipt()
        {
            Products = new Dictionary<string, decimal>();
        }

        /// <summary>
        /// In-Memory key value store for list of products purchased
        /// </summary>
        /// <remarks>Product Name, Base Price of item + Item Tax</remarks>
        public Dictionary<string, decimal> Products { get; set; }

        /// <summary>
        /// The total cost of the job
        /// </summary>
        public decimal Total { get; set; }
    }
}
