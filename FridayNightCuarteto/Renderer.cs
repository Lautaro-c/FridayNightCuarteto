using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Renderer
    {
        private Image drawingImage;
        private Transform transform;

        public void Render(Image image, Transform transform)
        {
            drawingImage = image;
            this.transform = transform;
            Engine.Draw(drawingImage, this.transform.Pos.x, this.transform.Pos.y, this.transform.Scale.x, this.transform.Scale.y);
        }
    }
}