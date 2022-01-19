using NUnit.Framework;
using AdventOfCode.Problems.P04;
using FluentAssertions;

namespace AdventOfCode.Tests;

public class P04Tests
{
    [Test]
    [TestCase("abcdef", 609043)]
    [TestCase("pqrstuv", 1048970)]
    public void P04_Works(string input, int answer1)
    {
        var problem = new P04(input);
        problem.Answer1.Should().Be(answer1);
    }
}