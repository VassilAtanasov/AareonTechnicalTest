using AareonTechnicalTest.Controllers;
using AareonTechnicalTest.Models;
using AareonTechnicalTest.Services;
using Xunit;

namespace AareonTechnicalTest.Test
{
    public class PermissionServiceTests
    {
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void GetTickets_Returns_The_Correct_Results(bool isAdmin, bool expected)
        {
            // Arrange
            var testPerson = new Person { Forename = "John", Surname = "Smith", IsAdmin = isAdmin };
            var service = new PermissionService();

            // Act
            var result = service.DeleteNotesNotAllowed(testPerson);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}