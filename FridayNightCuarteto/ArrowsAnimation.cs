using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class ArrowsAnimation
    {
        private bool isPlayingAnimation = false;
        private bool isStatic = false;
        private Animation animation;
        private Image arrowImage;
        private ChoseArrowImage choseArrowImage;
        private Arrows arrow;

        public ArrowsAnimation(Animation animation, ChoseArrowImage choseArrowImage, Image arrowImage, Arrows arrow)
        { 
            this.animation = animation; 
            this.choseArrowImage = choseArrowImage;
            this.arrowImage = arrowImage;
            this.arrow = arrow;
        }

        public Image UpdateAnimation()
        {
            if (isStatic)
            {
                if (isPlayingAnimation)
                {
                    animation?.Update();

                    if (animation != null && animation.IsFinished)
                    {
                        isPlayingAnimation = false;
                        animation = null;
                        arrowImage = choseArrowImage.GetImage();
                        return arrowImage;
                    }
                    else
                    {
                        arrowImage = animation?.CurrentImage;
                        return arrowImage;
                    }
                }
                else
                {
                    return arrowImage;
                }
            }
            else
            {
                return arrowImage;
            }
        }

        public void PlayAnimation()
        {
            if (animation == null)
            {
                string direction = "";
                switch ((int)arrow.Transform.Pos.x)
                {
                    case 628:
                        direction = "left";
                        break;
                    case 728:
                        direction = "down";
                        break;
                    case 828:
                        direction = "up";
                        break;
                    case 928:
                        direction = "right";
                        break;
                    default:
                        direction = "down";
                        break;
                }

                if (!isPlayingAnimation)
                {
                    List<Image> images = new List<Image>();
                    for (int i = 0; i < 3; i++)
                    {
                        Image image = Engine.LoadImage($"assets/AnimationArrow/{direction}/{i}.png");
                        images.Add(image);
                    }

                    animation = new Animation("arrow", false, 0.12f, images);
                }
            }

            isPlayingAnimation = true;
        }
    }
}
