using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Asynchronous_Timer
{
    public class AsynchronousTimer
    {
        private int interval;
        private int ticks;

        public AsynchronousTimer(int ticks,int interval,Action<int> action)
        {
            this.Ticks = ticks;
            this.Interval = interval;
            this.Action = action;
        }
        public int Interval
        {
            get { return this.interval; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval cannot be negative!");
                }
                this.interval = value;
            } 
        }

        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval cannot be negative!");
                }
                this.ticks = value;
            }
        }

        public Action<int> Action { get; private set; }

        public void Execute()
        {
            Thread timer=new Thread(this.Timer);
            timer.Start();
        }

        public void Timer()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
               Thread.Sleep(this.Interval);
                if (this.Action != null)
                {
                    this.Action(i);
                }
            }
        }
    }
}
