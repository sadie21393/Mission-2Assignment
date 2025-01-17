using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2Assignment
{
    public class Class2
    { 
        public static List<int> ThrowDice(int roll)
        {
            Random random = new Random();

            List<int> list = new List<int>();

            for (int i = 0; i < roll; i++)
            {
                //roll the two dices
                int randomNum1 = random.Next(1, 7);
                int randomNum2 = random.Next(1, 7);
                //add values together
                int sum = randomNum1 + randomNum2;
                //add to list 
                list.Add(sum);
            }


            return list;
        }
    }
}
