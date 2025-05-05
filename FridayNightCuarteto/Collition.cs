using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Collition
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

        private Points points;

        public Collition()
        {
            arrowList = Program.ArrowsList;
            GetArrows();
            points = new Points();
        }

        private void GetArrows()
        {
            for (int i = 0; i < arrowList.Count; i++)
            {
                if (arrowList[i].Transform.Posicion.y != arrowsYPos && arrowList[i].Transform.Posicion.x == rightArrowPos)
                {
                    rightArrowList.Add(arrowList[i]);
                }

                if (arrowList[i].Transform.Posicion.y != arrowsYPos && arrowList[i].Transform.Posicion.x == leftArrowPos)
                {
                    leftArrowList.Add(arrowList[i]);
                }

                if (arrowList[i].Transform.Posicion.y != arrowsYPos && arrowList[i].Transform.Posicion.x == downArrowPos)
                {
                    downArrowList.Add(arrowList[i]);
                }

                if (arrowList[i].Transform.Posicion.y != arrowsYPos && arrowList[i].Transform.Posicion.x == upArrowPos)
                {
                    upArrowList.Add(arrowList[i]);
                }
            }
        }

        public void GetLeftCollition()
        {
            for (int i = 0; i < leftArrowList.Count; i++)
            {
                float distanceY = Math.Abs(arrowsYPos + (arrowsHeight / 2) - leftArrowList[i].Transform.Posicion.y + (leftArrowList[i].Size.Posicion.y / 2));
                float sumHalfHeights = arrowsHeight / 2 + leftArrowList[i].Size.Posicion.y / 2;
                if (distanceY >= sumHalfHeights)
                {
                    points.RythmPoints = givenPoints;
                    break;
                }
            }
        }

        public void GetUpCollition()
        {
            for (int i = 0; i < upArrowList.Count; i++)
            {
                float distanceY = Math.Abs(arrowsYPos + (arrowsHeight / 2) - upArrowList[i].Transform.Posicion.y + (upArrowList[i].Size.Posicion.y / 2));
                float sumHalfHeights = arrowsHeight / 2 + upArrowList[i].Size.Posicion.y / 2;
                if (distanceY >= sumHalfHeights)
                {
                    points.RythmPoints = givenPoints;
                    break;
                }
            }
        }

        public void GetDownCollition()
        {
            for (int i = 0; i < downArrowList.Count; i++)
            {
                float distanceY = Math.Abs(arrowsYPos + (arrowsHeight / 2) - downArrowList[i].Transform.Posicion.y + (downArrowList[i].Size.Posicion.y / 2));
                float sumHalfHeights = arrowsHeight / 2 + downArrowList[i].Size.Posicion.y / 2;
                if (distanceY >= sumHalfHeights)
                {
                    points.RythmPoints = givenPoints;
                    break;
                }
            }
        }

        public void GetRightCollition()
        {
            for (int i = 0; i < rightArrowList.Count; i++)
            {
                float distanceY = Math.Abs(arrowsYPos + (arrowsHeight / 2) - rightArrowList[i].Transform.Posicion.y + (rightArrowList[i].Size.Posicion.y / 2));
                float sumHalfHeights = arrowsHeight / 2 + rightArrowList[i].Size.Posicion.y / 2;
                if (distanceY >= sumHalfHeights)
                {
                    points.RythmPoints = givenPoints;
                    break;
                }
            }
        }
    }
}