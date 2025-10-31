namespace Console.Tests;

public class ProgramTests
{
    [Fact]
    public void GetGreeting_DefaultsToCodexTest()
    {
        var greeting = CodexTest.Program.GetGreeting();
        Assert.Equal("Hello CodexTest", greeting);
    }

    [Fact]
    public void GetGreeting_ReturnsNameWhenProvided()
    {
        var greeting = CodexTest.Program.GetGreeting("Team");
        Assert.Equal("Hello Team", greeting);
    }
}
