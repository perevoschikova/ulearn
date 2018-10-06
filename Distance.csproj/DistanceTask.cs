using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
	    public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
	    {
	        //if (ax == bx && ay == by)
	        //{
	        //    return Math.Sqrt((ax - x)*(ax - x) + (ay - y)*(ay - y));
	        //}

	        //      var t = ((x - ax)*(bx - ax) + (y - ay)*(by - ay)) / ((bx - ax)*(bx - ax) + (by - ay)*(by - ay));

	        //if (t > 1)
	        //{
	        //    t = 1;
	        //}

	        //if (t < 0)
	        //{
	        //    t = 0;
	        //}

	        //var k = (ax - x + (bx - ax) * t) * (ax - x + (bx - ax) * t) +
	        //        (ay - y + (by - ay) * t) * (ay - y + (by - ay) * t);

	        //      return Math.Sqrt(k);

	        var h = ((ax - x) * (by - y) - (bx - x) * (ay - y)) 
	                / Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));

	        var xa = Math.Sqrt((ax - x) * (ax - x) + (ay - y) * (ay - y));
	        var xb = Math.Sqrt((bx - x) * (bx - x) + (by - y) * (by - y));

	        var l = Math.Min(xa, xb);

	        return Math.Min(h, l);
	    }
	}
}