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
        private ArrowsFactory arrowsFactory = new ArrowsFactory();
        private HUD hud = new HUD();

        public List<Arrows> ArrowList => arrowList;
        public Stopwatch Stopwatch => stopwatch;
        public Player Player1 => player1;

        public void InitializeLevel()
        {
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.rightArrowS, 0f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.upArrowS, 0f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.downArrowS, 0f));
            arrowList.Add(ArrowsFactory.CreateArrows(ArrowType.leftArrowS, 0f));
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 18.94f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 19.46f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 19.95f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 20.34f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 20.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 20.91f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 21.31f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 21.60f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 21.94f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 22.19f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 22.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 22.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 23.19f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 23.43f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 23.85f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 24.16f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 24.53f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 24.91f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 25.29f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 25.68f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 25.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 26.33f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 26.58f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 26.93f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 27.22f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 27.50f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 27.90f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 28.09f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 28.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 28.87f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 29.23f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 29.47f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 29.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 30.00f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 30.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 30.68f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 30.93f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 31.37f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 31.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 31.93f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 32.27f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 32.56f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 32.86f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 33.10f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 33.52f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 33.91f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 34.16f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 34.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 34.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 34.99f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 35.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 35.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 36.09f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 36.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 36.76f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 37.12f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 37.44f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 37.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 38.06f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 38.30f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 38.77f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 39.12f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 39.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 39.69f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 39.99f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 40.27f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 40.57f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 40.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 41.09f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 41.39f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 41.71f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 41.96f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 42.33f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 42.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 42.91f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 43.20f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 43.54f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 43.89f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 46.76f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 48.94f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 49.19f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 49.42f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 49.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 49.92f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 50.29f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 50.52f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 50.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 51.01f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 51.42f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 51.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 51.89f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 52.10f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 52.35f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 52.61f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 52.96f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 53.21f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 53.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 53.92f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 54.18f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 54.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 54.64f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 54.92f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 55.20f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 55.44f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 55.68f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 56.00f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 56.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 56.71f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 56.99f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 57.07f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 57.58f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 58.05f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 58.22f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 58.54f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 58.94f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 59.17f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 59.42f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 59.82f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 60.04f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 60.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 60.72f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 61.00f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 61.36f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 61.64f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 61.91f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 62.25f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 62.52f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 62.93f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 63.13f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 63.39f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 63.93f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 64.22f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 64.52f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 64.72f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 65.07f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 65.30f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 65.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 65.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 66.43f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 66.71f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 66.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 67.35f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 67.65f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 68.22f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 68.83f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 69.13f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 69.44f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 69.74f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 70.17f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 70.43f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 70.79f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 71.08f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 71.40f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 71.70f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 71.96f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 72.31f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 72.57f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 72.87f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 73.17f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 73.48f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 73.87f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 76.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 78.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 78.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 79.17f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 79.47f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 79.77f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 79.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 80.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 80.65f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 80.93f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 81.24f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 82.27f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 83.56f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 83.91f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 84.18f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 84.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 84.77f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 85.11f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 85.39f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 85.76f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 86.67f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 86.85f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 87.10f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 87.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 88.08f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 88.56f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 88.73f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 88.97f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 89.40f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 89.68f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 89.94f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 90.36f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 90.65f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 91.00f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 91.23f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 92.12f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 93.55f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 93.87f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 94.19f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 94.48f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 94.79f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 95.03f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 95.33f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 95.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 95.86f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 96.64f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 96.94f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 97.26f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 97.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 98.15f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 98.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 99.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 100.04f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 100.66f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 101.50f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 111.48f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 111.74f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 111.96f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 112.31f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 112.58f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 112.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 113.13f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 113.61f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 113.92f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 114.21f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 114.46f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 114.69f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 114.97f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 115.24f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 115.42f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 115.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 116.33f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 116.59f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 116.90f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 117.25f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 117.49f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 117.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 118.07f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 118.35f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 118.55f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 118.89f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 119.17f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 119.40f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 119.80f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 120.02f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 120.39f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 120.71f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 121.52f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 121.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 122.10f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 122.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 122.67f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 122.97f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 123.20f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 123.60f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 123.94f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 124.18f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 124.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 124.68f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 125.05f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 125.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 125.67f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 126.31f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 126.53f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 126.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 127.05f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 127.44f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 127.69f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 127.95f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 128.14f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 128.50f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 128.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 129.00f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 129.37f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 129.77f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 130.06f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 130.35f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 130.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 131.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 131.79f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 132.50f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 133.13f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 133.70f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 134.32f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 134.96f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 135.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 136.24f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 139.13f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 141.09f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 141.27f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 141.57f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 141.79f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 142.04f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 142.31f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 142.53f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 142.89f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 143.20f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 143.43f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 143.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 143.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 144.65f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 145.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 146.17f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 146.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 146.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 147.04f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 147.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 147.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 147.83f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 148.11f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 149.13f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 149.37f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 149.61f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 149.77f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 150.55f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 151.03f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 151.26f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 151.51f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 151.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 152.10f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 152.37f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 152.64f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 153.00f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 153.22f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 153.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 153.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 154.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 156.06f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 156.27f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 156.64f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 156.95f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 157.22f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 157.59f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 157.97f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 158.19f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 158.50f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 159.22f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 159.51f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 159.85f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 160.19f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 160.65f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 161.28f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 161.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 162.48f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 163.12f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 164.38f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 164.61f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 164.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 165.06f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 165.30f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 165.55f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 165.90f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 166.13f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 166.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 166.61f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 166.87f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 167.06f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 167.32f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 167.56f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 167.94f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 168.21f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 168.44f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 168.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 169.04f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 169.33f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 169.68f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 169.99f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 170.36f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 170.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 171.04f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 171.32f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 171.64f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 171.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 172.16f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 172.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 172.85f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 173.21f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 173.55f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 173.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 174.27f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 174.61f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 174.89f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 175.50f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 175.77f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 176.01f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 176.39f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 176.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 176.87f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 177.24f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 177.56f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 177.78f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 178.08f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 178.55f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 178.90f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 179.12f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 179.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 179.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 179.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 180.24f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 180.51f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 180.77f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 181.06f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 181.42f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 181.65f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 182.04f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 182.41f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 182.64f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 183.02f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 183.23f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 183.56f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 184.25f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 184.52f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 184.85f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 185.07f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 185.34f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 185.62f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 185.97f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 186.43f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 186.73f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 186.97f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 187.36f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 187.55f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 187.85f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 188.16f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 188.40f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 188.74f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 191.85f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 193.53f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 193.76f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 193.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 194.23f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 194.50f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 194.83f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 195.00f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 195.33f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 195.61f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 196.01f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 197.24f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 198.51f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 198.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 199.01f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 199.28f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 199.51f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 199.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 200.13f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 200.48f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 200.74f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 201.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 201.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 202.12f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 202.36f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 203.09f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 203.56f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 203.84f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 204.17f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 204.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 204.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 204.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 205.45f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 205.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 206.01f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 206.24f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 207.15f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 208.59f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 208.81f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 209.08f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 209.34f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 209.66f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 209.91f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 210.15f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 210.49f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 210.76f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 211.10f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 211.66f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 211.96f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 212.24f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 212.61f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 213.16f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 213.75f);
            arrowsFactory.AddArrowToQueue(ArrowType.downArrow, 214.32f);
            arrowsFactory.AddArrowToQueue(ArrowType.upArrow, 214.98f);
            arrowsFactory.AddArrowToQueue(ArrowType.leftArrow, 215.63f);
            arrowsFactory.AddArrowToQueue(ArrowType.rightArrow, 216.35f);

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
                }
                else
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
            arrowsFactory.Update();

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
            hud.Render();

            for (int i = 0; i < arrowList.Count; i++)
            {
                arrowList[i].Render();
            }

            Engine.Show();
        }
    }
}
