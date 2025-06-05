using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class ArrowMovement 
    {
        private Transform transform;
        private float speed = -2;

        public ArrowMovement(Transform transform)
        {
            this.transform = transform;
        }

        public void Update()
        {
            transform.Translate(0, speed);
        }
    }
}
