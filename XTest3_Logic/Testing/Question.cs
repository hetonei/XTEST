using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace XTest3_Logic.Testing
{
    public class Question
    {
        public int CodeId;
        public string Number;
        public bool Code;
        public string Answer;
        public string Description;
        public string TwoTenCoder;
        public int ModuleQ;
        public string Polinom;
        public string FNumber;

        private static string[] TwoTenCoders =
        {
            "8421", "7421", "6421", "5421", "4421",
            "7321", "6321", "5321", "4321",
            "3321", "6221", "5221", "4221",
            "6311", "5311", "4311", "5211",
        };

        public Question(int id, int length, bool code)
        {
            Thread.Sleep(10);
            CodeId = id;
            if (CodeId == 21 && length > 10) length = 10;
            if (CodeId == 22) length = 6;
            Number = Generator.GenerateBin(length, id);
            
            Code = code;
            if (id == 32)
            {
                Number = Generator.GenerateLN(35, length);
            }
            if (CodeId == 22)
            {
                Thread.Sleep(20);

                Polinom = Generator.GenerateBin(3, 22);
                if (Code == false)
                {
                    FNumber = Generator.GenerateBin(length, id);
                    Number = Codes.Loop.Faira.Code(FNumber, Polinom);
                }
            }
            if (Code) Description = "Кодировать " + Number;
            else Description = "Декодировать " + Number;
            
            if (CodeId == 21)
            {
                Thread.Sleep(20);
                Polinom = Generator.GenerateBin(5,21);
                
                Description += "\nНеприводимый полином P1 = " + Polinom;
            }
            if (CodeId == 22) Description += "\nНеприводимый полином P1 = " + Polinom;
            if (CodeId == 42)
            {
                Thread.Sleep(20);
                Random rand = new Random();
                int r = rand.Next(TwoTenCoders.Length);
                TwoTenCoder = TwoTenCoders[r];
                Description += "\nКод: " + TwoTenCoder;
            }
            if (CodeId == 32 && Code == false)
            {
                Thread.Sleep(20);
                Random r = new Random();
                if (r.Next(1, 10) % 2 == 0) Number = Codes.Not2.ModuleQ.Code(Number, Codes.Not2.ModuleQ.CountModuleQ(Number));
                
                Description = "Правильно ли принята кодовая\n комбинация:" + Number + " если ";
            }
            if (CodeId == 32)
            {

                Thread.Sleep(20);
                
                ModuleQ = Codes.Not2.ModuleQ.CountModuleQ(Number);
                
                Description += "\nq = " + ModuleQ;
            }
            Answer = "";
        }

        public Question(int id, bool code, int length)
        {
            Thread.Sleep(20);
            CodeId = id;
            Code = code;
            Number = Generator.GenerateT(length);
            if (id == 33 && Code == false)
            {
                Number += Number;
            }
            
            if (Code) Description = "Кодировать " + Number;
            else Description = "Декодировать " + Number;
            if (id == 42)
            {
                Random rand = new Random();
                int r = rand.Next(TwoTenCoders.Length);
                TwoTenCoder = TwoTenCoders[r];
                Description += "\nПорядок весов: " + TwoTenCoder;
            }
            Answer = "";
        }
    }
}
