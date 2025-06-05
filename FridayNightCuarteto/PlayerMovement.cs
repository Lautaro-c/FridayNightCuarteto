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
        private int rightLimit = 500;
        private int downLimit = 600;

        public PlayerMovement(Transform transform)
        { 
            this.transform = transform; 
        }

        public void MovePlayer(float directionX, float directionY)
        {
            if (transform.Pos.x + directionX >= 0 && transform.Pos.y + directionY >= 0 && transform.Pos.x + directionX <= rightLimit && transform.Pos.y + directionY <= downLimit)
            {
                GameManager.Instance.LevelController.Player1.Transform.Translate(directionX, directionY);
            }
        }
    }
}