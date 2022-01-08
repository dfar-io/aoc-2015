namespace AdventOfCode.Problems.P02;

public class Box
{
    private int Length { get; init; }
    private int Width { get; init; }
    private int Height { get; init; }

    private int Area1 => Length * Width;
    private int Area2 => Width * Height;
    private int Area3 => Height * Length;

    public Box(string input)
    {
        var values = input.Split("x");

        Length = int.Parse(values[0]);
        Width = int.Parse(values[1]);
        Height = int.Parse(values[2]);
    }

    public int SurfaceAreaPlus()
    {
        return 2 * Area1 +
               2 * Area2 +
               2 * Area3 + 
               SmallestArea();
    }

    public int Ribbon()
    {
        var volume = Length * Width * Height;
        return SmallestPerimeter() + volume;
    }

    

    private int SmallestArea()
    {
        return Math.Min(
                Area1,
                Math.Min(Area2, Area3)
               );
    }

    private int SmallestPerimeter()
    {
        var dimensions = new int[] { Length, Width, Height };
        var values = dimensions.OrderBy(i => i).Take(2).ToArray();

        return values[0] * 2 + values[1] * 2;
    }
}