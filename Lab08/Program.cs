using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab09
// Date: 02/04/2015 09:15:19 am
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables to store users input
            double areaSquare;
            double areaCircle;
            double areaNeeded;
            double radiusCircle;
            double sideLength;


            //Inform user this program finds area in between 4 equal circles
            Console.WriteLine("Hello, I will help you find the area in between 4 equal circles.");

            //Request user input for the circle's radius
            Console.WriteLine("What is the radius of the circle you are aware of?");

            //Store users input for circle's radius
            radiusCircle = double.Parse(Console.ReadLine());

            //Find the area of the square in which the designated area resides
            //Double the radius given of the circles in order to find the length of the sides of the square
            sideLength = (radiusCircle + radiusCircle);

            //Multiply the length of the sides by itself to find the area of the sqaure
            //Store area of the square
            areaSquare = sideLength * sideLength;

            //Find the area of the 4 quarters of each circle by the equation A=PIr^2 using the radius stored previously
            //Store the area of the circle
            areaCircle = Math.PI * (radiusCircle * radiusCircle);

            //Take the area of the square and subtract the area of the circle
            //Store the result found as the area of the designated area at the cross section of all 4 circles
            areaNeeded = areaSquare - areaCircle;

            //Output to the User the area of the designated area
            Console.WriteLine("\n-----Area Calculated-----\n");
            Console.WriteLine($"{areaNeeded:n}");

            //Place ReadKey to allow the user time to see the answer
            Console.ReadKey();


        }
    }
}
