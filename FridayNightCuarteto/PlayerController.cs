using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyGame
{
    public class PlayerController
    {
        private DateTime lastTimeLeftArrow = DateTime.Now;
        private DateTime lastTimeRightArrow = DateTime.Now;
        private DateTime lastTimeDownArrow = DateTime.Now;
        private DateTime lastTimeUpArrow = DateTime.Now;
        private Collider collider;
        private int speed = 100;
        public PlayerController()
        {
            collider = new Collider();
        }

        public void Update()
        {
            if (Engine.GetKey(Engine.KEY_A))
            {
                if((DateTime.Now - lastTimeLeftArrow).TotalSeconds >= 0.25)
                {
                    //Engine.Debug($"arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, {stopwatch.Elapsed.TotalSeconds:F2}f));");
                    collider.GetLeftCollition();
                    lastTimeLeftArrow = DateTime.Now;
                    GameManager.Instance.LevelController.Player1.PlayerMovement.MovePlayer(-speed, 0);
                }
            }

            if (Engine.GetKey(Engine.KEY_D))
            {
                if ((DateTime.Now - lastTimeRightArrow).TotalSeconds >= 0.25)
                {
                    //Engine.Debug($"arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, {stopwatch.Elapsed.TotalSeconds:F2}f));");
                    collider.GetRightCollition();
                    lastTimeRightArrow = DateTime.Now;
                    GameManager.Instance.LevelController.Player1.PlayerMovement.MovePlayer(speed, 0);
                }
            }

            if (Engine.GetKey(Engine.KEY_W))
            {
                if ((DateTime.Now - lastTimeUpArrow).TotalSeconds >= 0.25)
                {
                    //Engine.Debug($"arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, {stopwatch.Elapsed.TotalSeconds:F2}f));");
                    collider.GetUpCollition();
                    lastTimeUpArrow = DateTime.Now;
                    GameManager.Instance.LevelController.Player1.PlayerMovement.MovePlayer(0, -speed);
                }
            }

            if (Engine.GetKey(Engine.KEY_S))
            {
                if ((DateTime.Now - lastTimeDownArrow).TotalSeconds >= 0.25)
                {
                    //Engine.Debug($"arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, {stopwatch.Elapsed.TotalSeconds:F2}f));");
                    collider.GetDownCollition();
                    lastTimeDownArrow = DateTime.Now;
                    GameManager.Instance.LevelController.Player1.PlayerMovement.MovePlayer(0, speed);
                }
            }

        }

    }
}
