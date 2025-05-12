using Microsoft.EntityFrameworkCore;
using cocteleria_kris_backend.Data;
using cocteleria_kris_backend.Models;

namespace cocteleria_kris_backend.Services;

public class UserService : IUserService
{
    private readonly ApplicationDbContext _dbContext;

    public UserService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<OperationResult> RegisterUser(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            return new OperationResult { Success = false, ErrorMessage = "Username and password are required." };
        }

        if (await _dbContext.Users.AnyAsync(u => u.Username == username))
        {
            return new OperationResult { Success = false, ErrorMessage = "Username already exists." };
        }

        // Hash the password before storing it
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

        var newUser = new User
        {
            Username = username,
            PasswordHash = passwordHash
        };

        _dbContext.Users.Add(newUser);
        await _dbContext.SaveChangesAsync();

        return new OperationResult { Success = true };
    }

    public async Task<User> AuthenticateUser(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            return null;
        }

        var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Username == username);

        // Check if the user exists and verify the password hash
        if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
        {
            return user;
        }

        return null; // Authentication failed
    }
}
