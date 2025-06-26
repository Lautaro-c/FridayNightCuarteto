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
    public class TriggerArrowAnimation
    {
        public enum ArrowDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        public void TriggerAnimation(ArrowDirection direction)
        {
            float targetX = 0;

            switch (direction)
            {
                case ArrowDirection.Left:
                    targetX = 628;
                    break;
                case ArrowDirection.Down:
                    targetX = 728;
                    break;
                case ArrowDirection.Up:
                    targetX = 828;
                    break;
                case ArrowDirection.Right:
                    targetX = 928;
                    break;
            }

            foreach (var arrow in GameManager.Instance.LevelController.ArrowList)
            {
                if (arrow.IsStatic() && Math.Abs(arrow.PositionX - targetX) < 1f)
                {
                    arrow.PlayAnimation();
                }
            }
        }
    }
}