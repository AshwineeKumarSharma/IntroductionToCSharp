using System;

namespace IntroductionToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IfStatementExample ifStatementExample = new IfStatementExample();
            ArrayExample arrayExample = new ArrayExample();
            SwitchCaseExample switchCaseExample = new SwitchCaseExample();
            WhileLoopExample whileLoopExample = new WhileLoopExample();
            DoWhileLoopExample doWhileLoopExample = new DoWhileLoopExample();
            ForLoopExample forLoopExample = new ForLoopExample();
            ForEachLoopExample forEachLoopExample = new ForEachLoopExample();
            StringClass s = new StringClass();
            AdditionClass p = new AdditionClass();
            int sum= p.AddingTwoNumbers(30,40);
            Console.WriteLine(sum);
        }
    }






    public class StringClass
    {
        public string ReturningString(string Name)
        {
            return Name;
        }
    }



    /// <summary>
    /// Int Method for Adding two numbers and returning the Sum
    /// </summary>
    public class AdditionClass
    {
        public int AddingTwoNumbers(int FN, int SN)
        {
            return FN + SN;
        }
    }





}
