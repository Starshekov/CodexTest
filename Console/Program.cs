namespace CodexTest;

public static class Program
{
    public static void Main(string[] args)
    {
        var name = args.Length > 0 ? args[0] : null;
        Console.WriteLine(GetGreeting(name));
    }

    public static string GetGreeting(string? name = null)
    {
        return string.IsNullOrWhiteSpace(name)
            ? "Hello CodexTest"
            : $"Hello {name}";
    }
}
