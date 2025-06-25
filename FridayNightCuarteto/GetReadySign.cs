using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class GetReadySign : GameObject<GetReadySign>, IAnimatable
    {
        private static int positionX = 700;
        private static int positionY = 300;
        private static int sizeValueX = 187;
        private static int sizeValueY = 138;
        private float animationDelay = 0.5f;
        private float destroyTime = 11f;
        private Animation animation;
        private bool ArrowIsActive;
        public GetReadySign() : base(positionX, positionY, sizeValueX, sizeValueY, 0f, 0f)
        {
            renderer = new Renderer();
            CreateAnimation();
            ArrowIsActive = true;
        }

        public void CreateAnimation()
        {
            List<Image> images = new List<Image>();

            for (int i = 0; i < 9; i++)
            {
                Image image = Engine.LoadImage($"assets/GetReadyFrames/{i}.png");
                images.Add(image);
            }
            animation = new Animation("ReadySign", true, animationDelay, images);
        }

        public Image GetCurrentFrame()
        {
            return animation?.CurrentImage;
        }

        public override void Render()
        {
            if (ArrowIsActive == true)
            {
                renderer.Render(GetCurrentFrame(), transform);
            }
        }

        public override void Update()
        {
            if (ArrowIsActive == true)
            {
                animation?.Update();
                DestroySign();
            }
        }

        public void DestroySign()
        {
            if (GameManager.Instance.LevelController.Stopwatch.Elapsed.TotalSeconds >= destroyTime)
            {
                ArrowIsActive = false;
            }
        }
    }
}
