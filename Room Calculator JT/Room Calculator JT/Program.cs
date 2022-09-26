//calculate the peri and area of a room (should be able to handle decimals)

// The User will input the Length, Width, and Height of the room to find the Perimeter, Area, Volume, and Surface area of the room. When the User inputs the measurements of the room, the program will plug the values into the formulas for the respective problem. Then the program will display the results for each equation.
using System;

namespace RoomCalculator
{
    class MainClass
    {
        public static void Main()
        {
            //Finding length
            Console.WriteLine("You are in a rectangle-shaped classroom. What is the length of the room in feet");
            decimal Length = Convert.ToDecimal(Console.ReadLine());

            //Finding width
            Console.WriteLine("What is the width of the room in feet");
            decimal Width = Convert.ToDecimal(Console.ReadLine());

            //Finding height
            Console.WriteLine("What is the height of the room in feet");
            decimal Height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            //Finding perimiter
            decimal Peri = 2 * (Length + Width);
            Console.WriteLine("The perimeter of the classroom is {0} feet.", +Peri);
            Console.WriteLine();

            //Finding area
            decimal Area = (Length * Width);
            Console.WriteLine("The area of the classroom is {0} feet.", +Area);
            Console.WriteLine();

            //Finding volume
            decimal Volume = (Length * Height * Width);
            Console.WriteLine("The volume of the classroom is {0} feet^2.", +Volume);
            Console.WriteLine();

            //Finding surface area
            decimal SurfaceArea = 2 * ((Width * Length) + (Height * Length) + (Height * Width));
            Console.WriteLine("The surface area of the classroom is {0} feet.", +SurfaceArea);
            Console.WriteLine();

            //Determining what size the room is (S/M/L) based on the perimeter
            if (Peri <= 250)
            {
                Console.WriteLine("The room is Small");
            }
            else if (Peri < 650)
            {
                Console.WriteLine("The room is Medium");
            }
            else
            {
                Console.WriteLine("The room is Large");
            }
        }
    }
}