namespace AdventOfCode.Problems.P03;

public class P03 : Problem
{
    public P03(string input) : this( new string[] { input } ) {}

    public P03(string[] input) : base(input)
    {
        (int x, int y) p1Coords = (0,0);
        (int x, int y) santaCoords = (0,0);
        (int x, int y) roboSantaCoords = (0,0);
        var visitedLocations = new HashSet<(int x, int y)>();
        var santaVisitedLocations = new HashSet<(int x, int y)>();
        var roboSantaVisitedLocations = new HashSet<(int x, int y)>();
        var isSantaRound = true;

        visitedLocations.Add(p1Coords);
        santaVisitedLocations.Add(p1Coords);
        roboSantaVisitedLocations.Add(p1Coords);

        foreach (var direction in input[0])
        {
            var p2Coords = isSantaRound ? santaCoords : roboSantaCoords;
            HandleDirection(ref p1Coords, direction, ref p2Coords);

            visitedLocations.Add(p1Coords);
            if (isSantaRound)
            {
                santaCoords = p2Coords;
                santaVisitedLocations.Add(santaCoords);
            }
            else
            {
                roboSantaCoords = p2Coords;
                roboSantaVisitedLocations.Add(roboSantaCoords);
            }

            isSantaRound = !isSantaRound;
        }

        Answer1 = visitedLocations.Count();
        Answer2 = santaVisitedLocations.Union(roboSantaVisitedLocations).Count();
    }

    private static void HandleDirection(ref (int x, int y) p1Coords, char direction, ref (int x, int y) p2Coords)
    {
        switch (direction)
        {
            case '^':
                p1Coords.y += 1;
                p2Coords.y += 1;
                break;
            case '<':
                p1Coords.x -= 1;
                p2Coords.x -= 1;
                break;
            case '>':
                p1Coords.x += 1;
                p2Coords.x += 1;
                break;
            case 'v':
                p1Coords.y -= 1;
                p2Coords.y -= 1;
                break;
        }
    }
}