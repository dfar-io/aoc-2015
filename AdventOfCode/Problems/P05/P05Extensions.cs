using System.Text.RegularExpressions;

namespace AdventOfCode.Problems.P05;

public static class P05Extensions
{
    public static bool IsNice(this string value)
    {
        var vowels = "aeiou";
        var hasThreeVowels = value.Where(c => vowels.Contains(c)).Count() >= 3;

        var hasSubsequentString = Regex.IsMatch(value, @"(.)\1");

        var hasForbiddenStrings = value.Contains("ab") ||
                                  value.Contains("cd") ||
                                  value.Contains("pq") ||
                                  value.Contains("xy");

        return hasThreeVowels && hasSubsequentString && !hasForbiddenStrings;
    }

    public static bool IsNiceP2(this string value)
    {
        var containsPair = false;
        var containsRepeatingLetter = false;

        for (int i = 0; i < value.Length; i++)
        {
            var pair = i < value.Length - 1 ?
                $"{value[i]}{value[i+1]}" :
                string.Empty;
            // Only need to check if it doesn't already include a repeating letter
            containsRepeatingLetter = !containsRepeatingLetter && i < value.Length - 2 ?
                value[i] == value[i+2] :
                containsRepeatingLetter;
                
            for (int j = i + 2; j < value.Length - 1; j++)
            {
                var secondPair = $"{value[j]}{value[j+1]}";
                if (pair == secondPair)
                {
                    containsPair = true;
                    continue;
                }
            }
        }

        return containsPair && containsRepeatingLetter;
    }
}