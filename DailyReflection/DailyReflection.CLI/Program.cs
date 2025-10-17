using DailyReflection.Shared;

namespace DailyReflection.CLI;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Message of the Day ===\n");
        var today = DateTime.Now;
        var repository = new DailyReflectionRepository();
        var message = repository.GetMessage(DateOnly.FromDateTime(today));
        Console.WriteLine(message);
    }
}