namespace AdventOfCode.Problems.P02;

public class Box
{
    public int Length { get; init; }
    public int Width { get; init; }
    public int Height { get; init; }

    public Box(string input)
    {
        var values = input.Split("x");

        Length = int.Parse(values[0]);
        Width = int.Parse(values[1]);
        Height = int.Parse(values[2]);
    }

    public int SurfaceAreaPlus()
    {
        var surfaceArea1 = Length * Width;
        var surfaceArea2 = Width * Height;
        var surfaceArea3 = Height * Length;

        return 2 * surfaceArea1 +
               2 * surfaceArea2 +
               2 * surfaceArea3 + 
               Math.Min(
                surfaceArea1,
                Math.Min(surfaceArea2, surfaceArea3)
               );
    }
}