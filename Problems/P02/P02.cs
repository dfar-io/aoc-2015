namespace AdventOfCode.Problems.P02;

public class P02 : Problem
{
    public P02(string[] input) : base(input)
    {
        foreach (var line in _input)
        {
            Answer1 += new Box(line).SurfaceAreaPlus();
        }
    }
}