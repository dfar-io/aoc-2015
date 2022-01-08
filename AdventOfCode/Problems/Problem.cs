namespace AdventOfCode.Problems;

public abstract class Problem
{
    public int Answer1 { get; set; }
    public int Answer2 { get; set; }

    protected Problem(string input) : this(new string[] { input }) {}

    protected Problem(string[] input) {}
}