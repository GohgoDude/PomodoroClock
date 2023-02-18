using System;

namespace PomodoroClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter how many minutes you would like to study: ");
            int studyLength = int.Parse(Console.ReadLine());

            Console.Write("Please enter how many minutes you would like to relax: ");
            int relaxLength = int.Parse(Console.ReadLine());

            Timer studyTimer = new Timer(studyLength);
            Timer relaxTimer = new Timer(relaxLength);

            while (true)
            {
                studyTimer.Start();
                relaxTimer.Start();
            }
        }
    }
}
