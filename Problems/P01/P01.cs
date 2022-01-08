namespace AdventOfCode.Problems.P01;

using System.Linq;

public class P01 : Problem
{
    // This allows for calling this problem with a single string
    public P01(string input) : base(input) {}

    public P01(string[] input) : base(input)
    {
        Answer1 = _input[0].Count(c => c == '(') - _input[0].Count(c => c == ')');

        var floorIndex = 0;
        for (int position = 0; position < _input[0].Length; position++)
        {
            floorIndex = _input[0][position] == '(' ? floorIndex + 1 : floorIndex - 1;
            if (floorIndex == -1)
            {
                Answer2 = position + 1;
                break;
            }
        }
    }
}