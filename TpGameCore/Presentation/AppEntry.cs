namespace TpGameCore.Presentation;

public static class AppEntry
{
    public static string? GetStringEntry(string message)
    {
        Console.WriteLine(message);
        var userEntry = Console.ReadLine();

        return userEntry;
    }

    public static int GetIntegerEntry(string message)
    {
        Console.WriteLine(message);

        var userEntry = Console.ReadLine();
        if (!int.TryParse(userEntry, out var outputResult))
            outputResult = 0;

        return outputResult;
    }
}
