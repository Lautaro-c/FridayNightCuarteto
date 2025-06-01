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
        private Vector2 scale;
        private Vector2 rotation;
        public Vector2 Pos => pos;
        public Vector2 Scale => scale;
        public Vector2 Rotation => rotation;


        public Transform(float positionX, float positionY, float scaleX, float scaleY, float rotationX, float rotationY)
        {
            pos.x = positionX;
            pos.y = positionY;
            scale.x = scaleX;
            scale.y = scaleY;
            rotation.x = rotationX;
            rotation.y = rotationY;
        }

        public void Translate(float directionX, float directionY)
        {
            pos.x += directionX;
            pos.y += directionY;
        }
    }  
}
