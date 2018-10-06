using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            return IsIntersected(r1.Left, r1.Right, r2.Left, r2.Right) 
                   && IsIntersected(r1.Top, r1.Bottom, r2.Top, r2.Bottom);
        }

        // Площадь пересечения прямоугольников
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            if (!AreIntersected(r1, r2)) return 0;
            var x = GetIntersectionLength(r1.Left, r1.Right, r2.Left, r2.Right);
            var y = GetIntersectionLength(r1.Top, r1.Bottom, r2.Top, r2.Bottom);
            return x * y;
        }
        
        // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
        // Иначе вернуть -1
        // Если прямоугольники совпадают, можно вернуть номер любого из них.
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (GetIntersectionLength(r1.Left, r1.Right, r2.Left, r2.Right) == r1.Width
		        && GetIntersectionLength(r1.Top, r1.Bottom, r2.Top, r2.Bottom) == r1.Height)
		    {
		        return 0;
		    }

		    if (GetIntersectionLength(r1.Left, r1.Right, r2.Left, r2.Right) == r2.Width
		        && GetIntersectionLength(r1.Top, r1.Bottom, r2.Top, r2.Bottom) == r2.Height)
		    {
		        return 1;
		    }
		    return -1;
		}

	    private static bool IsIntersected(int x1, int x2, int y1, int y2)
	    {
	        return x1 <= y2 && x2 >= y1;
	    }

	    private static int GetIntersectionLength(int a1, int a2, int b1, int b2)
	    {
	        return (a2 - a1) + (b2 - b1) - (Math.Max(a2, b2) - Math.Min(a1, b1));
	    }
    }
}