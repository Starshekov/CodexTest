using CodexTest;
using Xunit;

namespace CodexTest.Tests;

public class ProgramTests
{
    [Fact]
    public void GetGreeting_ReturnsHelloCodex()
    {
        const string expected = "Hello Codex";

        var greeting = Program.GetGreeting();

        Assert.Equal(expected, greeting);
    }
}
