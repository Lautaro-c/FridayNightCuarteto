using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private Image enemyImage = Engine.LoadImage("assets/enemy.png");
        private Transform transform;
        private EnemyMovement enemyMovement;

        public Enemy(float positionX, float positionY)
        {
            transform = new Transform(positionX, positionY);
            enemyMovement = new EnemyMovement(transform);
        }

        public void Update()
        {
            enemyMovement.Update();
        }

        public void Render()
        {
            Engine.Draw(enemyImage, transform.Posicion.x, transform.Posicion.y);
        }
    }
}