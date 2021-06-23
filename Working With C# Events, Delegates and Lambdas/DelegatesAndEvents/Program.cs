using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ApplyArithmeticOperation add = (x, y) => x + y;
            ApplyArithmeticOperation sub = (x, y) => x - y;
            ApplyArithmeticOperation mul = (x, y) => x * y;

            var ArithmeticOperation = new ApplyArithmetic();

            ArithmeticOperation.Apply(2, 4, mul);

            System.Console.WriteLine(" ");

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
