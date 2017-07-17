using System;
using System.Collections.Generic;
using System.Linq;

namespace XTest3_Logic.Codes.Not2
{
    public class ModuleQ
    {
        public static char[] letters =
            {
                'A', 'B', 'C', 'D', 'E', 'F',
                'G', 'H', 'I', 'J', 'K', 'L',
                'M', 'N', 'O', 'P', 'Q', 'R',
                'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

        public static int GetNumber(char letter)
        {
            letter = Char.ToUpper(letter);
            int output = 9;
            foreach (var l in letters)
            {
                output++;
                if (l == letter) break;
            }
            return output;
        }

        public static int CountModuleQ(string input)
        {
            input = input.ToUpper();
            List<int> nums = new List<int>();
            foreach (var ch in input)
            {
                if (char.IsDigit(ch)) nums.Add((int)Char.GetNumericValue(ch));

                if (char.IsLetter(ch)) nums.Add(GetNumber(ch));

            }
            return nums.Max() + 1;
        }
        public static char GetLetter(int Number)
        {
            return letters[Number - 10];
        }

        public static string Code(string input, int q)
        {
            input = input.ToUpper();
            string output = "";
            string temp;
            int sum = 0;
            foreach (var ch in input)
            {
                if (char.IsDigit(ch)) sum += (int)Char.GetNumericValue(ch);

                if (char.IsLetter(ch)) sum += GetNumber(ch);

            }
            sum = q - sum % q;
            Console.WriteLine(sum);
            if (sum > 9) temp = Convert.ToString(GetLetter(sum));
            else temp = Convert.ToString(sum);
            output = input + temp;
            return output;
        }
        public static string Decode(string input, int q)
        {
            string output = "";
            int sum = 0;
            foreach (var ch in input)
            {
                if (char.IsDigit(ch)) sum += (int)Char.GetNumericValue(ch);

                if (char.IsLetter(ch)) sum += GetNumber(ch);

            }
            if (sum%q == 0) output = "y";
            else output = "n";
            return output;
        }
    }
}
