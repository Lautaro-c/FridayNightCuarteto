using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class PlayerMovement 
    {
        private Transform transform;

        public PlayerMovement(Transform transform)
        { 
            this.transform = transform; 
        }

        public void MovePlayer(float directionX, float directionY)
        {
            if (transform.Pos.x + directionX >= -200 && transform.Pos.y + directionY >= -200 && transform.Pos.x + directionX <= 200 && transform.Pos.y + directionY <= 400)
            {
                GameManager.Instance.LevelController.Player1.Transform.Translate(directionX, directionY);
            }
        }
    }
}