namespace AdventOfCode.Problems.P01;

using System.Linq;

public class P01 : Problem
{
    public P01(string input) : this( new string[] { input } ) {}

    public P01(string[] input) : base(input)
    {
        Answer1 = input[0].Count(c => c == '(') - input[0].Count(c => c == ')');

        var floorIndex = 0;
        for (int position = 0; position < input[0].Length; position++)
        {
            floorIndex = input[0][position] == '(' ? floorIndex + 1 : floorIndex - 1;
            if (floorIndex == -1)
            {
                Answer2 = position + 1;
                break;
            }
        }
    }
}