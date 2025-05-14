public static class Configutarion
{
    public static string FileSystemPath { get; }

    static Configutarion()
    {
        FileSystemPath = Environment.GetEnvironmentVariable("FILESYSTEM") ?? "";
    }
}
