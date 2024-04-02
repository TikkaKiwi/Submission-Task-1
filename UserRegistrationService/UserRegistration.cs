// Necessary imports for regular expressions and the UserRegistrationService namespace.
using System.Text.RegularExpressions;


namespace UserRegistrationService;

public class UserRegistration
{
    // A list to hold the registered users. It's exposed as a read-only property.
    public List<User> RegisteredUsers { get; } = new List<User>();

    // Attempts to register a user. Returns true if successful, false otherwise.
    public bool RegisterUser(User user)
    {
        // Validate the user's input. Checks include:
        // - Username meets specific format and length requirements
        // - Password includes at least one non-alphanumeric character and meets the length requirement
        // - Email address follows a valid format
        // - Username & Email is unique within the registered users (no duplicates)
        // If any check fails, return false.
        if (!IsUsernameValid(user.username) ||
            !IsPasswordValid(user.password) ||
            !IsEmailValid(user.email) ||
            !IsUserUnique(user))
        {
            return false; // Early return if validation fails
        }

        // If all checks pass, add the user to the registered users list.
        RegisteredUsers.Add(user);
        return true; // Indicate success
    }


    // Validates the username according to specific rules.
    public bool IsUsernameValid(string username)
    {
        // Regex pattern for checking if username is alphanumeric.
        string regexPattern = @"^[a-zA-Z0-9]+$";
        // Check if username matches the pattern and its length is within the required range.
        // Also check if the username is not null or empty.
        if (!Regex.IsMatch(username, regexPattern) ||
            username.Length < 5 ||
            username.Length > 20 ||
            string.IsNullOrEmpty(username))
        {
            return false; // If any condition fails, return false
        }

        return true; // Username passes all checks
    }

    // Validates the password according to specific rules.
    public bool IsPasswordValid(string password)
    {
        // Regex pattern to check for at least one non-alphanumeric character.
        string regexPattern = @"[^a-zA-Z0-9]";
        // Check if password includes a non-alphanumeric character and meets the length requirement.
        if (!Regex.IsMatch(password, regexPattern) ||
            password.Length < 8)
        {
            return false; // If any condition fails, return false
        }

        return true; // Password passes all checks
    }

    // Validates the email address according to a specific pattern.
    public bool IsEmailValid(string email)
    {
        // Regex pattern for a basic email format validation.
        string regexPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        // Check if email matches the pattern.
        if (!Regex.IsMatch(email, regexPattern))
        {
            return false; // If the check fails, return false
        }

        return true; // Email passes the check
    }

    // Method to check if the provided user is unique in terms of username and email.
    public bool IsUserUnique(User user)
    {
        // Check if there is any user in the RegisteredUsers list with the same username or email as the provided user.
        // The LINQ Any method iterates over the RegisteredUsers list and looks for any matches based on the provided conditions.
        if (RegisteredUsers.Any(u => u.username == user.username) || // Check for an existing user with the same username
            RegisteredUsers.Any(u => u.email == user.email))         // Check for an existing user with the same email
        {
            return false; // If a match is found for either condition, return false indicating the user is not unique.
        }

        // If no matches are found for both username and email, the user is considered unique.
        return true;
    }

}