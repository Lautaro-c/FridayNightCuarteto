using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class PlayerController
    {
        
        private float speed;
        private float timeBetweenShoot = 1;

        private Transform transform;

        

        public float Speed => speed;

        private DateTime timeLastShoot;


        public PlayerController(Transform transform)
        {
            this.transform = transform;
        }

        public void Update()
        {
            if (Engine.GetKey(Engine.KEY_A))
            {
                transform.Translate(-1, 0);
            }

            if (Engine.GetKey(Engine.KEY_D))
            {
                transform.Translate(1, 0);
            }

            if (Engine.GetKey(Engine.KEY_W))
            {
                transform.Translate(0, -1);
            }

            if (Engine.GetKey(Engine.KEY_S))
            {
                transform.Translate(0, 1);
            }

        }

    }
}
