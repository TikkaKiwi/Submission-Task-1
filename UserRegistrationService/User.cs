namespace UserRegistrationService;

public class User
{
    public string username { get; set; }
    public string password { get; set; }
    public string email { get; set; }

    public User(string _username, string _password, string _email)
    {
        username = _username;
        password = _password;
        email = _email;
    }
}