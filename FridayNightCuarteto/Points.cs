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

        public int RythmPoints
        { 
            get 
            { 
                return rythmPoints; 
            }
            set 
            {
                if (value < 20)
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