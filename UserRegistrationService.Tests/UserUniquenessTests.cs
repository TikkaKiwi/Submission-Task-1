// Namespace declaration for the test class.
namespace UserRegistrationService.Tests;

// Attribute indicating this class contains test methods for MSTest.
[TestClass]
public class UserUniquenessTests
{
    // Test to verify a user with duplicate username and email return false.
    [TestMethod]
    public void IsUserUnique_DuplicateUsernameAndEmail_ShouldFail()
    {
        //Arrange: Initialize UserRegistration class and two identical User objects.
        UserRegistration userRegistration = new();
        User newUser = new("firstUser123", "tra!lp@ssword", "user@example.com"); // Create a new user object with specific username, password, and email.
        userRegistration.RegisterUser(newUser); // Register the first user to add them to the list of registered users.
        User duplicateUser = new("firstUser123", "tra!lp@ssword", "user@example.com"); // Create another user object that has the same username and email as the first user to simulate a duplicate.

        //Act
        // Call the IsUserUnique method with the duplicate user to test if the method correctly identifies it as not unique.
        bool result = userRegistration.IsUserUnique(duplicateUser);

        //Assert: The duplicate User should return false as it contains an identical username and email as the newUser.
        Assert.IsFalse(result, "Email Was Unique");
    }

    // Test to verify a user with duplicate username return false.
    [TestMethod]
    public void IsUserUnique_DuplicateUsername_ShouldFail()
    {
        //Arrange: Initialize UserRegistration class and two identical User objects.
        UserRegistration userRegistration = new();
        User newUser = new("firstUser123", "tra!lp@ssword", "user@example.com"); // Create a new user object with specific username, password, and email.
        userRegistration.RegisterUser(newUser); // Register the first user to add them to the list of registered users.
        User duplicateUser = new("firstUser123", "tra!lp@ssword", "proper@email.com"); // Create another user object that has the same username as the first user to simulate a duplicate.

        //Act
        // Call the IsUserUnique method with the duplicate user to test if the method correctly identifies it as not unique.
        bool result = userRegistration.IsUserUnique(duplicateUser);

        //Assert: The duplicate User should return false as it contains an identical username as the newUser.
        Assert.IsFalse(result, "USername Was Unique");
    }

    // Test to verify a user with duplicate email return false.
    [TestMethod]
    public void IsUserUnique_DuplicateEmail_ShouldFail()
    {
        //Arrange: Initialize UserRegistration class and two identical User objects.
        UserRegistration userRegistration = new();
        User newUser = new("firstUser123", "tra!lp@ssword", "user@example.com"); // Create a new user object with specific username, password, and email.
        userRegistration.RegisterUser(newUser); // Register the first user to add them to the list of registered users.
        User duplicateUser = new("secondUser123", "tra!lp@ssword", "user@example.com"); // Create another user object that has the same email as the first user to simulate a duplicate.

        //Act
        // Call the IsUserUnique method with the duplicate user to test if the method correctly identifies it as not unique.
        bool result = userRegistration.IsUserUnique(duplicateUser);

        //Assert: The duplicate User should return false as it contains an identical email as the newUser.
        Assert.IsFalse(result, "User Not In List");
    }

    // Test to verify a user with unique username and email return true.
    [TestMethod]
    public void IsUserUnique_UniqueUser_ShouldPass()
    {
        //Arrange: Initialize UserRegistration class and two identical User objects.
        UserRegistration userRegistration = new();
        User newUser = new("firstUser123", "tra!lp@ssword", "user@example.com"); // Create a new user object with specific username, password, and email.
        userRegistration.RegisterUser(newUser); // Register the first user to add them to the list of registered users.
        User duplicateUser = new("uniqueUser321", "tra!lp@ssword", "unique@email.com"); // Create another unique user.

        //Act
        // Call the IsUserUnique method with the unique user to test if the method correctly identifies it as unique.
        bool result = userRegistration.IsUserUnique(duplicateUser);

        //Assert: The unique User should return true as it contains unique information.
        Assert.IsTrue(result, "User Already In List");
    }
}
