using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    public class ArrayExample
    {
        /// <summary>
        /// Initialing Array and displaying them with foreach loop
        /// </summary>
        public void ArrExample()
        {
            /*Integer Array Initialization  */
            int[] EvenNumbers = new int[] {2,4,6,8,10,12,14,16,18,20 };

            //Displaying Array Data with Foreach Loop
            foreach (var EvenNumber in EvenNumbers)
            {
                Console.WriteLine(EvenNumber);
            }
        }

    }
}
