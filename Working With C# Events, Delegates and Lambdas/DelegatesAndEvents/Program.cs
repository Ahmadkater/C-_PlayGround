using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var ArithmeticOperation = new ApplyArithmetic();

            // Using Func<T,Tresult> , returns result
            Func<int,int,int> addFunc = (x,y) => x + y ;
            Func<int,int,int> subFunc = (x,y) => x - y ;
            Func<int,int,int> mulFunc = (x,y) => x * y ;
            ArithmeticOperation.ApplyFunc(18,10,subFunc);

            System.Console.WriteLine(" ");

            // Using Action<T> , no return as it is void
            Action<int,int> addAction = (x,y) => System.Console.WriteLine( x + y );
            Action<int,int> subAction = (x,y) => System.Console.WriteLine( x - y );
            Action<int,int> mulAction = (x,y) => System.Console.WriteLine( x * y );
            ArithmeticOperation.ApplyAction(3,5,addAction) ;

            System.Console.WriteLine(" ");

            // Using Custom Delegate
            ApplyArithmeticOperation add = (x, y) => x + y;
            ApplyArithmeticOperation sub = (x, y) => x - y;
            ApplyArithmeticOperation mul = (x, y) => x * y;
            ArithmeticOperation.Apply(2, 4, mul);

            System.Console.WriteLine(" ");

            // Event
            var worker = new Worker();

            //attach event to event handler
            worker.WorkPerformed += (s, e) => System.Console.WriteLine("hours worked: " + e.Hours + "  Task: " + e.WorkType);
            worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);

            worker.WorkCompleted += delegate (object sender, EventArgs e)
            {
                System.Console.WriteLine(" Worker finished Working");
            };

            // detach event from event handler
            worker.WorkCompleted -= Worker_WorkCompleted;

            worker.DoWork(8, WorkType.GenerateReports);

        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            System.Console.WriteLine("Worker is done");
        }
        /*
        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            System.Console.WriteLine("hours worked: " + e.Hours + "  Task: "+ e.WorkType);
        }
        */

    }
}
