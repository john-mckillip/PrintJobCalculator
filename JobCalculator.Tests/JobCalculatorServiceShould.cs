using JobCalculator.Business.Services;
using NUnit.Framework;

namespace JobCalculator.Tests
{
    public class JobCalculatorServiceShould
    {
        [Test]
        [TestCaseSource(typeof(JobTestData), "GetTestCases")]
        public void CalculateCorrectJobTotal(TestJob job)
        {
            var sut = new JobCalculatorService();

            var receipt = sut.CalculateJobCost(job.MockJob);

            Assert.That(receipt.Total, Is.EqualTo(job.ExpectedResult));
        } 
    }
}
