using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.chapter17
{
    class question1705
    {
        static void NotMain(String[] args)
        {
            Console.WriteLine(GetResult("GGRR", "RGBY"));
            Console.Read();
        }

        class Result
        {
            int hits;
            int pseudohits;
            public Result(int hits, int pseudohits)
            {
                this.hits = hits;
                this.pseudohits = pseudohits;
            }


            public override String ToString()
            {
                return "hits: " + hits + ", pseodo hits: " + pseudohits;
            }
        }

        static Result GetResult(String correct, String guess)
        {
            if (correct.Length != guess.Length || correct.Length != 4)
                return null;
            int hits = 0;
            for (int i = 0; i < correct.Length; i++)
                if (correct[i] == guess[i])
                    hits++;
            int[] correctV = new int[128];
            int[] guessV = new int[128];
            for (int i = 0; i < guess.Length; i++)
            {
                correctV[correct[i]]++;
                guessV[guess[i]]++;
            }
            int pseudohits = 0;
            for (int i = 0; i < correctV.Length; i++)
            {
                pseudohits += Math.Min(correctV[i], guessV[i]);
            }
            pseudohits -= hits;
            return new Result(hits, pseudohits);
        }
    }
}
