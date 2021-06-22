using System;

namespace DelegatesAndEvents
{
    public delegate int WorkPerformedHandler(int Hours , WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler d1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler d2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler d3 = new WorkPerformedHandler(WorkPerformed3);

            d1 += d2 + d3 ;
            var number = d1(5 , WorkType.Golf);
            System.Console.WriteLine(number);
            
        }

        private static int WorkPerformed3(int hours, WorkType work)
        {
            System.Console.WriteLine("WorkPerformed 3 called " + hours.ToString());
            return hours + 3 ;
        }

        public static void DoWork(WorkPerformedHandler del)
        {
            del(4 , WorkType.GoToMeeting);
        }

        public static int WorkPerformed1(int hours , WorkType work)
        {
            System.Console.WriteLine("WorkPerformed 1 called " + hours.ToString());
            return hours + 1 ;
        }

        public static int WorkPerformed2(int hours , WorkType work)
        {
            System.Console.WriteLine("WorkPerformed 2 called " + hours.ToString());
            return hours + 2 ;
        }

    }
}
