using FluentAssertions;

namespace CiDemo.Web.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        "test".Should().Be("test");
    }
}