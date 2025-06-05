using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class HUD
    {
        private Font font = Engine.LoadFont("assets/arial.ttf", 40);
        private int points = 0;

        public void Render()
        {
            points = GameManager.Instance.Points.RythmPoints;
            Engine.DrawText("Puntos: " + points, 0, 0, 255, 255, 255, font);
        }
    }


}
