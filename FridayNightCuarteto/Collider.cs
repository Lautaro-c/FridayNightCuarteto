using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyGame
{
    public class Collider
    {
        public Collider() 
        { }

        public bool BoxCollider(Transform transform1, Transform transform2)
        {
            float distanceX = Math.Abs((transform1.Pos.x + transform1.Scale.x / 2) - (transform2.Pos.x + transform2.Scale.x / 2));
            float distanceY = Math.Abs((transform1.Pos.y + transform1.Scale.y / 2) - (transform2.Pos.y + transform2.Scale.y / 2));

            float sumHalfWidths = transform1.Scale.x / 2 + transform2.Scale.x / 2;
            float sumHalfHeight = transform1.Scale.y / 2 + transform2.Scale.y / 2;

            if (distanceX < sumHalfWidths && distanceY < sumHalfHeight)
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}
