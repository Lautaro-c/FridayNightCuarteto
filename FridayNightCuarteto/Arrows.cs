using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private Transform size; 
        private ArrowMovement arrowMovement;

        private const float leftArrowPos = 628;
        private const float downArrowPos = 728;
        private const float upArrowPos = 828;
        private const float rightArrowPos = 928;
        private bool canMove = false;
        private bool isStatic = false;

        private static Stopwatch stopwatch = new Stopwatch();
        private float spawnTime;

        public bool IsStatic => isStatic;
        public Transform Transform => transform;
        public Transform Size => size;



        public Arrows(float positionX, float positionY, bool isStatic, float spawnTime)
        {
            stopwatch.Start();
            transform = new Transform(positionX, positionY);
            size = new Transform(76, 76);
            arrowMovement = new ArrowMovement(transform);
            this.isStatic = isStatic;
            this.spawnTime = spawnTime;
            ChoseArrow();
        }

        private void ChoseArrow()
        {
            switch (transform.Posicion.x)
            {
                case leftArrowPos:
                    if(isStatic == false)
                    {
                        arrowImage = leftArrowImage;
                    }else
                    {
                        arrowImage = leftArrowSImage;
                    }
                    break;
                case rightArrowPos:
                    if (isStatic == false)
                    {
                        arrowImage = rightArrowImage;
                    }else
                    {
                        arrowImage = rightArrowSImage;
                    }
                    break;
                case downArrowPos:
                    if (isStatic == false)
                    {
                        arrowImage = downArrowImage;
                    }else
                    {
                        arrowImage = downArrowSImage;
                    }
                    break;
                case upArrowPos:
                    if (isStatic == false)
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
            if (stopwatch.Elapsed.TotalSeconds >= spawnTime)
            {
                canMove = true;
            }
            if(canMove && isStatic == false)
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