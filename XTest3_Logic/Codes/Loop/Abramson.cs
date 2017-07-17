using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace XTest3_Logic.Codes.Loop
{
    public class Abramson
    {
        private static int XOR(int input1, int input2)
        {
            int output = input1;
            if (input1 == 1 && input2 == 1) output = 0;
            if (input1 == 0) output = input2;
            if (input2 == 0) output = input1;
            return output;
        }
        private static int Circumisation(int range, List<int> tempArr)
        {
            int b = 0;
            for (int a = 0; a < range; a++)
            {
                if (tempArr[0] == 0)
                {
                    b++;
                    tempArr.RemoveAt(0);
                }
                else break;
            }
            return b;
        }

        public static string DivideBin(int[] divisor, int[] multiple)
        {
            string result = "";
            var tempArr = new List<int>();

            int i = 0;

            while (i < multiple.Length)
            {
                tempArr.Add(divisor[i]);
                i++;
            }
            i = multiple.Length - 1;

            while (i < divisor.Length)
            {
                for (int a = 0; a < multiple.Length; a++)
                {
                    tempArr.Insert(a, XOR(tempArr[a], multiple[a]));
                    tempArr.RemoveAt(a + 1);
                }
                int c = 0, circ = Circumisation(multiple.Length, tempArr);
                while (c != circ)
                {
                    i++;
                    try
                    {
                        tempArr.Add(divisor[i]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                    c++;
                }
            }

            foreach (var a in tempArr)
            {
                result += Convert.ToString(a);
            }
            return result;
        }

        public static string MultiPol(int[] pol1, int[] pol2)
        {
            int[] result = new int[pol1.Length + pol2.Length - 1];
            string strresult = "";
            int a = result.Length - 1;
            int counter = 0;
            for (int b = pol2.Length - 1; b >= 0; b--)
            {
                counter++;
                a = result.Length - counter;
                for (int c = pol1.Length - 1; c >= 0; c--)
                {
                    result[a] = XOR(result[a], pol2[b] * pol1[c]);
                    a--;

                }
                if (a < 0) break;
            }

            foreach (var res in result)
            {
                strresult += Convert.ToString(res);
            }
            return strresult;
        }

        public static void Strtoarr(string str, int[] intg)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0') intg[i] = 0;
                else intg[i] = 1;
            }

        }

        private static string Arrtostr(int[] intg)
        {
            string result = "";
            for (int i = 0; i < intg.Length; i++)
            {
                if (intg[i] == 0) result += "0";
                else result += "1";
            }
            return result;
        }
        public static string Code(string input, string polinom)
        {
            int[] message = new int[input.Length];
            int[] pol = new int[polinom.Length];
            for (int i = 0; i < input.Length; i++)
            {
                message[i] = (int) Char.GetNumericValue(input[i]);
            }
            for (int i = 0; i < polinom.Length; i++)
            {
                pol[i] = (int)Char.GetNumericValue(polinom[i]);
            }
            int[] multpol = new int[pol.Length + 1];
            int[] multmess = new int[multpol.Length];
            int[] divisor = new int[message.Length + multmess.Length - 1];
            string result = "";
            multmess[0] = 1;
            Strtoarr(MultiPol(pol, new int[] { 1, 1 }), multpol);
            Strtoarr(MultiPol(message, multmess), divisor);
            result = Arrtostr(message);
            if (DivideBin(divisor, multpol).Length < multpol.Length - 1)
            {
                for (int i = multpol.Length - DivideBin(divisor, multpol).Length - 1; i > 0; i--)
                {
                    result += "0";
                }
            }

            return result + DivideBin(divisor, multpol);
        }

        private static void DivideBinList(int[] divisor, int[] multiple, LinkedList<int> list)
        {
            var tempArr = new List<int>();

            int i = 0;

            while (i < multiple.Length)
            {
                tempArr.Add(divisor[i]);
                i++;
            }
            i = multiple.Length - 1;

            while (i < divisor.Length)
            {
                for (int a = 0; a < multiple.Length; a++)
                {
                    tempArr.Insert(a, XOR(tempArr[a], multiple[a]));
                    tempArr.RemoveAt(a + 1);
                }
                int c = 0, circ = Circumisation(multiple.Length, tempArr);
                while (c != circ)
                {
                    i++;
                    try
                    {
                        tempArr.Add(divisor[i]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                    c++;
                }


            }

            foreach (var r in tempArr)
            {
                list.AddLast(r);
            }
        }

        public static string Decode(string message, string polinom)
        {
            int[] arrmessage = new int[message.Length];
            int[] arrpol = new int[polinom.Length];
            int[] multpol = new int[arrpol.Length + 1];
            int weight = -1;
            bool counter = false;
            int k = 0;
            string result = "";
            LinkedList<int> templist1 = new LinkedList<int>();
            LinkedList<int> templist2 = new LinkedList<int>();
            Strtoarr(message, arrmessage);
            Strtoarr(polinom, arrpol);
            Strtoarr(MultiPol(arrpol, new int[] { 1, 1 }), multpol);



            while ((weight != 2) || (counter != true))
            {
                templist1.Clear();
                templist2.Clear();
                DivideBinList(arrmessage, multpol, templist1);
                int[] temp = new int[templist1.Count];
                temp = templist1.ToArray();
                counter = Counter(temp);
                weight = Weight(temp);
                ArrToList(templist2, arrmessage);
                if (counter == false || weight != 2)
                {
                    MoveArr(templist2, 1);
                    k++;
                }
                arrmessage = templist2.ToArray();
                if (weight == 0) counter = true;

            }

            int[] temp2 = new int[templist1.Count];
            temp2 = templist1.ToArray();
            for (int i = temp2.Length - 1; i >= 0; i--)
            {
                arrmessage[arrmessage.Length - temp2.Length + i] = XOR(arrmessage[arrmessage.Length - temp2.Length + i], temp2[i]);

            }
            templist1.Clear();
            ArrToList(templist1, arrmessage);
            for (int i = 0; i < k; i++) MoveArr(templist1, 2);

            arrmessage = templist1.ToArray();
            for (int i = 0; i < arrmessage.Length - 5; i++)
            {
                result += arrmessage[i];
            }



            return result;
        }

        private static void MoveArr(LinkedList<int> arr, int t)
        {
            if (t == 1)
            {
                arr.AddLast(arr.First.Value);
                arr.RemoveFirst();
            }
            else
            {
                arr.AddFirst(arr.Last.Value);
                arr.RemoveLast();
            }

        }

        public static int Weight(int[] arr)
        {
            int res = 0;
            foreach (var r in arr)
            {
                if (r == 1) res++;
            }
            return res;
        }

        public static bool Counter(int[] arr)
        {
            bool res = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1 && i != arr.Length - 1)
                {
                    if (arr[i + 1] == 1)
                    {
                        res = true;
                        break;
                    }
                }
            }

            return res;
        }

        public static void ArrToList(LinkedList<int> arr, int[] arr2)
        {
            foreach (var r in arr2)
            {
                arr.AddLast(r);
            }
        }
    }
}
