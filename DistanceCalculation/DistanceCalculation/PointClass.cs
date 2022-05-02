using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculation
{
    public class PointClass
    {
        public float _x;
        public float _y;
        public static float PointDistance(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne._x - pointTwo._x;
            float y = pointOne._y - pointTwo._y;
            return MathF.Sqrt((x * x) + (y * y));
        }


    }


}
