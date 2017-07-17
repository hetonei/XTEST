using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XTest3_Logic.Codes.Not2;

namespace XTest3_Logic
{
    public class Generator
    {
        public static string GenerateBin(int range, int id)
        {
            string result = "";
            List<int> original = Enumerable.Range(0, range).ToList();
            Random rand = new Random();
            List<int> sorted = original.OrderBy(item => rand.Next()).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                if (sorted[i] % 2 == 0) sorted[i] = 1;
                else sorted[i] = 0;
            }
            List<int> sorted2 = sorted.OrderBy(item => rand.Next()).ToList();
            if (sorted2[0] == 0) sorted2[0] = 1;
            if (id == 21 || id == 22)
            {
                if (sorted2[sorted2.Count - 1] == 0) sorted2[sorted2.Count - 1] = 1;
            }
            foreach (var a in sorted2)
            {
                result += a;
            }
            return result;
        }
        public static string GenerateT(int range)
        {
            string result = "";
            List<int> original = Enumerable.Range(1, range).ToList();
            Random rand = new Random();
            List<int> sorted = original.OrderBy(item => rand.Next()).ToList();
            result = Convert.ToString(sorted[0]);
            return result;
        }

        public static string GenerateLN(int range, int length)
        {
            
            Random rand = new Random();
            string result = "";
            List<string> output = new List<string>();
            List<int> original1 = Enumerable.Range(0, 9).ToList();
            List<int> original2 = Enumerable.Range(10, range).ToList();
            List<int> sorted1 = original1.OrderBy(item => rand.Next()).ToList();
            List<int> sorted2 = original2.OrderBy(item => rand.Next()).ToList();
            List<int> original = new List<int>();
            foreach (var s in sorted1)
            {
                original.Add(s);
            }
            foreach (var s in sorted2)
            {
                if (s > 34) original.Add(s - 30);
            }

            List<int> sorted = original.OrderBy(item => rand.Next()).ToList();
            foreach (var s in sorted)
            {
                if (s > 9) output.Add(ModuleQ.GetLetter(s).ToString());
                else output.Add(Convert.ToString(s));
                length--;
                if (length == 0) break;
            }

            foreach (var s in output)
            {
                result += s;
            }
            return result;
        }
    }
}
