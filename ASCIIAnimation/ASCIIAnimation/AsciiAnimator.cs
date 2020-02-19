//Lina Kaval Period 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ASCIIAnimation
{
    class AsciiAnimator
    {
        private int frameNumberMax;
        private int frameNumber = -1;
        string[] frames;
        //TODO:  Declare an array of strings named frames.  Don't 'new' it.

        public AsciiAnimator(string rawAnimation, string sep)
        {
            //String objects have a method named Split that will take a string and
            //split it into pieces.  The first parameter to the Split method is an
            //array of strings that are to be used as the split value.  I took the
            //separator parameter to the constructor and put it into an array.
            //Note that Split returns an array that contains the string pieces.
            //I saved the string pieces, which make up the frames of the animation,
            //in an array named frames, which you need to declare as an instance variable.
            string[] delim = { sep };
            frames = rawAnimation.Split( delim, StringSplitOptions.RemoveEmptyEntries);

            frameNumberMax = frames.Length;
        }

        public string getNextFrame()
        {
            frameNumber++;
            if (frameNumber == frameNumberMax)
            {
                frameNumber = 0;
            }
            return frames[frameNumber];

            //TODO:  Return the next frame of the animation.  Wrap around when the
            //          last animation is reached.

        }

        public int getCurrentFrameNumber()
        {
            return frameNumber;
            //TODO:  Return the current frame number.

        }
    }
}
