using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Arrows
    {

        private Image arrowImage; 
        private ChoseArrowImage choseArrowImage;
        private Transform transform;
        private ArrowMovement arrowMovement;

        private bool canMove = false;
        private bool isStatic = false;
        private float sizeValue = 76;
        private int screenLimit = 152;
        private float spawnTime;
        private Renderer renderer;

        public Transform Transform => transform;
        public Image ArrowImage => arrowImage;

        public Arrows(float positionX, float positionY, bool isStatic, float spawnTime)
        {
            transform = new Transform(positionX, positionY, sizeValue, sizeValue, 0F, 0F);
            arrowMovement = new ArrowMovement(transform);
            this.isStatic = isStatic;
            this.spawnTime = spawnTime;
            choseArrowImage = new ChoseArrowImage(transform, isStatic);
            arrowImage = choseArrowImage.GetImage();
            renderer = new Renderer();
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
            if (transform.Pos.y <= -screenLimit)
            {
                DestroyArrow();
            }
        }

        public void Render()
        {
            renderer.Render(arrowImage, transform);
            //Engine.Draw(arrowImage, transform.Pos.x, transform.Pos.y);
        }

        public void DestroyArrow()
        { 
           GameManager.Instance.LevelController.ArrowList.Remove(this);   
        }
    }
}