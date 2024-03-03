using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartingTime => startTime;
        public DateTime EndingTime => endTime;

        public StopWatch() 
        {
            startTime = DateTime.Now;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        ////public double GetStarTime ()
        ////{
        //    //return startTime;
        ////}

        //public double GetEndTime()
        //{
        //    //return endTime;
        //}
    }
}
