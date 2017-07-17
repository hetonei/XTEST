using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest3_Logic.Codes
{
    public class Berger
    {
        public static string Code(string input)
        {
            int counter = 0;
            foreach (var one in input.ToCharArray())
            {
                if (one == '1') counter++;
            }
            string resCounter = "";
            string bCounter = Convert.ToString(counter, 2);
            int len = Convert.ToInt32(Math.Ceiling(Math.Log(input.Length, 2)));
            while (bCounter.Length != len) bCounter = bCounter.Insert(0, "0");
            for (int i = 0; i < bCounter.Length; i++)
            {
                char temp = bCounter[i];
                if (temp == '1')
                    temp = '0';
                else temp = '1';
                resCounter += temp;
            }
            return (input + resCounter);
        }

        public static string Decode(string input)
        {
            int len = Convert.ToInt32(Math.Ceiling(Math.Log(input.Length, 2)));
            input = input.Substring(0, input.Length - len);
            return input;
        }
    }
}
