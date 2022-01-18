using NUnit.Framework;
using AdventOfCode.Problems.P02;
using FluentAssertions;

namespace AdventOfCode.Tests;

public class P02Tests
{
    [Test]
    [TestCase("2x3x4", 58)]
    [TestCase("1x1x10", 43)]
    public void Box_SurfaceAreaPlus_Works(string input, int answer)
    {
        new Box(input).SurfaceAreaPlus().Should().Be(answer);
    }

    [Test]
    [TestCase("2x3x4", 34)]
    [TestCase("1x1x10", 14)]
    public void Box_Ribbon_Works(string input, int answer)
    {
        new Box(input).Ribbon().Should().Be(answer);
    }
}