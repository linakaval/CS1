using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester
{
    class Car
    {
        private double myMPG;
        private double myGasTank;

        public Car(double aMPG)
        {
            myMPG = aMPG;
        }

        /// <summary>
        /// Reports the amount of gas in the tank.
        /// </summary>
        /// <returns>The number of gallons in the tank.</returns>
        public double getGas()
        {
            return myGasTank;
        }

        /// <summary>
        /// Fills the tank.
        /// </summary>
        /// <param name="gallons"></param>
        public void addGas(double gallons)
        {
            myGasTank = myGasTank + gallons;
            //myGasTank += amount;
        }

        /// <summary>
        /// Simulates driving.
        /// </summary>
        /// <param name="miles"></param>
        public void drive(double miles)
        {
            myGasTank = myGasTank - miles / myMPG;
            //myGasTank -= miles / myMPG
        }
    }
}
