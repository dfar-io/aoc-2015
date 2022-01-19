using System.Text;

namespace AdventOfCode.Problems.P04;

public class P04 : Problem
{
    public P04(string input) : this( new string[] { input } ) {}

    public P04(string[] input) : base(input)
    {
        var count = 0;
        while (Answer1 == 0 || Answer2 == 0)
        {
            var hash = FindMD5Hash($"{input[0]}{count}");
            if (Answer1 == 0 && hash.Substring(0,5) == "00000")
            {
                Answer1 = count;
            }
            if (hash.Substring(0,6) == "000000")
            {
                Answer2 = count;
            }

            count++;
        }
    }

    private static string FindMD5Hash(string input)
    {
        // https://stackoverflow.com/a/24031467
        using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}