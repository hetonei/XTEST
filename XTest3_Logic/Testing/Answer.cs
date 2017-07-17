using System.Windows.Forms;

namespace XTest3_Logic.Testing
{
    public class Answer
    {
        public static bool CheckAnswer(Question quest)
        {
            bool result = true;

            switch (quest.CodeId)
            {
                case 21:
                    if (quest.Code)
                    {
                        if (Codes.Loop.Abramson.Code(quest.Number, quest.Polinom) != quest.Answer) result = false;
                    }
                    else
                    {
                        if (Codes.Loop.Abramson.Decode(quest.Number, quest.Polinom) != quest.Answer) result = false;
                        
                    }
                    break;
                case 22:
                    if (quest.Code)
                    {
                        if (Codes.Loop.Faira.Code(quest.Number, quest.Polinom) != quest.Answer) result = false;
                    }
                    else
                    {
                        if (quest.FNumber != quest.Answer) result = false;
                    }
                    break;
                case 41:
                    if (quest.Code)
                    {
                        if (Codes.Grey.Decode(quest.Answer) != quest.Number) result = false;
                    }
                    else
                    {
                        if (Codes.Grey.Code(quest.Answer) != quest.Number) result = false;
                    }
                    break;
                case 42:
                    if (quest.Code)
                    {
                        if (Codes.TwoTen.Decode(quest.Answer, quest.TwoTenCoder) != quest.Number) result = false;
                    }
                    else
                    {
                        if (Codes.TwoTen.Code(quest.Answer, quest.TwoTenCoder) != quest.Number) result = false;
                    }
                    break;
                case 43:
                    if (quest.Code)
                    {
                        if (Codes.Berger.Decode(quest.Answer) != quest.Number) result = false;
                    }
                    else
                    {
                        if (Codes.Berger.Code(quest.Answer) != quest.Number) result = false;
                    }
                    break;
                case 32:
                    if (quest.Code)
                    {
                        if (Codes.Not2.ModuleQ.Code(quest.Number, quest.ModuleQ) != quest.Answer) result = false;
                    }
                    else
                    {
                        
                        if (Codes.Not2.ModuleQ.Decode(quest.Number, quest.ModuleQ) != quest.Answer) result = false;
                    }
                    break;
                case 33:
                    if (quest.Code)
                    {
                        if (Codes.Not2.EzRepeat.Decode(quest.Answer) != quest.Number) result = false;
                    }
                    else
                    {
                        if (Codes.Not2.EzRepeat.Code(quest.Answer) != quest.Number) result = false;
                    }
                    break;
            }
            return result;
        }
    }
}
