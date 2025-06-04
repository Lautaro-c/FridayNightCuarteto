using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public interface IAnimatable
    {
        void CreateAnimation();         
        void UpdateAnimation();
        Image GetCurrentFrame();
    }
}
