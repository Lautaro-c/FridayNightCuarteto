using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class ArrowsCollider
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
        private Collider collider;
        private Transform leftArrowTransform;
        private Transform rightArrowTransform;
        private Transform upArrowTransform;
        private Transform downArrowTransform;

        public ArrowsCollider()
        {
            arrowList = GameManager.Instance.LevelController.ArrowList;
            collider = new Collider();
            leftArrowTransform = new Transform(leftArrowPos, arrowsYPos, arrowsHeight, arrowsHeight, 0, 0);
            rightArrowTransform = new Transform(rightArrowPos, arrowsYPos, arrowsHeight, arrowsHeight, 0, 0);
            upArrowTransform = new Transform(upArrowPos, arrowsYPos, arrowsHeight, arrowsHeight, 0, 0);
            downArrowTransform = new Transform(downArrowPos, arrowsYPos, arrowsHeight, arrowsHeight, 0, 0);
            GetArrows();
        }

        public void Update()
        {
            arrowList = GameManager.Instance.LevelController.ArrowList;
            GetArrows();
        }

        public void GetLeftCollition()
        {
            for (int i = 0; i < leftArrowList.Count; i++)
            {
                if (collider.BoxCollider(leftArrowTransform, leftArrowList[i].Transform))
                {
                    GameManager.Instance.Points.RythmPoints = givenPoints;
                    leftArrowList[i].Destroy();
                    break;
                }
            }
        }

        public void GetUpCollition()
        {
            for (int i = 0; i < upArrowList.Count; i++)
            {
                if (collider.BoxCollider(upArrowTransform, upArrowList[i].Transform))
                {
                    GameManager.Instance.Points.RythmPoints = givenPoints;
                    upArrowList[i].Destroy();
                    break;
                }
            }
        }

        public void GetDownCollition()
        {
            for (int i = 0; i < downArrowList.Count; i++)
            {
                if(collider.BoxCollider(downArrowTransform, downArrowList[i].Transform))
                {
                    GameManager.Instance.Points.RythmPoints = givenPoints;
                    downArrowList[i].Destroy();
                    break;
                }
            }
        }

        public void GetRightCollition()
        {
            for (int i = 0; i < rightArrowList.Count; i++)
            {
                if(collider.BoxCollider(rightArrowTransform, rightArrowList[i].Transform))
                {
                    GameManager.Instance.Points.RythmPoints = givenPoints;
                    rightArrowList[i].Destroy();
                    break;
                }
            }
        }

        private void GetArrows()
        {
            rightArrowList.Clear();
            leftArrowList.Clear();
            downArrowList.Clear();
            upArrowList.Clear();

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