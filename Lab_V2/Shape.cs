using System;

namespace Lab_V2
{
    public abstract class Shape
    {
        //public int Width { get; set; }
        //public int Height { get; set; }

        public abstract void Draw();

        public void test1()
        {
            Console.WriteLine("test1");
        }

        public void test2()
        {
            Console.WriteLine("test2");
        }
    }
}