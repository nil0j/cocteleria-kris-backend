namespace cocteleria_kris_backend.Settings;

public class JwtSettings
{
    public string SecretKey { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public int TokenExpirationMinutes { get; set; }
}
