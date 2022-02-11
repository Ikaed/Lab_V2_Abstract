using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace Lab_V2
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            List<string> listHeader = new List<string>();
            List<string> listShape = new List<string>();
            List<string> listX = new List<string>();
            List<string> listY = new List<string>();
            List<string> listLength = new List<string>();
            List<string> listPoints = new List<string>();

            int inputShapeTypeCircle = 0;
            int inputShapeTypeSquare = 0;
            

            var stringInput = "SHAPE,X,Y,LENGTH,POINTS; CIRCLE,3,1,13,100; CIRCLE,1,-1,15,200; SQUARE , -1 ,0 ,20 ,300; SQUARE , -3 ,2 ,8 ,400";
            string trimmed = String.Concat(stringInput.Where(c => !Char.IsWhiteSpace(c)));
    
            //Header
            int startIndexHeader = 0;
            int lengthIndexHeader = 23;
            String substringHeader = trimmed.Substring(startIndexHeader, lengthIndexHeader);
            //Console.WriteLine(substring);
            listHeader = substringHeader.Split(',').ToList();

        
            //var trimInput = stringInput.Trim();
            //listSemiColon = trimmed.Split(';').ToList();

            //Variabler
            var startIndexVar = 24;
            var lengthIndexVar = 73;
            String substringVariables = trimmed.Substring(startIndexVar, lengthIndexVar);

            var listVariables = Regex.Split(substringVariables, @",|;");

            //foreach (var varh in listHeader)
            //{
            //    Console.WriteLine(varh);
            //}
            //Vi använder listheader för att särskilja cirkel och fyrkant
            listShape.Add(listHeader[0]);
            listShape.Add(listVariables[0]);
            listShape.Add(listVariables[5]);
            listShape.Add(listVariables[10]);
            listShape.Add(listVariables[15]);
            foreach (var l in listShape)
            {
                Console.WriteLine(l);
            }

       //forloop här?

            if (listShape.Contains("Circle"))
            {
                Console.WriteLine("test");
                 inputShapeTypeCircle = 2;
                 Console.WriteLine(inputShapeTypeCircle);

            }
            else
            {
                inputShapeTypeSquare = 1;
                Console.WriteLine(inputShapeTypeSquare);
            }

         

            listX.Add(listHeader[1]);
            listX.Add(listVariables[1]);
            listX.Add(listVariables[6]);
            listX.Add(listVariables[11]);
            listX.Add(listVariables[16]);

            foreach (var xlist in listX)
            {
                Console.WriteLine(xlist);
            }

            listY.Add(listHeader[2]);
            listY.Add(listVariables[2]);
            listY.Add(listVariables[7]);
            listY.Add(listVariables[12]);
            listY.Add(listVariables[17]);

            foreach (var ylist in listY)
            {
                Console.WriteLine(ylist);
            }

            listLength.Add(listHeader[3]);
            listLength.Add(listVariables[3]);
            listLength.Add(listVariables[8]);
            listLength.Add(listVariables[13]);
            listLength.Add(listVariables[18]);

            foreach (var llist in listLength)
            {
                Console.WriteLine(llist);
            }

            listPoints.Add(listHeader[4]);
            listPoints.Add(listVariables[4]);
            listPoints.Add(listVariables[9]);
            listPoints.Add(listVariables[14]);
            listPoints.Add(listVariables[19]);

            foreach (var plist in listPoints)
            {
                Console.WriteLine(plist);
            }

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
            //var inputShapeTypeCircle = Convert.ToInt32(Console.ReadLine());


          
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
                var eqCircleH = inputShapeTypeCircle * instancePointsCircle / AreaCircle;
                shapeScoreh.Add(eqCircleH);
            }
            else
            {
                Console.WriteLine("Utanför cirkel");
                var eqCircleM = inputShapeTypeCircle * instancePointsCircle / AreaCircle;
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
            //var inputShapeTypeSquare = Convert.ToInt32(Console.ReadLine());

            // given point
            int SquareX = 1, SquareY = 5;

            var x1 = botX - inputLengthSquare / 2;
            var y1 = botY - inputLengthSquare / 2;
            var x2 = topX + inputLengthSquare / 2;
            var y2 = topY + inputLengthSquare / 2;

          
            var instancePointsSquare = inputPointsSquare;
            var AreaSquare = 10;

            // function call
            if (square.HitSquare(x1, y1, x2, y2, SquareX, SquareY))
            {
                Console.Write("Inuti fyrkant");
                var eqSquareH = inputShapeTypeSquare * instancePointsSquare / AreaSquare;
                shapeScoreh.Add(eqSquareH);
            }
            else
            {
                Console.Write("Utanför fyrkant");
                var eqSquareM = inputShapeTypeSquare * instancePointsSquare / AreaSquare;
                shapeScoreh.Add(eqSquareM);
            }

            Console.WriteLine(string.Join(", ", shapeScoreh));
            Console.WriteLine(string.Join(", ", shapeScorem));
  
        }
    }
}