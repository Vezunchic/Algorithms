using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceCalculation
{
    public struct PointStruct
    {
        public float _x;
        public float _y;
        public double _q;
        public double _z;
        public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne._x - pointTwo._x;
            float y = pointOne._y - pointTwo._y;
            return MathF.Sqrt((x * x) + (y * y));
        }
       
         public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
            {
                double x = pointOne._q - pointTwo._q;
                double y = pointOne._z - pointTwo._z;
                return Math.Sqrt((x * x) + (y * y));
            }

        public static float PointDistanceShort(PointStruct pointOne, PointStruct
pointTwo)
        {
            float x = pointOne._x - pointTwo._x;
            float y = pointOne._y - pointTwo._y;
            return (x * x) + (y * y);
        }

    }
}
