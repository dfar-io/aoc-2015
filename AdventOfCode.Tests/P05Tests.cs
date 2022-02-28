using NUnit.Framework;
using AdventOfCode.Problems.P05;
using FluentAssertions;

namespace AdventOfCode.Tests;

public class P05Tests
{
    [Test]
    public void P05P1_Works()
    {
        var input = new string[]
        {
            "ugknbfddgicrmopn",
            "aaa",
            "jchzalrnumimnmhp",
            "haegwjzuvuyypxyu",
            "dvszwmarrgswjxmb"
        };
        var problem = new P05(input);
        problem.Answer1.Should().Be(2);
    }

    [Test]
    public void P05P2_Works()
    {
        var input = new string[]
        {
            "qjhvhtzxzqqjkmpb",
            "xxyxx",
            "uurcxstgmygtbstg",
            "ieodomkazucvgmuy"
        };
        var problem = new P05(input);
        problem.Answer2.Should().Be(2);
    }
}