namespace AdventOfCode.Problems.P02;

public class P02 : Problem
{
    public P02(string[] input) : base(input)
    {
        foreach (var line in _input)
        {
            var box = new Box(line);
            Answer1 += box.SurfaceAreaPlus();
            Answer2 += box.Ribbon();
        }
    }
}