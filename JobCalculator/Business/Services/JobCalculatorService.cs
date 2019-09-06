using JobCalculator.Business.Abstractions;
using JobCalculator.Models;
using System;

namespace JobCalculator.Business.Services
{
    /// <summary>
    /// Implementation of IJobCalculator
    /// </summary>
    public class JobCalculatorService : IJobCalculator
    {
        /// <summary>
        /// Method that calculates totals for a job
        /// </summary>
        /// <param name="mockJob"></param>
        /// <returns></returns>
        public JobReceipt CalculateJobCost(Job mockJob)
        {
            decimal beforeMarginTotal = 0;
            decimal margin = (mockJob.AddExtraMargin) ? mockJob.Margin + mockJob.ExtraMargin : mockJob.Margin;
            decimal marginTotal;
            JobReceipt receipt = new JobReceipt();
            decimal taxTotal = 0;                             
            
            // Loop through the products and calculate totals
            foreach (var item in mockJob.Items)
            {
                beforeMarginTotal += item.ProductPrice;

                var tax = (!item.TaxExempt) ? item.ProductPrice * item.SalesTax : 0;

                taxTotal += tax;

                // Round item total + tax to nearest cent
                receipt.Products.Add(item.ProductName, Math.Round(item.ProductPrice + tax, 2));
            }

            // Margin is calculated on totals without tax added
            marginTotal = beforeMarginTotal * margin;

            // Round total cost to nearest even cent
            receipt.Total = (0.02m / 1.00m) * decimal.Round((beforeMarginTotal + marginTotal + taxTotal) * (1.00m / 0.02m));

            return receipt;
        }
    }
}
