using Microsoft.EntityFrameworkCore;
using School.Domain.Repositories.Access_Control;
using School.Infra;
using School.Infra.Repositories.Access_Control;
using School.MockData;
using School.Service.Access_Control;
using System;
using Xunit;

namespace School.xUnit
{
    public class UserTest
    {
        private readonly IUserRepository _userRepository;

        public UserTest()
        {
            //var options = new DbContextOptionsBuilder<AccessControlContext>()
            // .UseSqlServer("Server=MACND41115ZX\\SQLEXPRESS;Database=School;Trusted_Connection=true;MultipleActiveResultSets=true")
            // .UseLazyLoadingProxies()
            // .Options;


            //_userRepository = new UserRepository(new AccessControlContext(options));
            _userRepository = new MochkUserRepository();
        }

        [Theory]
        [InlineData("D624FB96-8B2C-412D-9E79-521E87B21C4F", "GetAllUSers", true)]
       // [InlineDataAttribute("D624FB96-8B2C-412D-9E79-521E87B21C4F", "GetAllRoles", false)]
        public void CheckUserPermission_User_ShouldHaveAccess(string userId,string actionName,bool expectedValue)
        {
            //Arrange
            var sut = new UserService(_userRepository);
            bool hasAccess = false;
            //Act
            hasAccess = sut.DoesUseHaveAccessTo(Guid.Parse(userId), actionName);
            //Assert
            Assert.Equal(expectedValue,hasAccess);
        }

        [Theory]
        [ClassData(typeof(UserFeaturesData))]
        public void CheckUserPermissionToMultipleFeatures(string userId, string actionName, bool expectedValue)
        {
            //Arrange
            var sut = new UserService(_userRepository);
            bool hasAccess = false;
            //Act
            hasAccess = sut.DoesUseHaveAccessTo(Guid.Parse(userId), actionName);
            //Assert
            Assert.Equal(expectedValue, hasAccess);
        }
        [Theory]
        [CsvUserFeatures("UserFeatures.csv")]
        public void CheckUserPermissionToMultipleFeaturesFromCsvFile(string userId, string actionName, bool expectedValue)
        {
            //Arrange
            var sut = new UserService(_userRepository);
            bool hasAccess = false;
            //Act
            hasAccess = sut.DoesUseHaveAccessTo(Guid.Parse(userId), actionName);
            //Assert
            Assert.Equal(expectedValue, hasAccess);
        }

    }
}
