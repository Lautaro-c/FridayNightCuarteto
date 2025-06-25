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
        menu, game, win, lose, nextLevel
    }
    public class GameManager
    {
        static private GameManager instance;
        private GameStage gameStage = GameStage.menu;
        private Image mainMenuScreen = Engine.LoadImage("assets/MainMenu.png");
        private Image winScreen = Engine.LoadImage("assets/Win.png");
        private Image loseScreen = Engine.LoadImage("assets/Lose.png");
        private Image nextLevelScreen = Engine.LoadImage("assets/NextLevel.png");
        private LevelController levelController;
        private Points points;
        private bool songStarted = false;
        private int level = 1;
        public LevelController LevelController => levelController;
        public Points Points => points;
        

        private SongManager SongManager; 
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
            //levelController.InitializeLevel(1);
            SongManager = new SongManager();
        }

        public void Update()
        {
            switch (gameStage)
            {
                case GameStage.menu:
                    if (Engine.GetKey(Engine.KEY_ESP))
                    {
                        level = 1;
                        levelController.InitializeLevel(level);
                        ChangeStage(GameStage.game);
                    }
                    break;
                case GameStage.game:
                    if (!songStarted)
                    {
                        SongManager.startSong(level);
                        songStarted = true;
                    }
                    levelController.Update();
                    break;
                case GameStage.win:
                    SongManager.stopSong(level);
                    if (Engine.GetKey(Engine.KEY_M))
                    {
                        ChangeStage(GameStage.menu);
                        songStarted = false;
                    }
                    break;
                case GameStage.nextLevel:
                    SongManager.stopSong(level);
                    if (Engine.GetKey(Engine.KEY_ESP))
                    {
                        level = 2;
                        ChangeStage(GameStage.game);
                        levelController.InitializeLevel(level);
                        songStarted = false;
                    }
                    if (Engine.GetKey(Engine.KEY_M))
                    {
                        ChangeStage(GameStage.menu);
                        songStarted = false;
                    }
                    break;
                case GameStage.lose:
                    SongManager.stopSong(level);
                    if (Engine.GetKey(Engine.KEY_M))
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
                case GameStage.nextLevel:
                    Engine.Clear();
                    Engine.Draw(nextLevelScreen, 0, 0);
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
