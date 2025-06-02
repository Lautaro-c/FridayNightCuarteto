using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Collider
    {
        static private List<Arrows> arrowList;
        static private List<Arrows> leftArrowList = new List<Arrows>();
        private List<Arrows> rightArrowList = new List<Arrows>();
        private List<Arrows> upArrowList = new List<Arrows>();
        private List<Arrows> downArrowList = new List<Arrows>();
        private int leftArrowPos = 628;
        private int downArrowPos = 728;
        private int upArrowPos = 828;
        private int rightArrowPos = 928;
        private float arrowsYPos = 20;
        private float arrowsHeight = 76;
        private int givenPoints = 10;

        public Collider()
        {
            arrowList = GameManager.Instance.LevelController.ArrowList;
            GetArrows();
        }

        public void GetLeftCollition()
        {
            for (int i = 0; i < leftArrowList.Count; i++)
            {
                float distanceY = Math.Abs(arrowsYPos + (arrowsHeight / 2) - leftArrowList[i].Transform.Pos.y + (leftArrowList[i].Transform.Scale.y / 2));
                float sumHalfHeights = arrowsHeight / 2 + leftArrowList[i].Transform.Scale.y / 2;
                if (distanceY <= sumHalfHeights)
                {
                    GameManager.Instance.Points.RythmPoints = givenPoints;
                    break;
                }
            }
        }

        public void GetUpCollition()
        {
            for (int i = 0; i < upArrowList.Count; i++)
            {
                float distanceY = Math.Abs(arrowsYPos + (arrowsHeight / 2) - upArrowList[i].Transform.Pos.y + (upArrowList[i].Transform.Scale.y / 2));
                float sumHalfHeights = arrowsHeight / 2 + upArrowList[i].Transform.Scale.y / 2;
                if (distanceY <= sumHalfHeights)
                {
                    GameManager.Instance.Points.RythmPoints = givenPoints;
                    break;
                }
            }
        }

        public void GetDownCollition()
        {
            for (int i = 0; i < downArrowList.Count; i++)
            {
                float distanceY = Math.Abs(arrowsYPos + (arrowsHeight / 2) - downArrowList[i].Transform.Pos.y + (downArrowList[i].Transform.Scale.y / 2));
                float sumHalfHeights = arrowsHeight / 2 + downArrowList[i].Transform.Scale.y / 2;
                if (distanceY <= sumHalfHeights)
                {
                    GameManager.Instance.Points.RythmPoints = givenPoints;
                    break;
                }
            }
        }

        public void GetRightCollition()
        {
            for (int i = 0; i < rightArrowList.Count; i++)
            {
                float distanceY = Math.Abs(arrowsYPos + (arrowsHeight / 2) - rightArrowList[i].Transform.Pos.y + (rightArrowList[i].Transform.Scale.y / 2));
                float sumHalfHeights = arrowsHeight / 2 + rightArrowList[i].Transform.Scale.y / 2;
                if (distanceY <= sumHalfHeights)
                {
                    GameManager.Instance.Points.RythmPoints = givenPoints;
                    break;
                }
            }
        }

        private void GetArrows()
        {
            for (int i = 0; i < arrowList.Count; i++)
            {
                if (arrowList[i].Transform.Pos.y != arrowsYPos && arrowList[i].Transform.Pos.x == rightArrowPos)
                {
                    rightArrowList.Add(arrowList[i]);
                }

                if (arrowList[i].Transform.Pos.y != arrowsYPos && arrowList[i].Transform.Pos.x == leftArrowPos)
                {
                    leftArrowList.Add(arrowList[i]);
                }

                if (arrowList[i].Transform.Pos.y != arrowsYPos && arrowList[i].Transform.Pos.x == downArrowPos)
                {
                    downArrowList.Add(arrowList[i]);
                }

                if (arrowList[i].Transform.Pos.y != arrowsYPos && arrowList[i].Transform.Pos.x == upArrowPos)
                {
                    upArrowList.Add(arrowList[i]);
                }
            }
        }
    }
}