using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Transform
    {
        private Vector2 pos;
        public Vector2 Pos => pos;

        public Transform(float positionX, float positionY)
        {
            pos.x = positionX;
            pos.y = positionY;
        }

        public void Translate(float directionX, float directionY)
        {
            pos.x += directionX;
            pos.y += directionY;
        }
    }  
}
