using API.Controllers;
using API.Data;
using FakeItEasy;
using Xunit;

namespace API.Tests;


public class UsersControllersTest
{
    //TODO - Finish Writing Unit Tests
    [Fact]
    public void GetUsers_ShouldReturnAllUsers()
    {
        //Arrange
        var dataContext = A.Fake<DataContext>();
        var userController = new UsersController(dataContext);
        //Act

        //Assert
    }
}