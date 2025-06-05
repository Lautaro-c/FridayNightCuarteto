using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Animation
    {
        private string name;
        private bool isLooping;
        private float speed;
        private List<Image> image;
        private float actualTime;
        private int actualFrame;
        public Image CurrentImage => image[actualFrame];
        public bool IsFinished => !isLooping && actualFrame == image.Count - 1;


        public Animation(string name, bool isLooping, float speed, List<Image> image)
        {
            this.name = name;
            this.isLooping = isLooping;
            this.speed = speed;
            this.image = image;
        }

        public void Update()
        {
            actualTime += Time.DeltaTime;
           
            if (actualTime > speed) 
            {
                actualTime = 0;
                actualFrame++;

                if (actualFrame >= image.Count) 
                {
                    if (isLooping)
                    {
                        actualFrame = 0;    
                    }
                    else
                    {
                        actualFrame--;
                    }
                }

            }
        }
    }
}
