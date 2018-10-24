using System;
using NUnit.Framework;

namespace DistanceTask
{
    public static class DistanceTask
    {
        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            var ak = Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay));
            var kb = Math.Sqrt((x - bx) * (x - bx) + (y - by) * (y - by));
            var ab = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));

            //скалярное произведение векторов
            var mulScalarAKAB = (x - ax) * (bx - ax) + (y - ay) * (by - ay);
            var mulScalarBKAB = (x - bx) * (-bx + ax) + (y - by) * (-by + ay);

            if (ab == 0)
            {
                return ak;
            }

            if (mulScalarAKAB >= 0 && mulScalarBKAB >= 0)
            {
                var p = (ak + kb + ab) / 2.0;
                var s = Math.Sqrt(Math.Abs((p * (p - ak) * (p - kb) * (p - ab))));

                return (2.0 * s) / ab;
            }

            if (mulScalarAKAB < 0 || mulScalarBKAB < 0)
            {
                return Math.Min(ak, kb);
            }

            return 0;
        }
    }
}