using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PomodoroClock
{
    public class Timer
    {
        // Fields
        private int minutes;

        // Constructors
        public Timer()
        {
            minutes = 25;
        }

        public Timer(int timerLength)
        {
            minutes = timerLength;
        }

        // Function
        public void Start()
        {
            int seconds = minutes * 60;

            while (seconds >= 0)
            {
                Console.Write("\r{0}:{1}", seconds / 60, seconds % 60);
                seconds--;
                Thread.Sleep(1000);
            }
        }
    }
}
