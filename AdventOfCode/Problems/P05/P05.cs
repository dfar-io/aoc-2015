using System.Linq;

namespace AdventOfCode.Problems.P05;

public class P05 : Problem
{
    public P05(string input) : this( new string[] { input } ) {}

    public P05(string[] input) : base(input)
    {
        Answer1 = input.Where(s => s.IsNice()).Count();
        Answer2 = input.Where(s => s.IsNiceP2()).Count();;
    }
}