using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Bullet
    {
        private Image bulletImage = Engine.LoadImage("assets/bullet.png");

        private float posX = 0;
        private float posY = 0;
        private float speed = 2;

        public Bullet(float positionX, float positionY)
        {
            posX = positionX;
            posY = positionY;
        }

        public void Update()
        {
            posY -= speed;
        }

        public void Render()
        {
            Engine.Draw(bulletImage, posX, posY);
        }
    }
}
