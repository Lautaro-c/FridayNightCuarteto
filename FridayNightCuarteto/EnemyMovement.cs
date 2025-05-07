using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class EnemyMovement
    {
        private Transform transform;
        private float speed = 2;

        public EnemyMovement(Transform transform)
        {
            this.transform = transform;
        }

        public void Update()
        {
            transform.Translate(speed, 0);

            if (transform.Pos.x > 1024 - 100 || transform.Pos.y < 0)
            {
                speed = speed * -1;
            }
        }
    }
}
