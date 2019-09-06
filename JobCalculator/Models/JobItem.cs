using JobCalculator.Models.Attributes;
using System.ComponentModel.DataAnnotations;

namespace JobCalculator.Models
{
    /// <summary>
    /// An object that represents a single item in a job
    /// </summary>
    public class JobItem
    {
        /// <summary>
        /// The name of a product
        /// </summary>
        [Display(Name = "Product Name")]
        [Required]
        public string ProductName { get; set; }

        /// <summary>
        /// The price of a product
        /// </summary>
        [Display(Name = "Product Price")]
        [ValidatePrice(ErrorMessage = "Invalid price. A price must be greater than zero!")]
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// The sales tax percentage of a product
        /// </summary>
        public decimal SalesTax => .07m;

        /// <summary>
        /// Whether or not a product is tax exempt
        /// </summary>
        [Display(Name = "Tax Exempt")]
        public bool TaxExempt { get; set; }
    }
}
