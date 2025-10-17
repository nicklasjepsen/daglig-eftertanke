namespace DailyReflection.Shared;

public class DailyReflectionRepository
{
    public string GetMessage(DateOnly date)
    {
        var fileName = $"{date:MM-dd}.md";
        var messagesDir = "daily_messages";
        var filePath = Path.Combine(messagesDir, fileName);
        if (File.Exists(filePath))
        {
            return File.ReadAllText(filePath);
        }
        else
        {
            return $"No daily message found for {date:MMMM dd}.";
        }
    }
}