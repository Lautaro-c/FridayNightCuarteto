using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace MyGame
{
    public enum ArrowType { leftArrow, rightArrow, upArrow, downArrow, leftArrowS, rightArrowS, upArrowS, downArrowS }
    public class ArrowsFactory
    {
        private const float leftArrowPos = 628;
        private const float downArrowPos = 728;
        private const float upArrowPos = 828;
        private const float rightArrowPos = 928;
        private const float arrowsYPos = 768;
        private const float staticArrowsYPos = 20;
        public static Arrows CreateArrows(ArrowType arrowType, float time)
        {
            switch (arrowType)
            {
                case ArrowType.leftArrow:
                    return new Arrows(leftArrowPos, arrowsYPos, false, time);
                    break;
                case ArrowType.rightArrow:
                    return new Arrows(rightArrowPos, arrowsYPos, false, time);
                    break;
                case ArrowType.upArrow:
                    return new Arrows(upArrowPos, arrowsYPos, false, time);
                    break;
                case ArrowType.downArrow:
                    return new Arrows(downArrowPos, arrowsYPos, false, time);
                    break;
                case ArrowType.leftArrowS:
                    return new Arrows(leftArrowPos, staticArrowsYPos, true, time);
                    break;
                case ArrowType.rightArrowS:
                    return new Arrows(rightArrowPos, staticArrowsYPos, true, time);
                    break;
                case ArrowType.upArrowS:
                    return new Arrows(upArrowPos, staticArrowsYPos, true, time);
                    break;
                case ArrowType.downArrowS:
                    return new Arrows(downArrowPos, staticArrowsYPos, true, time);
                    break;
            }
            return null;
        }
    }
}