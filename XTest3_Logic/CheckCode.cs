using System;
using System.Collections.Generic;
using System.Linq;
using XTest3_Logic.Testing;

namespace XTest3_Logic
{
    public class CheckCode
    {
        public static Question[] Check(int id)
        {
            Question[] quests = new Question[10];
            List<int> original = Enumerable.Range(6, 16).ToList();
            List<int> original2 = Enumerable.Range(4, 12).ToList();
            Random rand = new Random();
            List<int> sorted = original.OrderBy(item => rand.Next()).ToList();
            List<int> sorted2 = original.OrderBy(item => rand.Next()).ToList();

            switch (id)
            {
                case 21:
                    for (int i = 0; i < quests.Length; i++)
                    {
                        if(i<=4)
                            quests[i] = new Question(21, sorted.ToArray()[i], true);
                        else
                            quests[i] = new Question(21, sorted.ToArray()[i], false);
                    }
                    break;
                case 22:
                    for (int i = 0; i < quests.Length; i++)
                    {
                        if (i <= 4)
                            quests[i] = new Question(22, sorted.ToArray()[i], true);
                        else
                            quests[i] = new Question(22, sorted.ToArray()[i], false);
                    }
                    break;
                case 41:
                    for (int i = 0; i < quests.Length; i++)
                    {
                        if(i<=4)
                            quests[i] = new Question(41, sorted.ToArray()[i], true);
                        else
                            quests[i] = new Question(41, sorted.ToArray()[i], false);
                    }
                    break;
                case 42:
                    for (int i = 0; i < quests.Length; i++)
                    {
                        if (i <= 4)
                            quests[i] = new Question(42, true, 1000);
                        else
                            quests[i] = new Question(42, 12, false);
                    }
                    break;
                case 43:
                    for (int i = 0; i < quests.Length; i++)
                    {
                        if (i <= 4)
                            quests[i] = new Question(43, sorted.ToArray()[i], true);
                        else
                            quests[i] = new Question(43, sorted.ToArray()[i], false);
                    }
                    break;
                case 32:
                    for (int i = 0; i < quests.Length; i++)
                    {
                        if (i <= 4)
                            quests[i] = new Question(32, sorted2.ToArray()[i], true);
                        else
                            quests[i] = new Question(32, sorted2.ToArray()[i], false);
                    }
                    break;
                case 33:
                    for (int i = 0; i < quests.Length; i++)
                    {
                        if (i <= 4)
                            quests[i] = new Question(33, true, 1000);
                        else
                            quests[i] = new Question(33, false, 1000);
                    }
                    break;
            }
            return quests;
        }
    }
}
