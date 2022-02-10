using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab_V2
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            List<string> listSemiColon = new List<string>();
            List<string> listComma = new List<string>();


            var stringInput = "SHAPE,X,Y,LENGTH,POINTS; CIRCLE,3,1,13,100; CIRCLE,1,-1,15,200; SQUARE , -1 ,0 ,20 ,300; SQUARE , -3 ,2 ,8 ,400";
            string trimmed = String.Concat(stringInput.Where(c => !Char.IsWhiteSpace(c)));
            //var trimInput = stringInput.Trim();
            listSemiColon = trimmed.Split(';').ToList();
            trimmed.Split(',')
                .Select(line => line.Split('='))
                .ToList();


            var shapeScoreh = new List<double>();
            var shapeScorem = new List<double>();

            //Shape circle = new Circle();

            var square = new Square();

            var circle = new Circle();

            //Avser cirkel
            Console.WriteLine("Ange en längd");
            var inputLCircle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange poäng för objektet");
            var inputPointsCircle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange att det är en cirkel = 2");
            var inputShapeTypeCircle = Convert.ToInt32(Console.ReadLine());


            var shapeTypeCircle = inputShapeTypeCircle;
            var instancePointsCircle = inputPointsCircle;
            var AreaCircle = 10;
            var x = 51;
            var y = 1;
            var length = inputLCircle;
            var circleX = 0;
            var circleY = 1;
            var rad = (int) (length / (2 * Math.PI));

            var botX = 10;
            var botY = 3;
            var topX = 20;
            var topY = 25;
            var L = 4;


            if (circle.HitCircle(circleX, circleY, rad, x, y))
            {
                Console.WriteLine("Inuti cirkel");
                var eqCircleH = shapeTypeCircle * instancePointsCircle / AreaCircle;
                shapeScoreh.Add(eqCircleH);
            }
            else
            {
                Console.WriteLine("Utanför cirkel");
                var eqCircleM = shapeTypeCircle * instancePointsCircle / AreaCircle;
                shapeScorem.Add(eqCircleM);
            }

            // bottom-left and top-right
            // corners of rectangle
            //int x1 = 0, y1 = 0,
            //    x2 = 10, y2 = 8;

            //Avser fyrkant
            Console.WriteLine("Ange en längd");
            var inputLengthSquare = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange poäng för objektet");
            var inputPointsSquare = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange att det är en fyrkant = 1");
            var inputShapeTypeSquare = Convert.ToInt32(Console.ReadLine());

            // given point
            int SquareX = 1, SquareY = 5;

            var x1 = botX - inputLengthSquare / 2;
            var y1 = botY - inputLengthSquare / 2;
            var x2 = topX + inputLengthSquare / 2;
            var y2 = topY + inputLengthSquare / 2;

            var shapeTypeSquare = inputShapeTypeSquare;
            var instancePointsSquare = inputPointsSquare;
            var AreaSquare = 10;

            // function call
            if (square.HitSquare(x1, y1, x2, y2, SquareX, SquareY))
            {
                Console.Write("Inuti fyrkant");
                var eqSquareH = shapeTypeSquare * instancePointsSquare / AreaSquare;
                shapeScoreh.Add(eqSquareH);
            }
            else
            {
                Console.Write("Utanför fyrkant");
                var eqSquareM = shapeTypeSquare * instancePointsSquare / AreaSquare;
                shapeScoreh.Add(eqSquareM);
            }

            Console.WriteLine(string.Join(", ", shapeScoreh));
            Console.WriteLine(string.Join(", ", shapeScorem));
  
        }
    }
}