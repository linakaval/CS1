using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoachTester
{
    class RoachPopulation
    {
        private int myCount;

        public RoachPopulation(int aRoachCount)
        {
            myCount = aRoachCount;
        }

        /// <summary>
        /// Doubles the roach population.
        /// </summary>
        /// <param name="roachCount"></param>
        public void waitForDoubling ()
        {
            myCount *= 2;
        }

        /// <summary>
        /// Reduces the roach population by 10%.
        /// </summary>
        /// <param name="roachCount"></param>
        public void spray ()
        {
            myCount = myCount - myCount / 10;
        }

        /// <summary>
        /// Reports the roach population number.
        /// </summary>
        /// <returns></returns>
        public int getRoaches()
        {
            return myCount;
        }
    }
}
