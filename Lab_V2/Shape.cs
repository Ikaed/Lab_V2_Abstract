using System;
using System.Runtime.CompilerServices;

namespace Lab_V2
{
    public abstract class Shape
    {
        
        //public int Width { get; set; }
        //public int Height { get; set; }
        //x, y, length, shapetype, instancepoints, 
        public abstract void Draw(int shapeType, int x, int y, int instancePoints, int length);


        

        //public void test1()
        //{
        //    Console.WriteLine("test1");
        //}

        //public void test2()
        //{
        //    Console.WriteLine("test2");
        //}
    }

}