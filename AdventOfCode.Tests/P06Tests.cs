using NUnit.Framework;
using AdventOfCode.Problems.P06;
using FluentAssertions;

namespace AdventOfCode.Tests;

public class P06Tests
{
    [Test]
    [TestCase("turn on 0,0 through 999,999", "turn on", 0, 0, 999, 999)]
    //[TestCase("toggle 0,0 through 999,0", "toggle")]
    //[TestCase("turn off 499,499 through 500,500", "turn off")]
    public void Instruction_Inits(
        string instructionString,
        string command,
        int startX,
        int startY,
        int endX,
        int endY)
    {
        var instruction = new Instruction(instructionString);

        instruction.Command.Should().Be(command);
        instruction.Start.Should().BeEquivalentTo(new Coordinate(startX, startY));
        instruction.End.Should().BeEquivalentTo(new Coordinate(endX, endY));
    }

    [Test]
    public void P06_Works()
    {
        var input = new string[]
        {
            "turn on 0,0 through 999,999",
            "toggle 0,0 through 999,0",
            "turn off 499,499 through 500,500"
        };
        var problem = new P06(input);
        problem.Answer1.Should().Be(998996);
    }
}