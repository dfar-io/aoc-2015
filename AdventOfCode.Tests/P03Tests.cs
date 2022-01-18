using NUnit.Framework;
using AdventOfCode.Problems.P03;
using FluentAssertions;

namespace AdventOfCode.Tests;

public class P03Tests
{
    [Test]
    [TestCase(">", 2, 2)]
    [TestCase("^v", 2, 3)]
    [TestCase("^>v<", 4, 3)]
    [TestCase("^v^v^v^v^v", 2, 11)]
    public void P03_Works(string input, int answer1, int answer2)
    {
        var problem = new P03(input);
        problem.Answer1.Should().Be(answer1);
        problem.Answer2.Should().Be(answer2);
    }
}