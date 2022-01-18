using NUnit.Framework;
using AdventOfCode.Problems.P02;
using FluentAssertions;

namespace AdventOfCode.Tests;

public class P02Tests
{
    [Test]
    [TestCase("2x3x4", 58, 34)]
    [TestCase("1x1x10", 43, 14)]
    public void Box_Works(string input, int surfaceArea, int ribbon)
    {
        var box = new Box(input);
        box.SurfaceAreaPlus().Should().Be(surfaceArea);
        box.Ribbon().Should().Be(ribbon);
    }
}