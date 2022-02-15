using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Channels;

namespace Lab_V2
{
    internal class Program
    {

      

     
        static void Main(string[] args)
        {


            List<string> listShape1 = new List<string>();

            List<string> listShape2 = new List<string>();

            List<string> listShape3 = new List<string>();

            List<string> listShape4 = new List<string>();

            //List<string> listX = new List<string>();
            //List<string> listY = new List<string>();
            //List<string> listLength = new List<string>();
            //List<string> listPoints = new List<string>();

            int inputShapeTypeCircle = 0;
            int inputShapeTypeSquare = 0;


            var shapeScoreh = new List<double>();
            var shapeScorem = new List<double>();

            //Shape circle = new Circle();

            //var square = new Square();

            //var circle = new Circle();



            //Avser cirkel
            //Console.WriteLine("Ange en längd");
            //var inputLCircle = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ange poäng för objektet");
            //var inputPointsCircle = Convert.ToInt32(Console.ReadLine());



            //var stringInput = "SHAPE,X,Y,LENGTH,POINTS";

            //CIRCLE ,1,-1,15,200; square, -1 ,0 ,20 ,300; SQUARE , -3 ,2 ,8 ,400;"

            var input =
                "shape ,X,Y,LENGTH ,POINTS;CIRCLE ,3,1,13,100; CIRCLE ,1,-1,15,200; square, -1 ,0 ,20 ,300; SQUARE , -3 ,2 ,8 ,400;";
            var stringInput = input.ToUpper();
            //ATT MATA IN: shape ,X,Y,LENGTH ,points; CIRCLE ,3,1,13,100; CIRCLE ,1,-1,15,200; square, -1 ,0 ,20 ,300; SQUARE , -3 ,2 ,8 ,400;
            //Console.WriteLine("Mata in värdena");
            //var stringInput = Console.ReadLine().ToUpper();
            string trimmed = String.Concat(stringInput.Where(c => !Char.IsWhiteSpace(c)));

            Console.WriteLine("Upphöjda bokstäver" + trimmed);
            //var listHeader = trimmed.Split(';').ToList();



            //Header
            int startIndexHeader = 0;
            int lengthIndexHeader = 23;
            String substringHeader = trimmed.Substring(startIndexHeader, lengthIndexHeader);



            var headerVariables = Regex.Split(substringHeader, @",|;");

            foreach (var vari in headerVariables)
            {
                Console.WriteLine(vari + "test");

            }

            Console.WriteLine();
            //var trimInput = stringInput.Trim();
            //listSemiColon = trimmed.Split(';').ToList();


            //Variabler
            var startIndexVar = 24;
            var lengthIndexVar = 73;
            String substringVariables = trimmed.Substring(startIndexVar, lengthIndexVar);

            Console.WriteLine(substringVariables + "test222");

            var listVariables = Regex.Split(substringVariables, @";|,");

            int indexShape = Array.FindIndex(headerVariables, row => row.Contains("SHAPE"));
            int indexX = Array.FindIndex(headerVariables, row => row.Contains("X"));
            int indexY = Array.FindIndex(headerVariables, row => row.Contains("Y"));
            int indexPoints = Array.FindIndex(headerVariables, row => row.Contains("POINTS"));
            int indexLength = Array.FindIndex(headerVariables, row => row.Contains("LENGTH"));


            //Lägger till värdena för shape i en lista

            listShape1.Add(listVariables[indexShape]);
            listShape1.Add(listVariables[indexX]);
            listShape1.Add(listVariables[indexY]);
            listShape1.Add(listVariables[indexPoints]);
            listShape1.Add(listVariables[indexLength]);

            string substringVariables2 = substringVariables.Substring(substringVariables.IndexOf(';') + 1);
            var listVariables2 = Regex.Split(substringVariables2, @";|,");



            listShape2.Add(listVariables2[indexShape]);
            listShape2.Add(listVariables2[indexX]);
            listShape2.Add(listVariables2[indexY]);
            listShape2.Add(listVariables2[indexPoints]);
            listShape2.Add(listVariables2[indexLength]);


            var substringVariables3 = substringVariables2.Substring(substringVariables2.IndexOf(';') + 1);
            var listVariables3 = Regex.Split(substringVariables3, @";|,");


           
            listShape3.Add(listVariables3[indexShape]);
            listShape3.Add(listVariables3[indexX]);
            listShape3.Add(listVariables3[indexY]);
            listShape3.Add(listVariables3[indexLength]);
            listShape3.Add(listVariables3[indexPoints]);

            //foreach (var VARIABLE in listShape3)
            //{
            //    Console.WriteLine(VARIABLE + "listhshape3");
            //}

            var substringVariables4 = substringVariables3.Substring(substringVariables3.IndexOf(';') + 1);
            var listVariables4 = Regex.Split(substringVariables4, @";|,");
            Console.WriteLine(substringVariables4);
            listShape4.Add(listVariables4[indexShape]);
            listShape4.Add(listVariables4[indexX]);
            listShape4.Add(listVariables4[indexY]);
            listShape4.Add(listVariables4[indexLength]);
            listShape4.Add(listVariables4[indexPoints]);


            //foreach (var VARIABLE in listShape4)
            //{
            //    Console.WriteLine(VARIABLE + "listhshape4");
            //}

            //returnShape(listShape1);

            ////Squareklassen
            //bool HitSquare(int x1, int y1, int x2,
            //    int y2, int SquareX, int SquareY)
            //{
            //    if (SquareX > x1 && SquareX < x2 &&
            //        SquareY > y1 && SquareY < y2)
            //        return true;
            //    else
            //        return false;
            //}

            //bool HitCircle(int circleX, int circleY, int rad, int x, int y)
            //{

            //    if ((x - circleX) * (x - circleX) +
            //        (y - circleY) * (y - circleY) <= rad * rad)

            //        return true;

            //    else
            //        return false;
            //}

            //Skicka square eller triangle


            //public int Width { get; set; }
            //public int Height { get; set; }
            //x, y, length, shapetype, instancepoints, 
            //public abstract void Draw(List<string> listShape);
            //var variable = returnShape(listShape1);

            //string returnShape(List<string> listShape1)
            //{
            //    if (listShape1.Contains("CIRCLE"))
            //    {

            //        circle(listShape1);
            //    }
            //    else
            //    {
            //        square(listShape1);

            //    }
            //}
            Circle circle = new Circle();
            Square square = new Square();


            sendList(listShape1);
            sendList(listShape2);
            sendList(listShape3);
            sendList(listShape4);

           
            
            void sendList(List<string> listShape)
            {
              

                switch (listShape.Contains("CIRCLE"))
                {
                    case true:
                        circle.getList(listShape);
                      
                        break;

                    case false: 
                        square.getList(listShape);
                        break;

                }


                
            }


            






        //int returnShape(List<string> listShape1)
        //{

            //loopen slutar när den läser circle


            //foreach (var VARIABLE in listShape1)
            //{
            //    Console.WriteLine(VARIABLE +"test");
            //}

            //foreach (var VARIABLE in listShape2)
            //{
            //    Console.WriteLine(VARIABLE + "test2");
            //}

            //foreach (var VARIABLE in listShape3)
            //{
            //    Console.WriteLine(VARIABLE + "test234");
            //}

            //foreach (var VARIABLE in listShape4)
            //{
            //    Console.WriteLine(VARIABLE + "test28346234");
            //}

            //Console.WriteLine(indexX + "test");
            //Console.WriteLine(indexY + "test");
            //Console.WriteLine(indexShape + "test");
            //Console.WriteLine(indexPoints + "test");
            //Console.WriteLine(indexLength + "test");




            Console.WriteLine("Ange X för pricken");
                var userX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ange Y för pricken");
                var userY = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ange värdena");
                var userInput = Console.ReadLine();

                //foreach (var varh in listHeader)
                //{
                //    Console.WriteLine(varh);
                //}
                //Vi använder listheader för att särskilja cirkel och fyrkant
                //listShape.Add(listHeader[0]);
                //listShape.Add(listVariables[0]);
                //listShape.Add(listVariables[5]);
                //listShape.Add(listVariables[10]);
                //listShape.Add(listVariables[15]);
                //foreach (var l in listShape)
                //{
                //    Console.WriteLine(l);
                //}

                //forloop här?

                //listX.Add(listHeader[1]);
                //listX.Add(listVariables[1]);
                //listX.Add(listVariables[6]);
                //listX.Add(listVariables[11]);
                //listX.Add(listVariables[16]);

                //foreach (var xlist in listX)
                //{
                //    Console.WriteLine(xlist);
                //}

                //listY.Add(listHeader[2]);
                //listY.Add(listVariables[2]);
                //listY.Add(listVariables[7]);
                //listY.Add(listVariables[12]);
                //listY.Add(listVariables[17]);

                //foreach (var ylist in listY)
                //{
                //    Console.WriteLine(ylist);
                //}

                //listLength.Add(listHeader[3]);
                //listLength.Add(listVariables[3]);
                //listLength.Add(listVariables[8]);
                //listLength.Add(listVariables[13]);
                //listLength.Add(listVariables[18]);

                //foreach (var llist in listLength)
                //{
                //    Console.WriteLine(llist);
                //}

                //listPoints.Add(listHeader[4]);
                //listPoints.Add(listVariables[4]);
                //listPoints.Add(listVariables[9]);
                //listPoints.Add(listVariables[14]);
                //listPoints.Add(listVariables[19]);

                //foreach (var plist in listPoints)
                //{
                //    Console.WriteLine(plist);
                //}

                //var shapeNumber = returnShape(listShape);
                //Console.WriteLine("Det returneras en " + shapeNumber);

                //int returnShape(List<string> listShape)
                //{
                //    var retList = new List<string>();
                //    foreach (var item in listShape)
                //    {

                //        Console.WriteLine(item + "test");
                //    }
                //    //loopen slutar när den läser circle
                //    if (listShape.Contains("CIRCLE"))
                //        {
                //            return 2;
                //        }
                //    return 1;
                //}





                //var instancePointsCircle = inputPointsCircle;
                //var AreaCircle = 10;
                //var x = 51;
                //var y = 1;
                //var length = inputLCircle;
                //var circleX = 0;
                //var circleY = 1;
                //var rad = (int) (length / (2 * Math.PI));

                //var botX = 10;
                //var botY = 3;
                //var topX = 20;
                //var topY = 25;
                //var L = 4;


                //if (circle.HitCircle(circleX, circleY, rad, x, y))
                //{
                //    Console.WriteLine("Inuti cirkel");
                //    var eqCircleH = inputShapeTypeCircle * instancePointsCircle / AreaCircle;
                //    shapeScoreh.Add(eqCircleH);
                //}
                //else
                //{
                //    Console.WriteLine("Utanför cirkel");
                //    var eqCircleM = inputShapeTypeCircle * instancePointsCircle / AreaCircle;
                //    shapeScorem.Add(eqCircleM);
                //}

                //// bottom-left and top-right
                //// corners of rectangle
                ////int x1 = 0, y1 = 0,
                ////    x2 = 10, y2 = 8;

                ////Avser fyrkant
                //Console.WriteLine("Ange en längd");
                //var inputLengthSquare = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Ange poäng för objektet");
                //var inputPointsSquare = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Ange att det är en fyrkant = 1");
                ////var inputShapeTypeSquare = Convert.ToInt32(Console.ReadLine());

                //// given point
                //int SquareX = 1, SquareY = 5;

                //var x1 = botX - inputLengthSquare / 2;
                //var y1 = botY - inputLengthSquare / 2;
                //var x2 = topX + inputLengthSquare / 2;
                //var y2 = topY + inputLengthSquare / 2;


                //var instancePointsSquare = inputPointsSquare;
                //var AreaSquare = 10;

                //// function call
                //if (square.HitSquare(x1, y1, x2, y2, SquareX, SquareY))
                //{
                //    Console.Write("Inuti fyrkant");
                //    var eqSquareH = inputShapeTypeSquare * instancePointsSquare / AreaSquare;
                //    shapeScoreh.Add(eqSquareH);
                //}
                //else
                //{
                //    Console.Write("Utanför fyrkant");
                //    var eqSquareM = inputShapeTypeSquare * instancePointsSquare / AreaSquare;
                //    shapeScoreh.Add(eqSquareM);
                //}

                //Console.WriteLine(string.Join(", ", shapeScoreh));
                //Console.WriteLine(string.Join(", ", shapeScorem));
            }

     
        }
    }
