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

        private Transform transform;
        private DateTime lastTimeLeftArrow = DateTime.Now;
        private DateTime lastTimeRightArrow = DateTime.Now;
        private DateTime lastTimeDownArrow = DateTime.Now;
        private DateTime lastTimeUpArrow = DateTime.Now;
        private Player player;
        Stopwatch stopwatch = new Stopwatch();
        private Collition collition;
        private int speed = 100;
        public PlayerController(Transform transform)
        {
            this.transform = transform;
            stopwatch.Start();
            collition = new Collition();
        }

        public void Update()
        {

            if (Engine.GetKey(Engine.KEY_A))
            {
                if((DateTime.Now - lastTimeLeftArrow).TotalSeconds >= 0.25)
                {
                    //Engine.Debug($"arrowList.Add(new Arrows(leftArrowPos, 768, false, {stopwatch.Elapsed.TotalSeconds:F2}f));");
                    collition.GetLeftCollition();
                    lastTimeLeftArrow = DateTime.Now;
                    GameManager.Instance.LevelController.Player1.PlayerMovement.MovePlayer(-speed, 0);
                }
            }

            if (Engine.GetKey(Engine.KEY_D))
            {
                if ((DateTime.Now - lastTimeRightArrow).TotalSeconds >= 0.25)
                {
                    //Engine.Debug($"arrowList.Add(new Arrows(rightArrowPos, 768, false, {stopwatch.Elapsed.TotalSeconds:F2}f));");
                    collition.GetRightCollition();
                    lastTimeRightArrow = DateTime.Now;
                    GameManager.Instance.LevelController.Player1.PlayerMovement.MovePlayer(speed, 0);
                }
            }

            if (Engine.GetKey(Engine.KEY_W))
            {
                if ((DateTime.Now - lastTimeUpArrow).TotalSeconds >= 0.25)
                {
                    //Engine.Debug($"arrowList.Add(new Arrows(upArrowPos, 768, false, {stopwatch.Elapsed.TotalSeconds:F2}f));");
                    collition.GetUpCollition();
                    lastTimeUpArrow = DateTime.Now;
                    GameManager.Instance.LevelController.Player1.PlayerMovement.MovePlayer(0, -speed);
                }
            }

            if (Engine.GetKey(Engine.KEY_S))
            {
                if ((DateTime.Now - lastTimeDownArrow).TotalSeconds >= 0.25)
                {
                    //Engine.Debug($"arrowList.Add(new Arrows(downArrowPos, 768, false, {stopwatch.Elapsed.TotalSeconds:F2}f));");
                    collition.GetDownCollition();
                    lastTimeDownArrow = DateTime.Now;
                    GameManager.Instance.LevelController.Player1.PlayerMovement.MovePlayer(0, speed);
                }
            }

        }

    }
}
