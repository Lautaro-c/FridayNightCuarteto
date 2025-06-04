using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Player : GameObject <Player>
    {
        private Animation animation;
        private PlayerController playerControl;
        private PlayerMovement playerMovement;
       
        private static float sizeValue = 120;
        
        public PlayerMovement PlayerMovement => playerMovement;


       
        public Player(float positionX, float positionY) : base(positionX, positionY, sizeValue, sizeValue, 0f, 0f)
        {
            playerControl = new PlayerController();
            playerMovement = new PlayerMovement(transform);
            renderer = new Renderer();
            CreateAnimaton();
        }

        public void CreateAnimaton()
        {
            List<Image> images = new List<Image>();

            for (int i = 0; i < 11; i++)
            {
                Image image = Engine.LoadImage($"assets/Prota/{i}.gif");
                images.Add(image);
            }
            animation = new Animation("Prota", true, 0.1f, images);
        }

        public override void Update()
        {
            playerControl.Update();
            animation.Update();
        }


        public override void Render()
        {
            renderer.Render(animation.CurrentImage, transform);
        }
    }
}

