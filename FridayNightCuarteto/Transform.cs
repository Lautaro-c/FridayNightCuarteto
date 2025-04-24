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

        private Vector2 posicion;

        public Vector2 Posicion => posicion;


        public Transform(float positionX, float positionY)
        {
            posicion.x = positionX;
            posicion.y = positionY;
        }

        public void Translate(float directionX, float directionY)
        {
            posicion.x += directionX;
            posicion.y += directionY;
        }
    }
}
