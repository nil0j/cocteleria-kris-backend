namespace cocteleria_kris_backend.Models;

public class JsonMessage
{
    public string Message { get; set; }

    public JsonMessage(string message)
    {
        this.Message = message;
    }
}
