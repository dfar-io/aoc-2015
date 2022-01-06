namespace AdventOfCode.Problems;

using System.Linq;

public class P01
{
    public int Answer1 { get; private set; }
    public int Answer2 { get; private set; }

    public P01(string input)
    {
        Answer1 = input.Count(c => c == '(') - input.Count(c => c == ')');

        var floorIndex = 0;
        for (int position = 0; position < input.Length; position++)
        {
            floorIndex = input[position] == '(' ? floorIndex + 1 : floorIndex - 1;
            if (floorIndex == -1)
            {
                Answer2 = position + 1;
                break;
            }
        }
    }
}