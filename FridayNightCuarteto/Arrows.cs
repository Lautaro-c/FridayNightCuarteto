using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Arrows
    {

        private Image arrowImage; 
        private ChoseArrowImage choseArrowImage;
        private Transform transform;
        private Transform size; 
        private ArrowMovement arrowMovement;

        private bool canMove = false;
        private bool isStatic = false;

        private float spawnTime;

        public Transform Transform => transform;
        public Transform Size => size;
        public Image ArrowImage => arrowImage;

        public Arrows(float positionX, float positionY, bool isStatic, float spawnTime)
        {
            transform = new Transform(positionX, positionY);
            size = new Transform(76, 76);
            arrowMovement = new ArrowMovement(transform);
            this.isStatic = isStatic;
            this.spawnTime = spawnTime;
            choseArrowImage = new ChoseArrowImage(transform, isStatic);
            arrowImage = choseArrowImage.GetImage();
        }

        public void Update()
        {
            if (GameManager.Instance.LevelController.Stopwatch.Elapsed.TotalSeconds >= spawnTime)
            {
                canMove = true;
            }

            if(canMove && isStatic == false)
            {
                arrowMovement.Update();
            }
            if (transform.Pos.y <= -152)
            {
                DestroyArrow();
            }
        }

        public void Render()
        {
            Engine.Draw(arrowImage, transform.Pos.x, transform.Pos.y);
        }

        public void DestroyArrow()
        { 
           GameManager.Instance.LevelController.ArrowList.Remove(this);   
        }
    }
}