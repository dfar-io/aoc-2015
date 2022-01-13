namespace AdventOfCode.Problems.P03;

public class P03 : Problem
{
    public P03(string input) : this( new string[] { input } ) {}

    public P03(string[] input) : base(input)
    {
        (int x, int y) currentCoords = (0,0);
        var visitedLocations = new HashSet<(int x, int y)>();

        visitedLocations.Add(currentCoords);

        foreach (var direction in input[0])
        {
            switch (direction)
            {
                case '^':
                    currentCoords.y += 1;
                    break;
                case '<':
                    currentCoords.x -= 1;
                    break;
                case '>':
                    currentCoords.x += 1;
                    break;
                case 'v':
                    currentCoords.y -= 1;
                    break;
            }

            visitedLocations.Add(currentCoords);
        }

        Answer1 = visitedLocations.Count();
    }
}