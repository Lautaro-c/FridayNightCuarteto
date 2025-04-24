using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Player
    {
        private Image playerImage = Engine.LoadImage("assets/player.png");

        private PlayerController playerControl;
        private Transform transform;
        
        public Player(float positionX, float positionY)
        {
            transform = new Transform(positionX, positionY);
            playerControl = new PlayerController(transform);
        }

        public void Update()
        {
            playerControl.Update();
        }


        public void Render()
        {
            Engine.Draw(playerImage, transform.Posicion.x, transform.Posicion.y);
        }
    }
}

// PascalCase  => Clases, métodos
// camelCase   => atributos
