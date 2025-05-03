using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Arrows
    {
        static private Image leftArrowImage = Engine.LoadImage("assets/FlechasIzq.jpg");
        static private Image rightArrowImage = Engine.LoadImage("assets/FlechaDer.jpg");
        static private Image downArrowImage = Engine.LoadImage("assets/FlechaAb.jpg");
        static private Image upArrowImage = Engine.LoadImage("assets/FlechaAr.jpg");
        static private Image leftArrowSImage = Engine.LoadImage("assets/FlechaIzqA.jpg");
        static private Image rightArrowSImage = Engine.LoadImage("assets/FlechaDerA.jpg");
        static private Image downArrowSImage = Engine.LoadImage("assets/FlechaAbA.jpg");
        static private Image upArrowSImage = Engine.LoadImage("assets/FlechaArA.jpg");
        private Image arrowImage; 
        private Transform transform;
        private ArrowMovement arrowMovement;
        private const float leftArrowPos = 628;
        private const float downArrowPos = 728;
        private const float upArrowPos = 828;
        private const float rightArrowPos = 928;
        private bool canMove = false;

        public Arrows(float positionX, float positionY, bool canMove)
        {
            transform = new Transform(positionX, positionY);
            arrowMovement = new ArrowMovement(transform);
            this.canMove = canMove;
            ChoseArrow(); 
        }

        private void ChoseArrow()
        {
            switch (transform.Posicion.x)
            {
                case leftArrowPos:
                    if(canMove)
                    {
                        arrowImage = leftArrowImage;
                    }else
                    {
                        arrowImage = leftArrowSImage;
                    }
                    break;
                case rightArrowPos:
                    if (canMove)
                    {
                        arrowImage = rightArrowImage;
                    }else
                    {
                        arrowImage = rightArrowSImage;
                    }
                    break;
                case downArrowPos:
                    if (canMove)
                    {
                        arrowImage = downArrowImage;
                    }else
                    {
                        arrowImage = downArrowSImage;
                    }
                    break;
                case upArrowPos:
                    if (canMove)
                    {
                        arrowImage = upArrowImage;
                    }else
                    {
                        arrowImage = upArrowSImage;
                    }
                    break;
            }
        }

        public void Update()
        {
            if(canMove)
            {
                arrowMovement.Update();
            }
        }

        public void Render()
        {
            Engine.Draw(arrowImage, transform.Posicion.x, transform.Posicion.y);
        }
    }
}