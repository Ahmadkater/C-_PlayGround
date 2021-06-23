using System;

namespace DelegatesAndEvents
{
    public delegate int ApplyArithmeticOperation(int n1 , int n2) ;
    public class ApplyArithmetic
    {
        public void Apply(int x , int y , ApplyArithmeticOperation del)
        {
            System.Console.WriteLine(del(x,y));
        }

        public void ApplyAction(int x , int y , Action<int , int > action)
        {
            action(x,y);
            System.Console.WriteLine("Arithmetic Action has been applied");
            
        }
    }
    
}