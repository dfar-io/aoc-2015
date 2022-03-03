using System.Linq;

namespace AdventOfCode.Problems.P06;

public class P06 : Problem
{
    public P06(string input) : this( new string[] { input } ) {}

    public P06(string[] input) : base(input)
    {
        var lights = new bool[1000, 1000];
        var lightsP2 = new int[1000, 1000];

        foreach (var instructionString in input)
        {
            var instruction = new Instruction(instructionString);

            for (int i = instruction.Start.X; i <= instruction.End.X; i++)
            {
                for (int j = instruction.Start.Y; j <= instruction.End.Y; j++)
                {
                    lights[i, j] = HandleLight(lights[i, j], instruction.Command);
                    lightsP2[i, j] = HandleLightP2(lightsP2[i, j], instruction.Command);
                }
            }
        }

        var answer1Query = from bool light in lights
            where light
            select light;

        Answer1 = answer1Query.Count();
        // https://stackoverflow.com/a/19035169
        Answer2 = lightsP2.Cast<int>().Sum();
    }

    private bool HandleLight(bool light, string command)
    {
        switch (command)
        {
            case "turn on":
                return true;
            case "turn off":
                return false;
            case "toggle":
                return !light;
            default:
                throw new Exception($"Invalid command provided: {command}");
        }
    }

    private int HandleLightP2(int light, string command)
    {
        switch (command)
        {
            case "turn on":
                return light + 1;
            case "turn off":
                return light > 0 ? light - 1 : 0;
            case "toggle":
                return light + 2;
            default:
                throw new Exception($"Invalid command provided: {command}");
        }
    }
}