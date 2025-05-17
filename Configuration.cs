public static class Configuration
{
    public static string FileSystemPath { get; }

    static Configuration()
    {
        FileSystemPath = Environment.GetEnvironmentVariable("FILESYSTEM") ?? "/var/www/kris";
    }
}
