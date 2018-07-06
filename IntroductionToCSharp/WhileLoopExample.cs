using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    public class WhileLoopExample
    {
        public void WhileExample()
        {
            int TargetNumber = 0;

            Console.WriteLine("Enter Your Target Number");
            TargetNumber = int.Parse(Console.ReadLine());

            int Start = 0;

            Console.WriteLine("Your Even Numbers are : ");
            while (Start<=TargetNumber)
            {
                Console.Write(Start+"\t");
                Start = Start+2;
            }
    }
    }
}
