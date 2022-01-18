using NUnit.Framework;
using AdventOfCode.Problems.P01;
using FluentAssertions;

namespace AdventOfCode.Tests;

public class P01Tests
{
    [Test]
    [TestCase("(())", 0)]
    [TestCase("()()", 0)]
    [TestCase("(((", 3)]
    [TestCase("(()(()(", 3)]
    [TestCase("))(((((", 3)]
    [TestCase("())", -1)]
    [TestCase("))(", -1)]
    [TestCase(")))", -3)]
    [TestCase(")())())", -3)]
    public void P01P1_Works(string input, int answer)
    {
        new P01(input).Answer1.Should().Be(answer);
    }

    [Test]
    [TestCase(")", 1)]
    [TestCase("()())", 5)]
    public void P01P2_Works(string input, int answer)
    {
        new P01(input).Answer2.Should().Be(answer);
    }
}