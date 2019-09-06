using JobCalculator.Models;
using System.Collections;
using System.Collections.Generic;

namespace JobCalculator.Tests
{
    public class JobTestData
    {
        public static IEnumerable GetTestCases()
        {          
            var testCases = new List<TestJob>();
            
            var jobOne = new Job
            {
                AddExtraMargin = true
            };

            var jobOneItemOne = new JobItem
            {
                ProductName = "envelopes",
                ProductPrice = 520.00m
            };

            jobOne.Items.Add(jobOneItemOne);

            var jobOneItemTwo = new JobItem
            {
                ProductName = "letterhead",
                ProductPrice = 1983.37m,
                TaxExempt = true
            };

            jobOne.Items.Add(jobOneItemTwo);

            var testJobOne = new TestJob
            {
                ExpectedResult = 2940.30m,
                MockJob = jobOne
            };

            testCases.Add(testJobOne);

            var jobTwo = new Job();

            var jobTwoItemOne = new JobItem
            {
                ProductName = "t-shirts",
                ProductPrice = 294.04m
            };

            jobTwo.Items.Add(jobTwoItemOne);
           
            var testJobTwo = new TestJob
            {
                ExpectedResult = 346.96m,
                MockJob = jobTwo
            };

            testCases.Add(testJobTwo);

            var jobThree = new Job
            {
                AddExtraMargin = true
            };

            var jobThreeItemOne = new JobItem
            {
                ProductName = "frisbees",
                ProductPrice = 19385.38m,
                TaxExempt = true
            };

            jobThree.Items.Add(jobThreeItemOne);

            var jobThreeItemTwo = new JobItem
            {
                ProductName = "yo-yos",
                ProductPrice = 1829.0m,
                TaxExempt = true
            };

            jobThree.Items.Add(jobThreeItemTwo);

            var testJobThree = new TestJob
            {
                ExpectedResult = 24608.68m,
                MockJob = jobThree
            };

            testCases.Add(testJobThree);

            return testCases;
        }
    }

    public class TestJob
    {
        public decimal ExpectedResult { get; set; }
        public Job MockJob { get; set; }        
    }
}
