using System.Threading.Tasks;
using cocteleria_kris_backend.Models;

namespace cocteleria_kris_backend.Services;

public interface IUserService
{
    Task<OperationResult> RegisterUser(string username, string password);
    Task<User> AuthenticateUser(string username, string password);
}

public class OperationResult
{
    public bool Success { get; set; }
    public string ErrorMessage { get; set; }
}
