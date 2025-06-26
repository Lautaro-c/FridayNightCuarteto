using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class ArrowsCreator
    {
        private const float leftArrowPos = 628;
        private const float downArrowPos = 728;
        private const float upArrowPos = 828;
        private const float rightArrowPos = 928;
        private const float staticArrowsYPos = 20;
        public static Arrows CreateArrows(ArrowType arrowType, float time)
        {
            switch (arrowType)
            {
                case ArrowType.leftArrowS:
                    return new Arrows(leftArrowPos, staticArrowsYPos, true);
                case ArrowType.rightArrowS:
                    return new Arrows(rightArrowPos, staticArrowsYPos, true);
                case ArrowType.upArrowS:
                    return new Arrows(upArrowPos, staticArrowsYPos, true);
                case ArrowType.downArrowS:
                    return new Arrows(downArrowPos, staticArrowsYPos, true);
            }
            return null;
        }
    }
}
