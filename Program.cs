using AdventOfCode.Problems;

Console.WriteLine($"Argument: {args[0]}");

var problem = new P01(File.ReadAllLines("input.txt")[0]);

Console.WriteLine($"Answer 1: {problem.Answer1}");
Console.WriteLine($"Answer 2: {problem.Answer2}");