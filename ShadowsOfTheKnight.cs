using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        int startX = 0;
        int startY = 0;
        int maxX = W;
        int maxY = H;



        
        // game loop
        while (true)
        {
            string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
            Console.Error.WriteLine(bombDir);
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            if(bombDir == "U" || bombDir == "D" || bombDir == "L" || bombDir == "R")
            {
                if(bombDir == "U" || bombDir == "D" )
                {
                    if(bombDir == "U")
                    {
                        maxY = Y0;
                        int locY = moveToCenterY(maxY,startY);
                        Y0 = locY;
                        Console.WriteLine($"{X0} {locY}");
                    }
                    else if (bombDir == "D")
                    {
                        startY = Y0;
                        int locY = moveToCenterY(maxY,startY);
                        Y0 = locY;
                        Console.WriteLine($"{X0} {locY}");
                    }
                }
                else if(bombDir == "L" || bombDir == "R" )
                {
                    if(bombDir == "L")
                    {
                        maxX = X0;
                        int locX = moveToCenterX(maxX,startX);
                        X0 = locX;
                        Console.WriteLine($"{locX} {Y0}");
                    }
                    else if (bombDir == "R")
                    {
                        startX = X0;
                        int locX = moveToCenterX(maxX,startX);
                        X0 = locX;
                        Console.WriteLine($"{locX} {Y0}");
                    }
                }
            }
            else if(bombDir == "UL" || bombDir == "UR" || bombDir == "DL" || bombDir == "DR")
            {
                if(bombDir == "UL")
                {
                    maxY = Y0;
                    maxX = X0;
                    int locX = moveToCenterX(maxX,startX);
                    int locY = moveToCenterY(maxY,startY);
                    X0 = locX;
                    Y0 = locY;
                    Console.WriteLine($"{locX} {locY}");
                }
                else if(bombDir == "UR")
                {
                    maxY = Y0;
                    startX = X0;
                    int locX = moveToCenterX(maxX,startX);
                    int locY = moveToCenterY(maxY,startY);
                    X0 = locX;
                    Y0 = locY;
                    Console.WriteLine($"{locX} {locY}");
                }
                else if(bombDir == "DL")
                {
                    startY = Y0;
                    maxX = X0;
                    int locX = moveToCenterX(maxX,startX);
                    int locY = moveToCenterX(maxY,startY);
                    X0 = locX;
                    Y0 = locY;
                    Console.WriteLine($"{locX} {locY}");
                }
                else if(bombDir == "DR")
                {
                    startY = Y0;
                    startX = X0;
                    int locX = moveToCenterX(maxX,startX);
                    int locY = moveToCenterX(maxY,startY);
                    X0 = locX;
                    Y0 = locY;
                    Console.WriteLine($"{locX} {locY}");
                }
            }

            // the location of the next window Batman should jump to.
            
        }
    }
    public static string moveX(int n)
    {
        return $"{n} 0";    
    }
    public static string moveY(int n)
    {
        return $"0 {n}";    
    }
    public static int moveToCenterX(int xmax,int xstart)
    {
        int xdef = Math.Abs(xmax - xstart);
        int movex = xdef /2;
        return movex + xstart;
    }
    public static int moveToCenterY(int ymax ,int ystart)
    {
        int ydef = Math.Abs(ymax - ystart);
        int movey = ydef /2;
        return ystart+movey;
    }
}
