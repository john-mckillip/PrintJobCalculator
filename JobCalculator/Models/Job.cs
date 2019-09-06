using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobCalculator.Models
{
    /// <summary>
    /// A group of print items
    /// </summary>
    public class Job
    {
        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Job()
        {
            Items = new List<JobItem>();
        }

        /// <summary>
        /// Adds specified number of empty itmes to Job Items
        /// </summary>
        public Job(int numberOfItems)
        {
            // Add empty items by default only to satisfy the requirements for this problem
            // These would usually be tied to some sort of ecommerce back-end
            Items = new List<JobItem>();

            for (int i = 0; i < numberOfItems; i++)
            {
                var item = new JobItem();
                Items.Add(item);
            }          
        }

        /// <summary>
        /// Whether or not a job should add an extra margin
        /// </summary>
        [Display(Name = "Add Extra Margin")]
        public bool AddExtraMargin { get; set; }

        /// <summary>
        /// The total extra margin
        /// </summary>
        public decimal ExtraMargin => .05m;

        /// <summary>
        /// The print items of a job
        /// </summary>
        public List<JobItem> Items { get; set; }

        /// <summary>
        /// The total base margin of a job
        /// </summary>
        public decimal Margin => .11m;
    }
}
