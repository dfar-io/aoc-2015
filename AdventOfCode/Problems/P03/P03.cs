namespace AdventOfCode.Problems.P03;

public class P03 : Problem
{
    public P03(string input) : this( new string[] { input } ) {}

    public P03(string[] input) : base(input)
    {
        (int x, int y) currentCoords = (0,0);
        (int x, int y) santaCoords = (0,0);
        (int x, int y) roboSantaCoords = (0,0);
        var visitedLocations = new HashSet<(int x, int y)>();
        var santaVisitedLocations = new HashSet<(int x, int y)>();
        var roboSantaVisitedLocations = new HashSet<(int x, int y)>();
        var isSantaRound = true;

        visitedLocations.Add(currentCoords);
        santaVisitedLocations.Add(currentCoords);
        roboSantaVisitedLocations.Add(currentCoords);

        foreach (var direction in input[0])
        {
            // I'm guessing this is the problem
            var p2Coords = isSantaRound ? santaCoords : roboSantaCoords;

            switch (direction)
            {
                case '^':
                    currentCoords.y += 1;
                    p2Coords.y += 1;
                    break;
                case '<':
                    currentCoords.x -= 1;
                    p2Coords.x -= 1;
                    break;
                case '>':
                    currentCoords.x += 1;
                    p2Coords.x += 1;
                    break;
                case 'v':
                    currentCoords.y -= 1;
                    p2Coords.y -= 1;
                    break;
            }

            visitedLocations.Add(currentCoords);
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
}