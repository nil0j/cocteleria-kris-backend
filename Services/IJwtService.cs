using cocteleria_kris_backend.Models;

namespace cocteleria_kris_backend.Services;

public interface IJwtService
{
    string GenerateToken(User user);
}
