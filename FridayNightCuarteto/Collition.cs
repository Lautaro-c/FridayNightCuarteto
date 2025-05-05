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
        private int arrowsYPos = 20;
        private int givenPoints = 10;

        private Points points;

        public Collition()
        {
            arrowList = Program.ArrowsList;
            GetStaticArrows();
            points = new Points();
        }

        private void GetStaticArrows()
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
                if (leftArrowList[i].Transform.Posicion.y <= (30 + 76) && leftArrowList[i].Transform.Posicion.y >= -76)
                {
                    points.RythmPoints = givenPoints;
                }
            }
        }

        public void GetUpCollition()
        {
            for (int i = 0; i < upArrowList.Count; i++)
            {
                if (upArrowList[i].Transform.Posicion.y <= (30 + 76) && upArrowList[i].Transform.Posicion.y >= -76)
                {
                    points.RythmPoints = givenPoints;
                }
            }
        }

        public void GetDownCollition()
        {
            for (int i = 0; i < downArrowList.Count; i++)
            {
                if (downArrowList[i].Transform.Posicion.y <= (30 + 76) && downArrowList[i].Transform.Posicion.y >= -76)
                {
                    points.RythmPoints = givenPoints;
                }
            }
        }

        public void GetRightCollition()
        {
            for (int i = 0; i < rightArrowList.Count; i++)
            {
                if (rightArrowList[i].Transform.Posicion.y <= (30 + 76) && rightArrowList[i].Transform.Posicion.y >= -76)
                {
                    points.RythmPoints = givenPoints;
                }
            }
        }
    }
}