// Namespace declaration for the test class.
namespace UserRegistrationService.Tests;

// Attribute indicating this class contains test methods for MSTest.
[TestClass]
public class UserRegistrationTests
{
    // Test method to ensure that a user can be successfully registered 
    // with a username and password that meet specific criteria.
    [TestMethod]
    public void RegisterUser_WithProperUsernameAndPasswordAndEmail_ShouldPass()
    {
        // Arrange: Set up the UserRegistration instance and a new user object.
        UserRegistration userRegistration = new UserRegistration();
        User newUser = new("firstUser123", "tra!lp@ssword", "user@example.com");


        // Act: Attempt to register the new user.
        bool result = userRegistration.RegisterUser(newUser);

        // Assert: Verify that registration was successful (result is true).
        Assert.IsTrue(result, "User Not Registerd"); // Check if the user was successfully registered.
    }

    // Test method to ensure that a user with an invalid username can not
    // be registered.
    [TestMethod]
    public void RegisterUser_WithInvalidUsername_ShouldFail()
    {
        // Arrange: Set up the UserRegistration instance and a new user object with an invalid username.
        UserRegistration userRegistration = new UserRegistration();
        User newUser = new("f!rstUs£r123   Hello World", "tra!lp@ssword", "user@example.com");


        // Act: Attempt to register the new user.
        bool result = userRegistration.RegisterUser(newUser);

        // Assert: Verify that registration failed (result is false).
        Assert.IsFalse(result, "User Still Registerd"); // Check if the user failed to registered.
    }

    // Test method to ensure that a user with an invalid password can not
    // be registered.
    [TestMethod]
    public void RegisterUser_WithInvalidPassword_ShouldFail()
    {
        // Arrange: Set up the UserRegistration instance and a new user object with an invalid password.
        UserRegistration userRegistration = new UserRegistration();
        User newUser = new("firstUser123", "bad", "user@example.com");


        // Act: Attempt to register the new user.
        bool result = userRegistration.RegisterUser(newUser);

        // Assert: Verify that registration failed (result is false).
        Assert.IsFalse(result, "User Still Registerd"); // Check if the user failed to registered.
    }

    // Test method to ensure that a user with an invalid email can not
    // be registered.
    [TestMethod]
    public void RegisterUser_WithInvalidEmail_ShouldFail()
    {
        // Arrange: Set up the UserRegistration instance and a new user object with an invalid email.
        UserRegistration userRegistration = new UserRegistration();
        User newUser = new("firstUser123", "tra!lp@ssword", "bademail.com");


        // Act: Attempt to register the new user.
        bool result = userRegistration.RegisterUser(newUser);

        // Assert: Verify that registration failed (result is false).
        Assert.IsFalse(result, "User Still Registerd"); // Check if the user failed to registered.
    }

    // Test method to ensure that a duplicateuser can not be registered.
    [TestMethod]
    public void RegisterUser_RegesteringDuplicateUser_ShouldFail()
    {
        // Arrange: Set up the UserRegistration instance and a new user object and a duplicate user.
        UserRegistration userRegistration = new UserRegistration();
        User newUser = new("firstUser123", "tra!lp@ssword", "user@example.com");
        User duplicateUser = newUser;


        // Act: Attempt to register the new user and the duplicate user.
        userRegistration.RegisterUser(newUser);
        bool result = userRegistration.RegisterUser(duplicateUser);

        // Assert: Verify that registration failed (result is false).
        Assert.IsFalse(result, "User Already Registerd"); // Check if the user failed to register.
    }

    // Test method to ensure that a user can be found within the RegisteredUsers list.
    [TestMethod]
    public void RegisterUser_NewUserShouldBeAddedToList_ShouldPass()
    {
        // Arrange: Set up the UserRegistration instance and a new user object.
        UserRegistration userRegistration = new UserRegistration();
        User newUser = new("firstUser123", "tra!lp@ssword", "user@example.com");

        // Act: Attempt to register the new user.
        bool result = userRegistration.RegisterUser(newUser);

        // Assert: verify that the newUser object is now in the RegisteredUsers list.
        Assert.IsTrue(userRegistration.RegisteredUsers.Contains(newUser), "User Not Found in List"); // Verify the user is in the list.
    }
}
