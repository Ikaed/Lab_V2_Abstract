using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Lab_V2
{
    public class Square
    {

        //public void getList(List<string> listShape)
        //{
        //    var points = listShape;
            
            
        //}

      


            //: Shape
            
                public bool HitSquare(int x1, int y1, int x2,
            int y2, int SquareX, int SquareY)
        {
            if (SquareX > x1 && SquareX < x2 &&
                SquareY > y1 && SquareY < y2)
                return true;
            else
                return false;
        }
        //public override void Draw(int shapeType, int x, int y, int instancePoints, int length)
        //{
        //    //Console.WriteLine("test3");


        //}
    }
}