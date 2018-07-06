using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    public class ForEachLoopExample
    {

        public void foreacheg()
        {
            int[] EvenNumbers = new int[] {2,4,6,8,10,12,14,16,18,20,22,24,26,28,30 };
            foreach (var EvenNumber in EvenNumbers)
            {
                Console.Write(EvenNumber + " \t");
            }
        }

    }
}
