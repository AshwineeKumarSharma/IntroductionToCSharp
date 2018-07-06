using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    public class ForLoopExample
    {

        public void ForLoopEg()
        {
            Console.WriteLine("Please Input Your Initial Number");
            int initialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input Your Deadline Number");
            int deadlineNumber = int.Parse(Console.ReadLine());

            for (int i = initialNumber; i <= deadlineNumber; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

        }

    }
}

