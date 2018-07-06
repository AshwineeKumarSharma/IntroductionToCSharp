using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    public class DoWhileLoopExample
    {
        public void DoWhileLoop()
        {
            string UserChoice = "";
            do
            {
                int Start = 0;
                Console.WriteLine("Enter Your Target Number");
                int TargetNumber = int.Parse(Console.ReadLine());

                while (Start <= TargetNumber)
                {
                    Console.Write(Start + " \t");
                    Start = Start + 2;
                }
                
                do
                {
                    Console.WriteLine("\n \n"+"Do You Want To Continue? Yes or No?");
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice Please Say Yes or No.");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");

            } while (UserChoice == "YES");

            Console.WriteLine("Thank You For Using This Program!!!");
        }

    }
}
