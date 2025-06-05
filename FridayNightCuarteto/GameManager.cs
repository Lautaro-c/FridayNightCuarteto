using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public enum GameStage
    {
        menu, game, win, lose
    }
    public class GameManager
    {
        static private GameManager instance;
        private GameStage gameStage = GameStage.menu;
        private Image mainMenuScreen = Engine.LoadImage("assets/MainMenu.png");
        private Image winScreen = Engine.LoadImage("assets/Win.png");
        private Image loseScreen = Engine.LoadImage("assets/Lose.png");
        private LevelController levelController;
        private Points points;
        private bool songStarted = false;
        public LevelController LevelController => levelController;
        public Points Points => points;
        

        public SongManager SongManager; 
        static public GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }

                return instance;
            }
        }

        public void Initialize()
        {
            levelController = new LevelController();
            points = new Points();
            levelController.InitializeLevel();
            SongManager = new SongManager();
        }

        public void Update()
        {
            switch (gameStage)
            {
                case GameStage.menu:
                    if (Engine.GetKey(Engine.KEY_ESP))
                    {
                        ChangeStage(GameStage.game);
                    }
                    break;
                case GameStage.game:
                    if (!songStarted)
                    {
                        SongManager.startSong();
                        songStarted = true;
                    }
                    levelController.Update();
                    break;
                case GameStage.win:
                    if (Engine.GetKey(Engine.KEY_ESC))
                    {
                        ChangeStage(GameStage.menu);
                        songStarted = false;
                    }
                    break;
                case GameStage.lose:
                    if (Engine.GetKey(Engine.KEY_ESC))
                    {
                        ChangeStage(GameStage.menu);
                        songStarted = false;
                    }
                    break;
            }
        }

        public void Render()
        {
            switch (gameStage)
            {
                case GameStage.menu:
                    Engine.Clear();
                    Engine.Draw(mainMenuScreen, 0, 0);
                    Engine.Show();
                    break;
                case GameStage.game:
                    levelController.Render();
                    break;
                case GameStage.win:
                    Engine.Clear();
                    Engine.Draw(winScreen, 0, 0);
                    Engine.Show();
                    break;
                case GameStage.lose:
                    Engine.Clear();
                    Engine.Draw(loseScreen, 0, 0);
                    Engine.Show();
                    break;
            }
        }
        public void ChangeStage(GameStage stage)
        {
            gameStage = stage;
        }

    }
}
