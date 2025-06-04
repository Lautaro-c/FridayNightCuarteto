
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class ChoseArrowImage 
    {
        static private Image leftArrowImage = Engine.LoadImage("assets/LeftArrow.png");
        static private Image rightArrowImage = Engine.LoadImage("assets/RightArrow.png");
        static private Image downArrowImage = Engine.LoadImage("assets/DownArrow.png");
        static private Image upArrowImage = Engine.LoadImage("assets/UpArrow.png");
        static private Image leftArrowSImage = Engine.LoadImage("assets/LeftArrowU.png");
        static private Image rightArrowSImage = Engine.LoadImage("assets/RightArrowU.png");
        static private Image downArrowSImage = Engine.LoadImage("assets/DownArrowU.png");
        static private Image upArrowSImage = Engine.LoadImage("assets/UpArrowU.png");
        private Transform transform;
        private bool isStatic;
        private Image arrowImage;
        private const float leftArrowPos = 628;
        private const float downArrowPos = 728;
        private const float upArrowPos = 828;
        private const float rightArrowPos = 928;
        //private Animation animation;
        public ChoseArrowImage(Transform transform, bool isStatic) 
        {
            this.transform = transform;
            this.isStatic = isStatic;
            ChoseImage();
        }

        public Image GetImage()
        {
            return arrowImage;
        }

        private void ChoseImage()
        {
            switch (transform.Pos.x)
            {
                case leftArrowPos:
                    if (isStatic == false)
                    {
                        arrowImage = leftArrowImage;
                    }
                    else
                    {
                        arrowImage = leftArrowSImage;
                    }
                    break;
                case rightArrowPos:
                    if (isStatic == false)
                    {
                        arrowImage = rightArrowImage;
                    }
                    else
                    {
                        arrowImage = rightArrowSImage;
                    }
                    break;
                case downArrowPos:
                    if (isStatic == false)
                    {
                        arrowImage = downArrowImage;
                    }
                    else
                    {
                        arrowImage = downArrowSImage;
                    }
                    break;
                case upArrowPos:
                    if (isStatic == false)
                    {
                        arrowImage = upArrowImage;
                    }
                    else
                    {
                        arrowImage = upArrowSImage;
                    }
                    break;
            }

            if (arrowImage == null)
            {
                arrowImage = rightArrowImage;
            }
            
        }
    }
}