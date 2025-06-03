using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public abstract class GameObject
    {
        protected Transform transform;

        protected Renderer renderer;


        public Transform Transform => transform;

        public GameObject(float positionX, float positionY, float scaleX, float scaleY, float rotationX, float rotationY)
        {
            transform = new Transform(positionX, positionY, scaleX, scaleY, rotationX, rotationY);
        }

        public abstract void Update();

        public abstract void Render();
    }
}
