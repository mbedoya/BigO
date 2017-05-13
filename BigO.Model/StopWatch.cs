using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigO.Model
{
    public class StopWatch
    {
        private DateTime dateStarted;
        public StopWatch()
        {
            dateStarted = DateTime.Now;
        }

        public static StopWatch StartNew()
        {
            return new StopWatch();
        }

        public double ElapsedMilliseconds
        {
            get { return (DateTime.Now - dateStarted).TotalMilliseconds; }
        }
    }
}
