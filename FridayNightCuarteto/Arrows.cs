using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Arrows : GameObject<Arrows>, IAnimatable, IDestroyable
    {
        private Image arrowImage;
        private ChoseArrowImage choseArrowImage;
        private Animation animation;
        private ArrowMovement arrowMovement;
        private bool isPlayingAnimation = false;
        private bool canMove = false;
        private bool isStatic = false;
        private static float sizeValue = 76;
        private int screenLimit = 152;

        public Image ArrowImage => arrowImage;
        public bool IsStatic() => isStatic;
        public float PositionX => transform.Pos.x;


        public Arrows(float positionX, float positionY, bool isStatic)
            : base(positionX, positionY, sizeValue, sizeValue, 0f, 0f)
        {
            arrowMovement = new ArrowMovement(transform);
            this.isStatic = isStatic;
            choseArrowImage = new ChoseArrowImage(transform, isStatic);
            arrowImage = choseArrowImage.GetImage();
            renderer = new Renderer();
        }

        public void UpdateAnimation()
        {
            if (isPlayingAnimation)
            {
                animation?.Update();

                if (animation != null && animation.IsFinished)
                {
                    isPlayingAnimation = false;
                    animation = null;
                    arrowImage = choseArrowImage.GetImage();
                }
                else
                {
                    arrowImage = animation?.CurrentImage;
                }
            }
        }

        public Image GetCurrentFrame()
        {
            return arrowImage;
        }

        public void PlayAnimation()
        {
            if (animation == null)
            {
                string direction = "";
                switch ((int)transform.Pos.x)
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

        public override void Update()
        {
            canMove = true;

            if (canMove && !isStatic)
            {
                arrowMovement.Update();
            }

            if (transform.Pos.y <= -screenLimit)
            {
                Destroy();
            }
            UpdateAnimation();
        }

        public override void Render()
        {
            renderer.Render(GetCurrentFrame(), transform);
        }
        public void Destroy()
        {
            GameManager.Instance.LevelController.ArrowList.Remove(this);
            InvokeOnDeactive(this);
        }

        public void IsStaticFalse()
        {
            isStatic = false;
        }

        public void IsStaticTrue()
        {
            isStatic = true;
        }


        public void ChooseImage()
        {
            choseArrowImage = new ChoseArrowImage(transform, isStatic);
            arrowImage = choseArrowImage.GetImage();
        }

    }

}