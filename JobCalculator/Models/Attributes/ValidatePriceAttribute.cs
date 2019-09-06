using System;
using System.ComponentModel.DataAnnotations;

namespace JobCalculator.Models.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidatePriceAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return Convert.ToDecimal(value) > 0;
        }
    }
}
