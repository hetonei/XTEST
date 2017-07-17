using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest3_Logic.Codes.Loop
{
   public class Faira
    {
       public static string Code(string number, string polinom)
       {
           string result = "";
           int[] arrmess = new int[number.Length];
           int[] arrpol = new int[polinom.Length];
           int mcount = 2;
           int c = 0, deg = 0;
           deg = polinom.Length - 1;
           c = mcount * 2 - 1;
           if (c % ((Math.Pow(2, deg)) - 1) == 0)
           {
               c++;
           }
           int[] multpol = new int[c + 1];
           int[] respol = new int[multpol.Length + arrpol.Length - 1];
           int[] multmess = new int[c + 2];
           int[] resmess = new int[arrmess.Length + multmess.Length];
           multmess[0] = 1;
           multpol[0] = 1;
           multpol[multpol.Length - 1] = 1;
           Abramson.Strtoarr(number, arrmess);
           Abramson.Strtoarr(polinom, arrpol);
           Abramson.Strtoarr(Abramson.MultiPol(arrpol, multpol), respol);
           Abramson.Strtoarr(Abramson.MultiPol(arrmess, multmess), resmess);

           for (int i = 0; i <= 6 - Abramson.DivideBin(resmess, respol).Length; i++)
           {
               number += "0";
           }

           return result = number + Abramson.DivideBin(resmess, respol);
       }

    }
}
