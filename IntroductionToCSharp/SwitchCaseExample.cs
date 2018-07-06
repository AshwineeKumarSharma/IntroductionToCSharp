using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    public class SwitchCaseExample
    {
         public void SwitchCExample()
        {

            int TotalPopcornCost = 0;

            Start:

            Console.WriteLine("Please Enter Your Choice For Bucket of Popcorn".ToUpper());
            Console.WriteLine("1 - Small \n2 - Medium \n3 - Large");

            int UserChoice = int.Parse(Console.ReadLine());


            switch (UserChoice)
            {
                case 1:
                    TotalPopcornCost += 10;
                    break;

                case 2:
                    TotalPopcornCost += 20;
                    break;

                case 3:
                    TotalPopcornCost += 30;
                    break;

                default:
                    Console.WriteLine("Your Choice {0} is Invalid", UserChoice);
                    goto Start;
            }

            DecisionLocation:
            Console.WriteLine("Do You Want To Buy Some More PopCorn? Yes or No ");
            string CustomerChoice=Console.ReadLine();


            switch (CustomerChoice.ToLower())
            {
                case "yes":
                
                    goto Start;
                    

                case "no":
               

                    break;


                default:
                    Console.WriteLine("Your Choice {0} is Invalid. Please Try Again!!",CustomerChoice);
                    goto DecisionLocation;
                    
            }



            Console.WriteLine("Thank You For Shopping With Us!!");
            Console.WriteLine("Your PopCorn Bucket Cost is : {0} " ,TotalPopcornCost);
        }

    }
}

