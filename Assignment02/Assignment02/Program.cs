/* Program.cs
 * Revision History
 *      Jaden Ahn, 2018-02-05: Created
 *      Jaden Ahn, 2018-02-06: Added try~ catch to prevent crash, just in case
 *                             Added P4 header comments
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstDimension = 0;
                int secondDimension = 0;
                int thirdDimension = 0;
                bool exit = false;

                Console.Clear();
                string notice = "";
                ShowMenu();

                while (!exit)
                {
                    Console.Write("Menu: ");
                    string reply = Console.ReadLine();
                    switch (reply)
                    {
                        case "1":
                            Console.WriteLine("Please enter the length of three dimensions of a triangle");
                            firstDimension = ValidateInt(firstDimension, "First Dimension");
                            secondDimension = ValidateInt(secondDimension, "Second Dimension");
                            thirdDimension = ValidateInt(thirdDimension, "Third Dimension");
                            notice = $"Successfully entered {firstDimension}, {secondDimension}, and {thirdDimension}\n" +
                                TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);
                            Console.Clear();
                            break;
                        case "2":
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            exit = true;
                            break;
                        default:
                            notice = "Please select 1 or 2";
                            break;
                    }
                    Console.Clear();
                    ShowMenu();
                    if (notice != "")
                    {
                        Console.WriteLine("* " + notice);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ShowMenu();
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");
        }

        static int ValidateInt(int dimensionLength, string name)
        {
            Console.Write(name + ": ");
            while (!int.TryParse(Console.ReadLine(), out dimensionLength))
            {
                Console.WriteLine("Invalid input. " + name + " must be an integer");
                Console.Write(name + ": ");
            }
            return dimensionLength;
        }
    }
}
