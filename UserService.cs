namespace TestConsoleApp;
public class UserService
{
	public void CreateUser(string username, string password)
	{
		if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("Username and password are required.");
		}

		var user = new User
		{
			Username = username,
			Password = HashPassword(password),
			CreatedAt = DateTime.Now
		};

		SaveUser(user);
	}

	private string HashPassword(string password)
	{
		// Simple hash for demonstration purposes
		return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
	}

	private void SaveUser(User user)
	{
		// Simulate saving user to a database
	}
}

public class User
{
	public string Username { get; set; }
	public string Password { get; set; }
	public DateTime CreatedAt { get; set; }
}
