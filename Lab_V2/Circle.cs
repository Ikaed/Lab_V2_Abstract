using System;

namespace Lab_V2
{
    public class Circle : Shape
    {
        public bool HitCircle(int circleX, int circleY, int rad, int x, int y)
        {

            if ((x - circleX) * (x - circleX) +
                (y - circleY) * (y - circleY) <= rad * rad)

                return true;

            else
                return false;
        }
        public override void Draw(int shapeType, int x, int y, int instancePoints, int length)
        {
            Console.WriteLine("test4");
        }
    }
}