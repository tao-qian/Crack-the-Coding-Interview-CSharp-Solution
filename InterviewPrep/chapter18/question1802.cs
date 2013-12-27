using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter18
{
    class question1802
    {
        public static void Shuffle(int[] cards)
        {
            Random r = new Random();
            for (int i = 0; i < cards.Length; i++)
            {
                int index = r.Next(cards.Length - i) + i;
                int temp = cards[i];
                cards[i] = cards[index];
                cards[index] = temp;
            }
        }
    }
}
