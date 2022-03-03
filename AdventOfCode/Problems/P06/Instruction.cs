using System.Linq;

namespace AdventOfCode.Problems.P06;

public class Instruction
{
    public string Command { get; init; }
    public Coordinate Start { get; init; }
    public Coordinate End { get; init; }

    public Instruction(string input)
    {
        var parts = input.Split(" ");
        var isToggle = parts[0] == "toggle";
        var startParts = parts[parts.Length - 3].Split(",");
        var endParts = parts[parts.Length - 1].Split(",");

        Command = isToggle ? "toggle" : $"{parts[0]} {parts[1]}";
        Start = new Coordinate(
            Convert.ToInt16(startParts[0]),
            Convert.ToInt16(startParts[1])
        );
        End = new Coordinate(
            Convert.ToInt16(endParts[0]),
            Convert.ToInt16(endParts[1])
        );
    }
}