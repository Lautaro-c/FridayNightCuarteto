using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace MyGame
{
    
    public class ArrowsPool : DynamicPool<Arrows>
    {
        private ChoseArrowImage choseArrowImage;
        public ArrowsPool(float defaultSpawnTime)
       : base(typeof(Arrows), 0f, 0f, false, defaultSpawnTime)
        {
        }
        public Arrows GetArrow(float x, float y, bool isStatic, float spawnTime)
        {   
            Arrows arrow = GetT();
            arrow.Transform.SetPosition(new Vector2(x, y));
            arrow.SpawnTime = spawnTime;
            if (!isStatic)
            {
                arrow.IsStaticFalse();
            }else
            {
                arrow.IsStaticTrue();
            }
            arrow.ChooseImage();
            return arrow;
        }


    }
}