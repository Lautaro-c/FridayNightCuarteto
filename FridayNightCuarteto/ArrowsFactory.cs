using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace MyGame
{
    public enum ArrowType { leftArrow, rightArrow, upArrow, downArrow, leftArrowS, rightArrowS, upArrowS, downArrowS }
    public class ArrowsFactory
    {
        private const float leftArrowPos = 628;
        private const float downArrowPos = 728;
        private const float upArrowPos = 828;
        private const float rightArrowPos = 928;
        private const float arrowsYPos = 768;
        private const float staticArrowsYPos = 20;

        ArrowsPool arrowPool = new ArrowsPool();
        private List<(ArrowType arrowType, float spawnTime)> arrowQueue = new List<(ArrowType, float)>();

        public void Update()
        {
            CheckAndSpawnArrows();
        }

        public void AddArrowToQueue(ArrowType arrowType, float time)
        {
            arrowQueue.Add((arrowType, time));
        }

        public void CheckAndSpawnArrows()
        {
            for (int i = 0; i < arrowQueue.Count; i++)
            {
                if (GameManager.Instance.LevelController.Stopwatch.Elapsed.TotalSeconds >= arrowQueue[i].spawnTime)
                {
                    SpawnArrows(arrowQueue[i].arrowType);
                    arrowQueue.RemoveAt(i);
                }
            }
        }


        public void SpawnArrows(ArrowType arrowType)
        {
            switch (arrowType)
            {
                case ArrowType.leftArrow:
                    Arrows arrow = arrowPool.GetArrow(leftArrowPos, arrowsYPos, false);
                    GameManager.Instance.LevelController.ArrowList.Add(arrow);
                    break;
                case ArrowType.rightArrow:
                    Arrows arrow2 = arrowPool.GetArrow(rightArrowPos, arrowsYPos, false);
                    GameManager.Instance.LevelController.ArrowList.Add(arrow2);
                    break;
                case ArrowType.upArrow:
                    Arrows arrow3 = arrowPool.GetArrow(upArrowPos, arrowsYPos, false);
                    GameManager.Instance.LevelController.ArrowList.Add(arrow3);
                    break;
                case ArrowType.downArrow:
                    Arrows arrow4 = arrowPool.GetArrow(downArrowPos, arrowsYPos, false);
                    GameManager.Instance.LevelController.ArrowList.Add(arrow4);
                    break;

            }
        }

        public static Arrows CreateArrows(ArrowType arrowType, float time)
        {
            switch (arrowType)
            {
                case ArrowType.leftArrowS:
                    return new Arrows(leftArrowPos, staticArrowsYPos, true);
                    break;
                case ArrowType.rightArrowS:
                    return new Arrows(rightArrowPos, staticArrowsYPos, true);
                    break;
                case ArrowType.upArrowS:
                    return new Arrows(upArrowPos, staticArrowsYPos, true);
                    break;
                case ArrowType.downArrowS:
                    return new Arrows(downArrowPos, staticArrowsYPos, true);
                    break;
            }
            return null;
        }

    }
}