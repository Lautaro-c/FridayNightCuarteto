using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Player
    {
        private Animation animation;
        private PlayerController playerControl;
        private PlayerMovement playerMovement;
        private Transform transform;
        
        public Transform Transform => transform;
        public PlayerMovement PlayerMovement => playerMovement;
       
        public Player(float positionX, float positionY)
        {
            transform = new Transform(positionX, positionY);
            playerControl = new PlayerController();
            playerMovement = new PlayerMovement(transform);
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

        public void Update()
        {
            playerControl.Update();
            animation.Update();
        }


        public void Render()
        {
            Engine.Draw(animation.CurrentImage, transform.Pos.x +250 , transform.Pos.y + 250);
        }
    }
}

