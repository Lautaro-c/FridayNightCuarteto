using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Points
    {
        private int rythmPoints;
        private int masPointsRecieved = 20;
        public int RythmPoints
        { 
            get 
            { 
                return rythmPoints; 
            }
            set 
            {
                if (value < masPointsRecieved)
                {
                    rythmPoints += value;
                    Engine.Debug($"{rythmPoints}");
                }
            }
        }

        public Points() 
        {
            rythmPoints = 0;
        }     
    }
}