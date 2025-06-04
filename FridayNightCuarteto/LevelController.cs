using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class LevelController
    {
        private static Stopwatch stopwatch = new Stopwatch();
        private List<Arrows> arrowList = new List<Arrows>();
        private Image background = Engine.LoadImage("assets/Background.jpg");
        private Player player1;
        private int leftArrowPos = 628;
        private int downArrowPos = 728;
        private int upArrowPos = 828;
        private int rightArrowPos = 928;
        private int arrowsYPos = 20;
        private int endLevelTime = 228;
        private int gamePointsToWin = 3050;
        private int initialPlayerPosition = 300;

        public List<Arrows> ArrowList => arrowList;
        public Stopwatch Stopwatch => stopwatch;
        public Player Player1 => player1;

        //public delegate void OnLevelEnd();
        //public event OnLevelEnd onLevelEnd;



        public void InitializeLevel()
        {
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrowS, 0f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrowS, 0f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrowS, 0f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrowS, 0f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 18.94f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 19.46f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 19.95f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 20.34f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 20.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 20.91f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 21.31f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 21.60f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 21.94f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 22.19f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 22.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 22.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 23.19f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 23.43f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 23.85f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 24.16f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 24.53f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 24.91f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 25.29f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 25.68f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 25.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 26.33f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 26.58f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 26.93f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 27.22f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 27.50f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 27.90f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 28.09f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 28.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 28.87f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 29.23f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 29.47f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 29.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 30.00f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 30.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 30.68f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 30.93f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 31.37f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 31.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 31.93f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 32.27f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 32.56f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 32.86f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 33.10f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 33.52f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 33.91f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 34.16f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 34.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 34.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 34.99f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 35.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 35.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 36.09f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 36.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 36.76f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 37.12f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 37.44f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 37.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 38.06f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 38.30f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 38.77f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 39.12f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 39.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 39.69f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 39.99f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 40.27f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 40.57f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 40.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 41.09f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 41.39f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 41.71f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 41.96f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 42.33f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 42.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 42.91f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 43.20f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 43.54f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 43.89f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 46.76f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 48.94f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 49.19f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 49.42f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 49.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 49.92f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 50.29f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 50.52f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 50.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 51.01f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 51.42f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 51.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 51.89f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 52.10f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 52.35f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 52.61f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 52.96f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 53.21f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 53.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 53.92f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 54.18f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 54.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 54.64f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 54.92f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 55.20f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 55.44f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 55.68f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 56.00f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 56.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 56.71f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 56.99f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 57.07f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 57.58f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 58.05f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 58.22f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 58.54f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 58.94f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 59.17f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 59.42f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 59.82f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 60.04f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 60.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 60.72f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 61.00f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 61.36f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 61.64f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 61.91f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 62.25f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 62.52f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 62.93f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 63.13f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 63.39f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 63.93f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 64.22f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 64.52f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 64.72f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 65.07f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 65.30f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 65.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 65.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 66.43f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 66.71f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 66.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 67.35f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 67.65f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 68.22f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 68.83f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 69.13f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 69.44f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 69.74f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 70.17f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 70.43f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 70.79f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 71.08f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 71.40f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 71.70f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 71.96f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 72.31f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 72.57f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 72.87f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 73.17f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 73.48f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 73.87f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 76.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 78.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 78.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 79.17f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 79.47f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 79.77f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 79.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 80.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 80.65f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 80.93f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 81.24f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 82.27f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 83.56f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 83.91f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 84.18f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 84.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 84.77f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 85.11f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 85.39f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 85.76f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 86.67f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 86.85f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 87.10f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 87.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 88.08f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 88.56f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 88.73f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 88.97f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 89.40f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 89.68f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 89.94f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 90.36f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 90.65f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 91.00f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 91.23f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 92.12f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 93.55f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 93.87f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 94.19f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 94.48f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 94.79f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 95.03f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 95.33f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 95.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 95.86f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 96.64f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 96.94f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 97.26f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 97.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 98.15f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 98.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 99.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 100.04f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 100.66f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 101.50f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 111.48f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 111.74f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 111.96f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 112.31f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 112.58f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 112.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 113.13f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 113.61f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 113.92f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 114.21f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 114.46f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 114.69f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 114.97f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 115.24f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 115.42f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 115.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 116.33f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 116.59f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 116.90f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 117.25f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 117.49f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 117.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 118.07f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 118.35f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 118.55f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 118.89f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 119.17f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 119.40f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 119.80f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 120.02f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 120.39f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 120.71f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 121.52f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 121.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 122.10f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 122.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 122.67f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 122.97f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 123.20f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 123.60f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 123.94f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 124.18f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 124.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 124.68f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 125.05f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 125.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 125.67f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 126.31f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 126.53f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 126.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 127.05f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 127.44f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 127.69f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 127.95f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 128.14f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 128.50f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 128.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 129.00f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 129.37f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 129.77f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 130.06f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 130.35f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 130.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 131.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 131.79f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 132.50f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 133.13f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 133.70f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 134.32f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 134.96f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 135.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 136.24f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 139.13f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 141.09f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 141.27f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 141.57f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 141.79f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 142.04f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 142.31f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 142.53f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 142.89f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 143.20f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 143.43f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 143.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 143.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 144.65f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 145.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 146.17f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 146.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 146.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 147.04f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 147.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 147.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 147.83f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 148.11f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 149.13f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 149.37f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 149.61f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 149.77f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 150.55f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 151.03f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 151.26f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 151.51f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 151.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 152.10f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 152.37f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 152.64f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 153.00f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 153.22f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 153.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 153.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 154.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 156.06f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 156.27f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 156.64f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 156.95f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 157.22f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 157.59f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 157.97f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 158.19f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 158.50f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 159.22f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 159.51f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 159.85f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 160.19f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 160.65f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 161.28f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 161.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 162.48f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 163.12f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 164.38f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 164.61f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 164.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 165.06f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 165.30f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 165.55f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 165.90f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 166.13f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 166.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 166.61f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 166.87f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 167.06f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 167.32f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 167.56f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 167.94f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 168.21f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 168.44f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 168.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 169.04f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 169.33f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 169.68f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 169.99f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 170.36f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 170.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 171.04f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 171.32f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 171.64f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 171.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 172.16f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 172.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 172.85f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 173.21f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 173.55f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 173.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 174.27f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 174.61f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 174.89f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 175.50f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 175.77f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 176.01f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 176.39f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 176.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 176.87f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 177.24f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 177.56f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 177.78f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 178.08f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 178.55f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 178.90f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 179.12f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 179.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 179.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 179.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 180.24f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 180.51f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 180.77f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 181.06f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 181.42f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 181.65f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 182.04f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 182.41f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 182.64f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 183.02f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 183.23f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 183.56f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 184.25f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 184.52f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 184.85f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 185.07f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 185.34f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 185.62f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 185.97f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 186.43f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 186.73f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 186.97f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 187.36f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 187.55f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 187.85f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 188.16f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 188.40f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 188.74f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 191.85f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 193.53f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 193.76f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 193.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 194.23f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 194.50f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 194.83f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 195.00f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 195.33f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 195.61f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 196.01f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 197.24f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 198.51f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 198.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 199.01f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 199.28f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 199.51f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 199.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 200.13f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 200.48f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 200.74f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 201.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 201.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 202.12f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 202.36f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 203.09f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 203.56f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 203.84f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 204.17f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 204.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 204.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 204.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 205.45f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 205.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 206.01f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 206.24f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 207.15f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 208.59f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 208.81f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 209.08f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 209.34f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 209.66f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 209.91f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 210.15f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 210.49f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 210.76f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 211.10f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 211.66f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 211.96f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 212.24f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 212.61f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 213.16f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 213.75f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrow, 214.32f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrow, 214.98f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrow, 215.63f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrow, 216.35f));

            player1 = new Player(initialPlayerPosition, initialPlayerPosition);
            stopwatch.Start();
        }

        public void EndLevel()
        {
            if (stopwatch.Elapsed.TotalSeconds >= endLevelTime)
            {
                stopwatch.Restart();
                InitializeLevel();

                if (GameManager.Instance.Points.RythmPoints >= gamePointsToWin)
                {
                    GameManager.Instance.Points.RythmPoints = -GameManager.Instance.Points.RythmPoints;
                    GameManager.Instance.ChangeStage(GameStage.win);
                }else
                {
                    GameManager.Instance.Points.RythmPoints = -GameManager.Instance.Points.RythmPoints;
                    GameManager.Instance.ChangeStage(GameStage.lose);
                }
            }
        }

        public enum ArrowDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        public void TriggerArrowAnimation(ArrowDirection direction)
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

            foreach (var arrow in arrowList)
            {
                if (arrow.IsStatic() && Math.Abs(arrow.PositionX - targetX) < 1f)
                {
                    arrow.PlayAnimation();
                }
            }
        }

          



        public void Update()
        {
            player1.Update();

            for (int i = 0; i < arrowList.Count; i++)
            {
                arrowList[i].Update();
            }

            EndLevel();
        }
        public void Render()
        {
            Engine.Clear();
            Engine.Draw(background, 0, 0);
            player1.Render();

            for (int i = 0; i < arrowList.Count; i++)
            {
                arrowList[i].Render();
            }

            Engine.Show();

            
            
        }
    }
}
