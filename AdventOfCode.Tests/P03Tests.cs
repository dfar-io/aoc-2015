using NUnit.Framework;
using AdventOfCode.Problems.P03;
using FluentAssertions;

namespace AdventOfCode.Tests;

public class P03Tests
{
    [Test]
    [TestCase(">", 2)]
    [TestCase("^>v<", 4)]
    [TestCase("^v^v^v^v^v", 2)]
    public void P03P1_Works(string input, int answer)
    {
        new P03(input).Answer1.Should().Be(answer);
    }

    [Test]
    [TestCase("^v", 3)]
    [TestCase("^>v<", 3)]
    [TestCase("^v^v^v^v^v", 11)]
    public void P03P2_Works(string input, int answer)
    {
        new P03(input).Answer2.Should().Be(answer);
    }
}