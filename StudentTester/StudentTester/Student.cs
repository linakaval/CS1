//Lina Kaval
//Period 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester
{
    class Student
    {
        private string myName;
        private double myTotalScore;
        private double myScoreCount;

        /// <summary>
        /// Constructs a Student object
        /// </summary>
        /// <param name="aName">Name of the student</param>
        public Student(string aName)
        {
            myName = aName;
        }

        /// <summary>
        /// Gets and returns the name of the student
        /// </summary>
        /// <returns>The student's name</returns>
        public string getName()
        {
            return myName;
        }
        
        /// <summary>
        /// Gets and returns the total score of the student
        /// </summary>
        /// <returns>The student's total score</returns>
        public double getTotalScore()
        {
            return myTotalScore;
        }

        /// <summary>
        /// Gets and returns the average score of the student
        /// </summary>
        /// <returns>The student's average score</returns>
        public double getAverageScore()
        {
            return myTotalScore / myScoreCount;
        }

        /// <summary>
        /// Adds a score from the user to the total score
        /// </summary>
        /// <param name="score">A test score</param>
        public void addScore(double score)
        {
            myTotalScore += score;
            myScoreCount += 1;
        }
    }
}
