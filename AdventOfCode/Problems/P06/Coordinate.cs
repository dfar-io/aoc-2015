using System.Linq;

namespace AdventOfCode.Problems.P06;

public class Coordinate
{
    public int X { get; init; }
    public int Y { get; init; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }
}