using FluentAssertions;
using School.Contract;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace School.IntegrationTesting
{
    public class UserTest: BaseIntegrationTest
    {
        public UserTest()
        {

        }
        [Fact]
        public async Task GetAll_WithoutAuthentication_ReturnsUnauthorizedCode()
        {
            // Arrange

            // Act
            var response = await _baseTestClient.GetAsync(ApiRoutes.Roles.GetAll);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Fact]
        public async Task GetAll_WithAuthentication_ReturnOkCode()
        {
            // Arrange
             string token =await Authenticate();
            // Act
            var response = await _baseTestClient.GetAsync(ApiRoutes.Roles.GetAll);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
