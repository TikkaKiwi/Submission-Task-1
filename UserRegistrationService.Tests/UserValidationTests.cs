// Namespace declaration for the test class.
namespace UserRegistrationService.Tests;

// Attribute indicating this class contains test methods for MSTest.
[TestClass]
public class UserValidationTests
{
    //Data Test method to check that a username meets the required format.
    [DataTestMethod]
    // Data for valid usernames:
    [DataRow("FirstUser123")] // Data with a valid username.
    [DataRow("SecondUser123")] //Data with another valid username.
    public void IsUsernameValid_WithValidUsername_ShouldPass(string username)
    {
        // Arrange: Set up the UserRegistration instance and define a test username.
        UserRegistration userRegistration = new();

        // Act: Check if the username meets the format requirements.
        bool result = userRegistration.IsUsernameValid(username);

        // Assert: The username SHOULD meet the specified requirements.
        Assert.IsTrue(result, "Invalid Username");
    }

    //Data Test method to check that a username does NOT meets the required format.
    [DataTestMethod]
    // Data for invalid usernamers:
    [DataRow("firstUser123   Hello World")] // Data with a too long username.
    [DataRow("f!rstUs£r123")] // Data with non alphanumeric characters.
    [DataRow("bad")] // Data with a too short username.
    public void IsUsernameValid_WithInvalidUsername_ShouldFail(string username)
    {
        // Arrange: Set up the UserRegistration instance and define a test username.
        UserRegistration userRegistration = new();

        // Act: Check if the username meets the format requirements.
        bool result = userRegistration.IsUsernameValid(username);

        // Assert: The username should NOT meet the specified requirements.
        Assert.IsFalse(result, "Valid Username");
    }

    //Data Test method to verify that a password that includes at least one special character
    // and meets lenght criteria passes.
    [DataTestMethod]
    // Data for a valid password.
    [DataRow("tra!lp@ssword")] // Data with a valid password.
    public void IsPasswordValid_WithValidPassword_ShouldPass(string password)
    {
        // Arrange: Create a UserRegistration instance and a test password.
        UserRegistration userRegistration = new UserRegistration();

        // Act: Check if the password meets the requirements.
        bool result = userRegistration.IsPasswordValid(password);

        // Assert: The password SHOULD meet the specified requirements.
        Assert.IsTrue(result, "Invalid Password");
    }

    //Data Test method to verify that a password that does not include at least one special character
    // or meet the lenght criteria does not pass.
    [DataTestMethod]
    // Data for different types of invalid password.
    [DataRow("bad")] // Data with invalid passwrod.
    [DataRow("b@d")] // Data with password that breaks the lenght requirement.
    [DataRow("longbutbadpassword")] // Data with password that breaks the complexity requirement.
    public void IsPasswordValid_WithInvalidPassword_ShouldFail(string password)
    {
        // Arrange: Create a UserRegistration instance and a test password.
        UserRegistration userRegistration = new UserRegistration();

        // Act: Check if the password meets the requirements.
        bool result = userRegistration.IsPasswordValid(password);

        // Assert: The password should NOT meet the specified requirements.
        Assert.IsFalse(result, "Valid Password");
    }

    //Data Test method to verify that an email address meets the required format and passes.
    [DataTestMethod]
    // Data for different types of valid email.
    [DataRow("user.example@email.com")] 
    [DataRow("user+example@email.n-u")] 
    public void IsEmailValid_WithValidEmail_ShouldPass(string email)
    {
        // Arrange: Initialize UserRegistration.
        UserRegistration userRegistration = new UserRegistration();

        // Act: Check if the email meets the format requirements.
        bool result = userRegistration.IsEmailValid(email);

        // Assert: The email SHOULD be in the correct format.
        Assert.IsTrue(result, "Invalid Email");
    }

    // Data Test method to verify that an email address that deos not meet the required format fails.
    [DataTestMethod]
    // Data for different types of invalid email.
    [DataRow("exa!mple@email.com")] //Email with invalid wording befor @ sign.
    [DataRow("example@ema!il.com")] //Email with invalid wording after @ sign.
    [DataRow("example@email.co!m")] //Email with invalid wording in domain name.
    [DataRow("exampleemail.com")] //Eamil without @ sign.
    [DataRow("example@emailcom")] //Email without domain name.
    public void IsEmailValid_WithInvalidEmail_ShouldFail(string email)
    {
        // Arrange: Initialize UserRegistration.
        UserRegistration userRegistration = new();
        

        // Act: Check if the email meets the format requirements.
        bool result = userRegistration.IsEmailValid(email);

        // Assert: The email should NOT be in the correct format.
        Assert.IsFalse(result, "Valid Email");
    }
}
