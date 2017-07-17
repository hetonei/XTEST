using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest3_Logic.Codes
{
    public class TwoTen
    {
        public static string Code(string input, string coder)
        {
            string output = "";
            int[] number = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                number[i] = (int)Char.GetNumericValue(input[i]);
            }
            int[] code = new int[coder.Length];

            for (int i = 0; i < coder.Length; i++)
            {
                code[i] = (int)Char.GetNumericValue(coder[i]);
            }

            int ost;
            foreach (var nm in number)
            {
                ost = nm;
                foreach (var cd in code)
                {
                    if (ost < cd) output += Convert.ToString(0);
                    else
                    {
                        output += Convert.ToString(1);
                        ost -= cd;
                    }
                }
            }
            return output;
        }

        public static string Decode(string input, string coder)
        {
            string output = "";
            int[] number = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                number[i] = (int)Char.GetNumericValue(input[i]);
            }
            int[] code = new int[coder.Length];

            for (int i = 0; i < coder.Length; i++)
            {
                code[i] = (int)Char.GetNumericValue(coder[i]);
            }
            int temp = 0;
            for (int i = 0; i < number.Length; i++)
            {
                foreach (var cd in code)
                {
                    temp += cd * number[i];
                    i++;
                    if (i == number.Length) break;
                }
                i--;
                output += Convert.ToString(temp);
                temp = 0;
            }
            return output;
        }
    }
}
