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
        static private Image leftArrowImage = Engine.LoadImage("assets/LeftArrow.png");
        static private Image rightArrowImage = Engine.LoadImage("assets/RightArrow.png");
        static private Image downArrowImage = Engine.LoadImage("assets/DownArrow.png");
        static private Image upArrowImage = Engine.LoadImage("assets/UpArrow.png");
        static private Image leftArrowSImage = Engine.LoadImage("assets/LeftArrowU.png");
        static private Image rightArrowSImage = Engine.LoadImage("assets/RightArrowU.png");
        static private Image downArrowSImage = Engine.LoadImage("assets/DownArrowU.png");
        static private Image upArrowSImage = Engine.LoadImage("assets/UpArrowU.png");

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

        private float spawnTime;

        public Transform Transform => transform;
        public Transform Size => size;

        public Arrows(float positionX, float positionY, bool isStatic, float spawnTime)
        {
            transform = new Transform(positionX, positionY);
            size = new Transform(76, 76);
            arrowMovement = new ArrowMovement(transform);
            this.isStatic = isStatic;
            this.spawnTime = spawnTime;
            ChoseArrowImage();
        }

        private void ChoseArrowImage()
        {
            switch (transform.Pos.x)
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
            if (GameManager.Instance.LevelController.Stopwatch.Elapsed.TotalSeconds >= spawnTime)
            {
                canMove = true;
            }

            if(canMove && isStatic == false)
            {
                arrowMovement.Update();
            }

            DestroyArrow();
        }

        public void Render()
        {
            Engine.Draw(arrowImage, transform.Pos.x, transform.Pos.y);
        }

        private void DestroyArrow()
        {
            if(transform.Pos.y <= -152)
            {
                GameManager.Instance.LevelController.ArrowList.Remove(this);
            }
        }
    }
}