// Namespace declaration for the test class.
namespace UserRegistrationService.Tests;

// Attribute indicating this class contains test methods for MSTest.
[TestClass]
public class UserValidationTests
{
    // Test method to check that a username meets the required format.
    [TestMethod]
    public void IsUsernameValid_WithValidUsername_ShouldPass()
    {
        // Arrange: Set up the UserRegistration instance and define a test username.
        UserRegistration userRegistration = new();
        string username = "firstUser123";

        // Act: Check if the username meets the format requirements.
        bool result = userRegistration.IsUsernameValid(username);

        // Assert: The username SHOULD meet the specified requirements.
        Assert.IsTrue(result, "Invalid Username");
    }

    // Test method to check that a username does NOT meets the required format.
    [TestMethod]
    public void IsUsernameValid_WithInvalidUsername_ShouldFail()
    {
        // Arrange: Set up the UserRegistration instance and define a test username.
        UserRegistration userRegistration = new();
        string username = "f!rstUs£r123   Hello World";

        // Act: Check if the username meets the format requirements.
        bool result = userRegistration.IsUsernameValid(username);

        // Assert: The username should NOT meet the specified requirements.
        Assert.IsFalse(result, "Valid Username");
    }

    // Test method to verify that a password that includes at least one special character
    // and meets lenght criteria passes.
    [TestMethod]
    public void IsPasswordValid_WithValidPassword_ShouldPass()
    {
        // Arrange: Create a UserRegistration instance and a test password.
        UserRegistration userRegistration = new UserRegistration();
        string password = "tra!lp@ssword";

        // Act: Check if the password meets the requirements.
        bool result = userRegistration.IsPasswordValid(password);

        // Assert: The password SHOULD meet the specified requirements.
        Assert.IsTrue(result, "Invalid Password");
    }

    // Test method to verify that a password that does not include at least one special character
    // or meet the lenght criteria does not pass.
    [TestMethod]
    public void IsPasswordValid_WithInvalidPassword_ShouldFail()
    {
        // Arrange: Create a UserRegistration instance and a test password.
        UserRegistration userRegistration = new UserRegistration();
        string password = "bad";

        // Act: Check if the password meets the requirements.
        bool result = userRegistration.IsPasswordValid(password);

        // Assert: The password should NOT meet the specified requirements.
        Assert.IsFalse(result, "Valid Password");
    }

    // Test method to verify that an email address meets the required format and passes.
    [TestMethod]
    public void IsEmailValid_WithValidEmail_ShouldPass()
    {
        // Arrange: Initialize UserRegistration and define a test email address.
        UserRegistration userRegistration = new UserRegistration();
        string email = "user@example.com";

        // Act: Check if the email meets the format requirements.
        bool result = userRegistration.IsEmailValid(email);

        // Assert: The email SHOULD be in the correct format.
        Assert.IsTrue(result, "Invalid Email");
    }

    // Test method to verify that an email address that deos not meet the required format fails.
    [TestMethod]
    public void IsEmailValid_WithInvalidEmail_ShouldFail()
    {
        // Arrange: Initialize UserRegistration and define a test email address.
        UserRegistration userRegistration = new();
        string email = "bademail.com";

        // Act: Check if the email meets the format requirements.
        bool result = userRegistration.IsEmailValid(email);

        // Assert: The email should NOT be in the correct format.
        Assert.IsFalse(result, "Valid Email");
    }
}
