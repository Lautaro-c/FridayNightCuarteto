using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Time
    {
        static private float deltaTime;
        static private DateTime initialTime;
        static private float lastTimeFrame;

        static public float DeltaTime => deltaTime;

        static public void Initialize()
        {
            initialTime = DateTime.Now;
        }
        static public void Update()
        {
            float currentTime = (float)(DateTime.Now - initialTime).TotalSeconds;
            deltaTime = currentTime - lastTimeFrame;
            lastTimeFrame = currentTime;
        }
    }
}
