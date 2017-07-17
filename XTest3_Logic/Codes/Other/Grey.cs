using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest3_Logic.Codes
{
    public class Grey
    {
        private static char XOR(char input1, char input2)
        {
            char output = input1;
            if (input1 == '1' && input2 == '1') output = '0';
            if (input1 == '0') output = input2;
            if (input2 == '0') output = input1;
            return output;
        }
        public static string Code(string input)
        {
            char[] output = new char[input.Length];
            output[0] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                output[i] = XOR(input[i], input[i - 1]);
            }
            string result = "";
            foreach (var ch in output) result += ch;
            return result;
        }

        public static string Decode(string input)
        {
            char[] output = new char[input.Length];
            output[0] = input[0];
            char temp;
            for (int i = 1; i < input.Length; i++)
            {
                temp = input[i];
                for (int j = 0; j < i; j++)
                {
                    temp = XOR(input[j], temp);
                }
                output[i] = temp;
            }

            string result = "";
            foreach (var ch in output) result += ch;
            return result;
        }
    }
}
