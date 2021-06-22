using System;

namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int Hours , WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler d1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler d2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler d3 = new WorkPerformedHandler(WorkPerformed3);

            d1 += d2 + d3 ;
            d1(5 , WorkType.Golf);
        }

        private static void WorkPerformed3(int hours, WorkType work)
        {
            System.Console.WriteLine("WorkPerformed 3 called " + hours.ToString());
        }

        public static void DoWork(WorkPerformedHandler del)
        {
            del(4 , WorkType.GoToMeeting);
        }

        public static void WorkPerformed1(int hours , WorkType work)
        {
            System.Console.WriteLine("WorkPerformed 1 called " + hours.ToString());
        }

        public static void WorkPerformed2(int hours , WorkType work)
        {
            System.Console.WriteLine("WorkPerformed 2 called " + hours.ToString());
        }

    }
}
