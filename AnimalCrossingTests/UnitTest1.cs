using System;
using AnimalCrossing;
using AnimalCrossing.Models;
using Xunit;

namespace AnimalCrossingTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddMethodWithTwoPositiveNumbers()
        {
            //Arrange - instan. classes etc.
            var testService = new TestService();

            //Act - Call the method to test
            int result = testService.Add(2, 5);

            //Assert - Check if you get the right result back
            Assert.Equal(7, result);
        }
    }
}
