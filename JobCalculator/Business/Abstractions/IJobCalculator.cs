using JobCalculator.Models;

namespace JobCalculator.Business.Abstractions
{
    public interface IJobCalculator
    {
        JobReceipt CalculateJobCost(Job mockJob);
    }
}
