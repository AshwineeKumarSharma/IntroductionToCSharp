using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    public class IfStatementExample
    {
            public  void IfExample()
        {
            Console.WriteLine("Please Enter Your Number");
            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber==1)
            {
                Console.WriteLine("The Number You Entered is 1");
            }

            else
            {
                Console.WriteLine("Your Entered Number IS : " +UserNumber);
            }
        }
     
    }
}
