using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using Tao.Sdl;



namespace MyGame
{

    class Program
    {
        //static private List<Enemy> enemyList = new List<Enemy>();
        static private List<Arrows> arrowList = new List<Arrows>();
        static private Image fondo = Engine.LoadImage("assets/fondo.png");
        static private Player player1;
        static private int nivel;
        static private int leftArrowPos = 628;
        static private int downArrowPos = 728;
        static private int upArrowPos = 828;
        static private int rightArrowPos = 928;
        static private int arrowsYPos = 20; 

        static void Main(string[] args)
        {
            Engine.Initialize();
            InitializeLevel();

            while (true)
            {
                Update();
                Render();
            }

        }

        static public void InitializeLevel()
        {
            player1 = new Player(0, 0);
            arrowList.Add(new Arrows(rightArrowPos, arrowsYPos, false));
            arrowList.Add(new Arrows(upArrowPos, arrowsYPos, false));
            arrowList.Add(new Arrows(downArrowPos, arrowsYPos, false));
            arrowList.Add(new Arrows(leftArrowPos, arrowsYPos, false));
            arrowList.Add(new Arrows(leftArrowPos, 768, true));
        }

        static void Update()
        {
            
            player1.Update();
          
            for (int i = 0; i < arrowList.Count; i++)
            {
                arrowList[i].Update();
            }

        }
        static void Render()
        {
            Engine.Clear();
            Engine.Draw(fondo, 0, 0);
            player1.Render();

            for (int i = 0; i < arrowList.Count; i++)
            {
                arrowList[i].Render();
            }

            Engine.Show();
        }
    }
}