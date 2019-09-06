using System.ComponentModel.DataAnnotations;

namespace JobCalculator.Models.ViewModels
{
    public class HomeViewModel
    {     
        public Job MockJob { get; set; }

        [Display(Name = "Number of Products")]
        public int NumberOfProducts { get; set; }
    }
}
