using System;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            bool runProgram = true;
            int CircleNum = 0;
            while (runProgram)
            {
                
                while (true)
                {

                    
                    try
                    {
                        Console.WriteLine("Hello Please enter the radius of your circle");
                        string input = Console.ReadLine();
                        bool legitNum = double.TryParse(input, out radius);
                        if (legitNum && radius > 0)
                        {
                            CircleNum += 1;

                            break;
                        }
                        else if (legitNum)
                        {
                            throw new Exception("Please try a positive number");
                        }
                        else
                        {
                            throw new Exception("Not a vaild in put, please try again with an integar");
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Not a valid input. Try again");
                    }
                }
                Circle MyCircle = new Circle(radius);
                string circ = MyCircle.CalcFormCirc();
                Console.WriteLine($"Circumference: {circ}");
                string circArea = MyCircle.CalcFormArea();
                Console.WriteLine($"Area: {circArea}");
                while (true)
                {
                    Console.WriteLine("Continue? y/n");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "y")
                    {
                        break;
                    }
                    else if (input.ToLower() == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter y or n");
                    }
                }
               
            }
            Console.WriteLine($"Goodbye. You created {CircleNum} Circle objects.");
        }
    }
}
