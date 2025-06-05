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
        public ArrowsPool()
       : base(typeof(Arrows), 0f, 0f, false)
        {}
        public Arrows GetArrow(float x, float y, bool isStatic)
        {   
            Arrows arrow = GetT();
            arrow.Transform.SetPosition(new Vector2(x, y));
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