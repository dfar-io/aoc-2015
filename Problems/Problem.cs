namespace AdventOfCode.Problems;

public abstract class Problem
{
    protected string[] _input;
    public int Answer1 { get; init; }
    public int Answer2 { get; init; }

    protected Problem(string input) {
        _input = new string[] { input };
    }

    protected Problem(string[] input) {
        _input = input;
    }
}