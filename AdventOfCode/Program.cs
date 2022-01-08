using AdventOfCode.Problems;

var problemNum = args[0].ToString().PadLeft(2, '0');

Type t = Type.GetType($"AdventOfCode.Problems.P{problemNum}.P{problemNum}")
    ?? throw new ArgumentException("Problem not found.");
// Need to pass the array as a single object
// https://stackoverflow.com/questions/25513241/how-to-pass-object-to-activator-createinstancetype-params-object
Problem problemInstance = (Problem)Activator.CreateInstance(t, (object) File.ReadAllLines($"input/{problemNum}.txt"))
    ?? throw new ArgumentException("Unable to create problem instance.");

Console.WriteLine($"Problem #: {problemNum}");
Console.WriteLine($"Answer 1: {problemInstance.Answer1}");
Console.WriteLine($"Answer 2: {problemInstance.Answer2}");